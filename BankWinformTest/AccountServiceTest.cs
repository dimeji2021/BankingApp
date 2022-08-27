using BankAppCore;
using BankAppCore.Model;
using BankAppCore.Services;
using Moq;
using System;
using Xunit;

namespace BankWinformTest
{
    public class AccountServiceTest
    {
        private readonly Mock<IReadWriteJson> _dbContainer;
        public AccountServiceTest()
        {
            _dbContainer = new Mock<IReadWriteJson>(); 
        }
        [Fact]
        public async void ShouldDepositAndReturnTrue()
        {
            //Arrange
            var accs =  await Helper.GetAllAccounts();

            _dbContainer.Setup(x => x.ReadJson<AccountModel>("Accounts.json")).ReturnsAsync(accs);
            _dbContainer.Setup(x => x.UpdateJson<AccountModel>(accs, "Accounts.json")).ReturnsAsync(true);
            //Act
            var cls = new Account(_dbContainer.Object);
            var actual = await cls.Deposit("024567890678", 8000);
            //Assert
            Assert.True(actual);
        }
        [Fact]
        public async void ShouldWithdrawAndReturnTrue()
        {
            //Arrange
            var accs = Helper.GetAllAccounts();
            var accs1 = await Helper.GetAllAccounts();

            _dbContainer.Setup(x => x.ReadJson<AccountModel>("Accounts.json")).Returns(accs);
            _dbContainer.Setup(x => x.UpdateJson<AccountModel>(accs1, "Accounts.json")).ReturnsAsync(true);
            //Act
            var cls = new Account(_dbContainer.Object);
            var actual = await cls.Withdraw("324567890678", 6000);
            //Assert
            Assert.True(actual);
        }
        [Theory]
        [InlineData("324567890678",70000)]
        [InlineData("024567890678", 1000)]
        [InlineData("678000890678", 5000)]
        public async void ShouldGetBalanceOFGivenAccount(string actual, double expected)
        {
            //Arrange
            var accs = Helper.GetAllAccounts();
            _dbContainer.Setup(x => x.ReadJson<AccountModel>("Accounts.json")).Returns(accs);
            //Act
            var cls = new Account(_dbContainer.Object);
            var balance = await cls.GetBalance(actual);
            //Assert
            Assert.Equal(expected, balance);
        }
        [Fact]
        public async void ShouldAddTransaction()
        {
            //Arrange
            TransactionModel transaction = new TransactionModel
            {
                AccountNumber = "324567890678",
                Description = "Deposit",
                Amount =5000.ToString(),
                Balance=10000.ToString(),
                Date = DateTime.Now
            };
            _dbContainer.Setup(x => x.WriteJson<TransactionModel>(transaction, "Transaction.json")).ReturnsAsync(true);
            //Act
            var cls = new Account(_dbContainer.Object);
            await cls.AddTransaction(transaction);
            //Assert
            _dbContainer.Verify(x=>x.WriteJson<TransactionModel>(transaction, "Transaction.json"),Times.Once);

        }
        [Fact]
        public void ShouldThrowAddTransactionException()
        {
            //Arrange
            TransactionModel transaction = new TransactionModel
            {
                AccountNumber = "324567890678",
                Description = "Deposit",
                Amount = 5000.ToString(),
                Balance = 10000.ToString(),
                Date = DateTime.Now
            };
            _dbContainer.Setup(x => x.WriteJson<TransactionModel>(transaction, "Transaction.json")).Throws<Exception>();
            //Act
            var cls = new Account(_dbContainer.Object);
            //Assert
            Assert.ThrowsAsync<Exception>(() => cls.AddTransaction(transaction));

        }
    }
}
