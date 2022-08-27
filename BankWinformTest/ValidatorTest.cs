
using BankAppCore;
using BankAppCore.Services;
using Moq;
using Xunit;

namespace BankWinformTest
{
    public class ValidatorTest
    {
        public Mock<IValidator> mock = new Mock<IValidator>();
        [Theory]
        [InlineData("adedimeji@yahoo.com",true)]
        [InlineData("adedimejiyahoo.com", false)]
        [InlineData("adedimeji@yahoocom", false)]
        [InlineData("abcd@gmail.com", true)]
        public void Test1(string email,bool expected)
        {
            //Arrange
            mock.Setup(x => x.ValidateEmail(email)).Returns(expected);
            var validator = new Validator();
            //Act
            var actual = validator.ValidateEmail(email);
            //Asset
            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData("Adedimeji", true)]
        [InlineData("adedimeji", false)]
        [InlineData("2adedimeji", false)]
        [InlineData("D", false)]
        public void Test2(string name, bool expected)
        {
            //Arrange
            mock.Setup(x => x.ValidateEmail(name)).Returns(expected);
            var validator = new Validator();
            //Act
            var actual = validator.ValidateName(name);
            //Asset
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Adedimeji", false)]
        [InlineData("adedimeji", false)]
        [InlineData("2adedimeji", false)]
        [InlineData("D", false)]
        [InlineData("Adedimeji@2", true)]
        [InlineData("Adedime ji@2", false)]
        [InlineData("", false)]

        public void Test3(string password, bool expected)
        {
            //Arrange
            mock.Setup(x => x.ValidateEmail(password)).Returns(expected);
            var validator = new Validator();
            //Act
            var actual = validator.ValidatePassword(password);
            //Asset
            Assert.Equal(expected, actual);
        }
    }
}
