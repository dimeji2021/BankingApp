using BankAppCore.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankAppCore
{
    public interface IAccount
    {
        Task<bool> Deposit(string accNum, double amt);
        Task<bool> Withdraw(string accNum, double amt);
        Task AddTransaction(TransactionModel model);
        Task<List<TransactionModel>> GetAllTransactionsForThisAccount(string accNum);
        Task<double> GetBalance(string accNum);
    }
}