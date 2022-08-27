using BankAppCore.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankAppCore.Services
{   
    public class Account: IAccount
    {
        private readonly string accountFile = "Accounts.json";
        private readonly string transactionFile = "Transaction.json";
        private readonly IReadWriteJson _dbContainer;

        public Account(IReadWriteJson dbContainer)
        {
            _dbContainer = dbContainer;
        }


        public async Task<bool> Deposit(string accNum,double amt)
        {
            var acc = await _dbContainer.ReadJson<AccountModel>(accountFile);
            bool chk = false;
            foreach (var item in acc)
            {
                if (item.AccountNumber == accNum)
                {
                    item.Balance += amt;
                    await _dbContainer.UpdateJson(acc, accountFile);
                    TransactionModel transaction = new TransactionModel
                    {
                        AccountNumber = item.AccountNumber,
                        Description = "Deposit",
                        Amount = amt.ToString(),
                        Balance = item.Balance.ToString()
                    };
                    await AddTransaction(transaction);
                    chk= true;
                }
            }
            return chk;
        }
        public async Task<bool> Withdraw(string accNum, double amt)
        {
            var acc = await _dbContainer.ReadJson<AccountModel>(accountFile);
            bool chk = false;
            foreach (var item in acc)
            {
                if (item.AccountNumber == accNum)
                {
                    double minBalance = item.AccountType == "Saving" ? 1000.0 : 0.0;
                    if (amt <= item.Balance - minBalance)
                    {
                        item.Balance -= amt;
                        await _dbContainer.UpdateJson(acc, accountFile);
                        TransactionModel transaction = new TransactionModel
                        {
                            AccountNumber =item.AccountNumber,
                            Description = "Withdrawal",
                            Amount = amt.ToString(),
                            Balance = item.Balance.ToString()
                        };
                        await AddTransaction(transaction);
                        chk= true;
                    }
                }
            }
            return chk;
        }
        public async Task AddTransaction(TransactionModel model)
        {
            try
            {
                await _dbContainer.WriteJson(model, transactionFile);
            }
            catch (Exception)
            {

                throw;
            }
        }
     
        public async Task<double> GetBalance(string accNum)
        {
            try
            {
                var acc = await _dbContainer.ReadJson<AccountModel>(accountFile);
                double balance=0;
                foreach (var item in acc)
                {
                    if (item.AccountNumber == accNum)
                        balance= item.Balance;
                }
                return balance;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<TransactionModel>> GetAllTransactionsForThisAccount(string accNum)
        {
            List<TransactionModel> trans = new List<TransactionModel>();
            var transactions = await _dbContainer.ReadJson<TransactionModel>(transactionFile);
           
            foreach (var item in transactions)
            {
                if (item.AccountNumber == accNum)
                {
                    trans.Add(item);
                }
            }
            return trans;
        }


    }
}
