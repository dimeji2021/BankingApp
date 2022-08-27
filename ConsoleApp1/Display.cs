using BankAppCore;
using BankAppCore.Model;
using BankAppCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
        public class BankDisplay
        {
            private readonly IBank _bank;
            private readonly IValidator _validators;
            readonly List<UserModel> users = new List<UserModel>();

            public BankDisplay(IBank bank, IValidator validators)
            {
                _bank = bank;
                _validators = validators;
            }

            public void ShowBankDisplay()
            {
                while (true)
                {

                    Console.Write("1. Set up user account\n2. Login\n3. Exit \n\nSelect Function: ");
                    string selGo = Console.ReadLine().ToUpper();
                    Console.WriteLine("\n");
                    if (selGo == "1")
                    {
                        string firstName;
                        string lastName;
                        string email;
                        string password;
                        while (true)
                        {
                            Console.WriteLine("Please Enter Your First Name: ");
                            firstName = Console.ReadLine();
                            if (_validators.ValidateName(firstName))
                            {
                                break;
                            }
                            Console.WriteLine("Please input the right format\n Names should start with capital letter, Like Boss");
                        }
                        while (true)
                        {
                            Console.WriteLine("Please Enter Your Last Name: ");
                            lastName = Console.ReadLine();
                            if (_validators.ValidateName(lastName))
                            {
                                break;
                            }
                            Console.WriteLine("Please input the right format\n Names should start with capital letter, Like Boss");
                        }

                    while (true)
                        {
                            Console.WriteLine("Please Enter Your Email: ");
                            email = Console.ReadLine();
                            if (_validators.ValidateEmail(email))
                            {
                                break;
                            }
                            Console.WriteLine("Please input the right email format");
                        }
                        while (true)
                        {
                            Console.WriteLine("Please Enter Your Password: ");
                            password = Console.ReadLine();
                            if (_validators.ValidatePassword(password))
                            {
                                break;
                            }
                            Console.WriteLine("Please input the right format\n Password should minimum of 6 characters including special character");
                        }


                        try
                        {
                            UserModel person = new UserModel()
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                Email = email,
                                Password = password
                            };
                            users.Add(person);
                            Console.WriteLine("Account has been successfull created !!!\n Press 2 to Login");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }



                    }
                    else if (selGo == "2")
                    {
                        string email;
                        string password;
                        while (true)
                        {
                            Console.WriteLine("Please Enter Your Email: ");
                            email = Console.ReadLine();
                            if (_validators.ValidateEmail(email))
                            {
                                break;
                            }
                            Console.WriteLine("Please input the right email format");
                        }
                        while (true)
                        {
                            Console.WriteLine("Please Enter Your Password: ");
                            password = Console.ReadLine();
                            if (_validators.ValidatePassword(password))
                            {
                                break;
                            }
                            Console.WriteLine("Please input the right format\n Password should minimum of 6 characters including special character");
                        }
                        UserModel login = _bank.Login(users, email, password);
                        if (login != null)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to PIGGY BANK APP");
                            _bank.ShowAccountUI(login);


                        }
                        else
                        {
                            Console.WriteLine("Please Invalid Credentials, Press 2 to try again");
                            Console.ReadLine();
                        }
                    }

                    else if (selGo == "3")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid Syntax!");
                        Console.ReadLine();
                    }
                    Console.Clear();
                }
            }
        }
}
