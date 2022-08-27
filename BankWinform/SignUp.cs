using BankAppCore;
using BankAppCore.Model;
using BankWinform;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BankAppUI
{
    public partial class SignUp : Form
    {
        private IServiceProvider _serviceProvider;
        private readonly IUserService _user;
        private readonly IValidator _validate;
        private readonly IUtilities _utilities;


        public SignUp(IUserService user, IValidator validate, IUtilities utilities, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _user = user;
            _validate = validate;
            _utilities = utilities;
            _serviceProvider = serviceProvider;
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string Password = _utilities.ComputeSha256Hash(txtPassword.Text);
            string userName = txtUserName.Text;
            string confirmedPassword = txtPasswordConfirm.Text;
            bool proceed = true;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First Name should not be left empty!!");

                proceed = false;
            }
            else if (!_validate.ValidateName(firstName))
            {
                MessageBox.Show("First Name should start with Uppercase!!");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last Name should not be left empty!!");

                proceed = false;
            }
            else if (!_validate.ValidateName(lastName))
            {
                MessageBox.Show("last Name should start with Uppercase!!.");

                proceed = false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email should not be left empty!!");

                proceed = false;
            }
            else if (!_validate.ValidateEmail(email))
            {
                MessageBox.Show("Enter a valid email address e.g abcd@yahoo.com");
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password should not be left empty!!");

                proceed = false;
            }
            else if (!_validate.ValidatePassword(txtPassword.Text))
            {
                MessageBox.Show("Enter a valid password!! Password must be Alphanumeric and contain at least one special character");
                proceed = false;
            }
            if (!txtPassword.Text.Equals(confirmedPassword))
            {
               MessageBox.Show("Password must match.");
               proceed = false;
            }

            if (proceed)
            {

                UserModel user = new UserModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = userName,
                    Password = Password,

                };
                var result = await _user.Register(user);
                if (result)
                {
                    MessageBox.Show("Registration successful! Login to set up you account");
                    this.Hide();
                    Welcome welcome = _serviceProvider.GetRequiredService<Welcome>();
                    welcome.Show();
                }
                else
                {
                    MessageBox.Show("Registration Unsuccessful!");
                }
            }
        }
        //private void TxtFirstName_TextChanged(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtFirstName.Text))
        //    {
        //        e.Cancel = true;
        //        txtFirstName.Focus();
        //        errorProviderApp.SetError(txtFirstName, "First Name should not be left blank!");
        //    }
        //    else if (!_validate.ValidateName(txtFirstName.Text))
        //    {
        //        e.Cancel = true;
        //        txtFirstName.Focus();
        //        errorProviderApp.SetError(txtFirstName, "First Name should start with UpperCase!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProviderApp.SetError(txtFirstName, "");
        //    }
        //}
        //private void txtLastName_TextChanged(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtLastName.Text))
        //    {
        //        e.Cancel = true;
        //        txtLastName.Focus();
        //        errorProviderApp.SetError(txtLastName, "Last Name should not be left blank!");
        //    }
        //    else if (!_validate.ValidateName(txtLastName.Text))
        //    {
        //        e.Cancel = true;
        //        txtLastName.Focus();
        //        errorProviderApp.SetError(txtLastName, "Last Name should start with UpperCase!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProviderApp.SetError(txtLastName, "");
        //    }
        //}

        //private void txtEmail_TextChanged(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtEmail.Text))
        //    {
        //        e.Cancel = true;
        //        txtEmail.Focus();
        //        errorProviderApp.SetError(txtEmail, "Email should not be left blank!");
        //    }
        //    else if (!_validate.ValidateEmail(txtEmail.Text))
        //    {
        //        e.Cancel = true;
        //        txtEmail.Focus();
        //        errorProviderApp.SetError(txtEmail, "Email should start with UpperCase!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProviderApp.SetError(txtEmail, "");
        //    }
        //}

        //private void txtPasswordConfirm_TextChanged(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtPassword.Text))
        //    {
        //        e.Cancel = true;
        //        txtPassword.Focus();
        //        errorProviderApp.SetError(txtPassword, "Password should not be left blank!");
        //    }
        //    else if (!_validate.ValidatePassword(txtPassword.Text))
        //    {
        //        e.Cancel = true;
        //        txtPassword.Focus();
        //        errorProviderApp.SetError(txtPassword, "Password must be AlphaNumeric and must contain at least one special character!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProviderApp.SetError(txtPassword, "");
        //    }
        //}

        //private void txtPassword_TextChanged(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtPasswordConfirm.Text))
        //    {
        //        e.Cancel = true;
        //        txtPasswordConfirm.Focus();
        //        errorProviderApp.SetError(txtPasswordConfirm, "Confirm your password!");
        //    }
        //    else if (!txtPassword.Text.Equals(txtPasswordConfirm))
        //    {
        //        e.Cancel = true;
        //        txtPasswordConfirm.Focus();
        //        errorProviderApp.SetError(txtPasswordConfirm, "Password must match!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProviderApp.SetError(txtPasswordConfirm, "");
        //    }
        //}

        //private void txtFirstName_TextChanged(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtFirstName.Text))
        //    {
        //        e.Cancel = true;
        //        txtFirstName.Focus();
        //        errorProviderApp.SetError(txtFirstName, "First Name should not be left blank!");
        //    }
        //    else if (!_validate.ValidateName(txtFirstName.Text))
        //    {
        //        e.Cancel = true;
        //        txtFirstName.Focus();
        //        errorProviderApp.SetError(txtFirstName, "First Name should start with UpperCase!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProviderApp.SetError(txtFirstName, "");
        //    }
        //}
    }
}
