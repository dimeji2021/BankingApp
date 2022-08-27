using Autofac.Extras.Moq;
using BankAppCore;
using BankAppCore.Model;
using BankAppCore.Services;
using EasyEncryption;
using Moq;
using System;
using Xunit;

namespace BankWinformTest
{
    public class UserServiceTest
    {
        private readonly Mock<IReadWriteJson> _dbContainer;
        private readonly Mock<IUtilities> _utilities;

        public UserServiceTest()
        {
            _dbContainer = new Mock<IReadWriteJson>();
            _utilities = new Mock<IUtilities>();
        }
        [Fact]
        public async void ShouldRegisterUser()
        {
            //Arrange
            var user = new UserModel
            {
                FirstName = "Basil",
                LastName = "Odogwu",
                Email = "basil@yahoo.com",
                UserName = "basil",
                Password = "Odobasil@2",
                Id = Guid.NewGuid().ToString()
            };
              _dbContainer.Setup(x =>x.WriteJson(user,"User.json")).ReturnsAsync(true);
                //Act
               var cls = new UserService(_dbContainer.Object,null);
               bool actual= await cls.Register(user);

                //Assert
                Assert.True(actual);
                    _dbContainer.Verify(x => x.WriteJson<UserModel>(user,"User.json"), Times.Once);
        }
        [Fact]
        public async void ShouldReturnUserWhenlogin()
        {
            //Arrange
            var users = Helper.GetUsers();
            _dbContainer.Setup(x => x.ReadJson<UserModel>("User.json")).ReturnsAsync(users);
            _utilities.Setup(x => x.ComputeSha256Hash("x")).Returns(SHA.ComputeSHA256Hash("x"));
     
            //Act
            var cls = new UserService(_dbContainer.Object,_utilities.Object);
            var actual = await cls.Login("basil", "Odobasil@2");

            //Assert
            Assert.True(actual != null); // Confirm
            _dbContainer.Verify(x => x.ReadJson<UserModel>("User.json"), Times.Once);
        }
    }
}
