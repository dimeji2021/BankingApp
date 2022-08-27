using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankAppCore.Services
{
    public class Validator : IValidator
    {
        public bool ValidateName(string name)
        {
            string s = @"^[A-Z][a-zA-z0-9]+$";
            return PerformRegEx(s, name);
        }
        public bool ValidateEmail(string email)
        {
            string s = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return PerformRegEx(s, email);
        }
        public bool ValidatePassword(string password)
        {
            string s = @"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[\W])(?!.* ).{6,}";
            return PerformRegEx(s, password);
        }
        private static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);


            if (re.IsMatch(value))
                return (true);
            else
                return (false);
        }
    }
}
