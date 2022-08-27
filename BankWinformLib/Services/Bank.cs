using BankAppCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCore.Services
{
    public class Bank : IBank
    {
        private readonly string accountFile = "Accounts.json";
        public readonly AccountModel account = new AccountModel();
        private readonly IReadWriteJson _dbContainer;

        public Bank(IReadWriteJson dbContainer)
        {
            _dbContainer = dbContainer;
        }
        public AccountModel CreateAccount(string id, string accountType)
        {
            account.Balance += 0;
            account.AccountNumber = RandomDigits(10);
            account.AccountType = accountType;
            account.UserId = id;
            account.TransactionsList = new List<TransactionModel>();
            return account;

        }
        public async Task<bool> AddAccount(AccountModel model)
        {
            try
            {
                return await _dbContainer.WriteJson(model, accountFile);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<AccountModel>> PrintAccountDetails(UserModel user)
        {
            List<AccountModel> accounts = new List<AccountModel>();
            var account = await _dbContainer.ReadJson<AccountModel>(accountFile);
            foreach (var item in account)
            {
                if (item.UserId == user.Id)
                {
                    accounts.Add(item);
                }
            }
            return accounts;
        }
        public async Task<bool> VerifyAccountNumber(string accNum)
        {
            var acc = await _dbContainer.ReadJson<AccountModel>(accountFile);
            foreach (var item in acc)
            {
                if (item.AccountNumber == accNum)
                {
                    return true;
                }
            }
            return false;
        }
        private static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

    }
}
