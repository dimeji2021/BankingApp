using BankAppCore.Model;
using System.Threading.Tasks;

namespace BankAppCore
{
    public interface IUserService
    {
        Task<UserModel> Login(string userName, string password);
        Task<bool> Register(UserModel user);
    }
}