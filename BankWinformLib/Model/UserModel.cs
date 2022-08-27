using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppCore.Model
{
    public class UserModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
