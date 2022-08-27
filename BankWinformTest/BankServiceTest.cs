using BankAppCore;
using BankAppCore.Model;
using BankAppCore.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankWinformTest
{
    public class BankServiceTest
    {
        private readonly Mock<IReadWriteJson> _dbContainer;
        public BankServiceTest()
        {
            _dbContainer = new Mock<IReadWriteJson>();
        }
        [Fact]
        public async void ShouldAddBank()
        {
            //Arrange
            var acc = new AccountModel
            {
                AccountNumber = "324567890678",
                Balance = 70000,
                AccountType = "Savings",
                UserId = Guid.NewGuid().ToString(),
            };
            _dbContainer.Setup(x => x.WriteJson(acc, "Accounts.json")).ReturnsAsync(true);

            //Act
            var cls = new Bank(_dbContainer.Object);
            var actual = await cls.AddAccount(acc);
            //Assert
            Assert.True(actual);
            _dbContainer.Verify(x => x.WriteJson<AccountModel>(acc, "Accounts.json"), Times.Once);
        }
        [Fact]
        public async void ShouldVerifyAccountDetailsAndReturnTrue()
        { 
            var accs = Helper.GetAllAccounts();
            _dbContainer.Setup(x => x.ReadJson<AccountModel>("Accounts.json")).Returns(accs);

            //Act
            var cls = new Bank(_dbContainer.Object);
            var actual = await cls.VerifyAccountNumber("678000890678");
            //Assert
            Assert.True(actual);
            //_dbContainer.Verify(x => x.WriteJson<AccountModel>(accs, "Accounts.json"), Times.Once); //Confirm This
        }
    }
}
