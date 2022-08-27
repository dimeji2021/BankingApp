using BankAppUI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BankWinform
{
    public partial class Welcome : Form
    {
        private  IServiceProvider _serviceProvider;
        public Welcome(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp signup = _serviceProvider.GetRequiredService<SignUp>();
            signup.Show();
            this.Hide();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = _serviceProvider.GetRequiredService<Login>();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

