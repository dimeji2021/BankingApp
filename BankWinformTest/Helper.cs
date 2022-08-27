using BankAppCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BankWinformTest
{
    class Helper
    {
        public static List<UserModel> GetUsers()
        {
            List<UserModel> user = new List<UserModel>
            {
                new UserModel
                {
                    FirstName = "Basil",
                    LastName = "Odogwu",
                    Email = "basil@yahoo.com",
                    UserName = "basil",
                    Password = "Odobasil@2",
                    Id = Guid.NewGuid().ToString()
                },
                new UserModel
                {
                    FirstName = "Dimeji",
                    LastName = "Kehinde",
                    Email = "dimeji@yahoo.com",
                    UserName = "adedimeji",
                    Password = "Adedimeji@2",
                    Id = Guid.NewGuid().ToString()
                },
                new UserModel
                {
                    FirstName = "Valentine",
                    LastName = "Ekechukwu",
                    Email = "val@yahoo.com",
                    UserName = "valentine",
                    Password = "Valentine@2",
                    Id = Guid.NewGuid().ToString()
                },
            };
            return user;
        }
        public static Task<List<AccountModel>> GetAllAccounts()
        {
            List<AccountModel> accs = new List<AccountModel>
            {
                new AccountModel
                {
                    AccountNumber = "324567890678",
                    Balance = 70000,
                    AccountType = "Savings",
                    UserId = Guid.NewGuid().ToString(),
                },
                new AccountModel
                {
                    AccountNumber = "024567890678",
                    Balance = 1000,
                    AccountType = "Savings",
                    UserId = Guid.NewGuid().ToString(),
                },
                new AccountModel
                {
                    AccountNumber = "678000890678",
                    Balance = 5000,
                    AccountType = "Savings",
                    UserId = Guid.NewGuid().ToString(),
                }
            };
            return Task.FromResult(accs);
        }
    }
}
