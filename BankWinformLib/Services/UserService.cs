using BankAppCore.Helper;
using BankAppCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCore.Services
{
    public class UserService : IUserService
    {
        private readonly string userFile = "User.json";
        private readonly IReadWriteJson _dbContainer;
        private readonly IUtilities _utilities;

        public UserService(IReadWriteJson dbContainer, IUtilities utilities)
        {
            _dbContainer = dbContainer;
            _utilities = utilities;
        }
        public async Task<bool> Register(UserModel user)
        {
            try
            {
                return await _dbContainer.WriteJson<UserModel>(user, userFile);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<UserModel> Login(string userName, string password)
        {
            string hashPassword = _utilities.ComputeSha256Hash(password);
            var user = await _dbContainer.ReadJson<UserModel>(userFile);
            foreach (var item in user)
            {
                if (item.UserName == userName && item.Password == hashPassword)
                    return item;
            }
            return null;
        }

    }
}
