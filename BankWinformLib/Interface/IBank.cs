using BankAppCore.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankAppCore
{
    public interface IBank
    {
        Task<bool> AddAccount(AccountModel model);
        AccountModel CreateAccount(string id, string accountType);
        Task<List<AccountModel>> PrintAccountDetails(UserModel user);
        Task<bool> VerifyAccountNumber(string accNum);
    }
}