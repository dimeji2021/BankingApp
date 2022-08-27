namespace BankAppCore
{
    public interface IValidator
    {
        bool ValidateEmail(string email);
        bool ValidateName(string name);
        bool ValidatePassword(string password);
    }
}