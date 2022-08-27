using BankAppCore;
using BankAppCore.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BankAppUI
{
    public partial class Login : Form
    {
        private readonly IUserService _user;
        private readonly IServiceProvider _serviceProvider;
        public UserModel user;
        public Login(IUserService user,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _user = user;
            _serviceProvider = serviceProvider;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password =txtPassword.Text;
            user= await _user.Login(userName, password);
            if (user!=null)
            {
                DashBoard dashBoard = _serviceProvider.GetRequiredService<DashBoard>();
                dashBoard.Show();
                return;
            }
            else
            {
                MessageBox.Show("Your user name or password is incorrect");
            }
        }
    }
}
