using BankAppCore;
using BankWinform;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppUI
{
    public partial class DashBoard : Form
    {
        private readonly IBank _bank;
        private readonly IAccount _account;
        private readonly IServiceProvider _serviceProvider;

        public DashBoard(IAccount account, IServiceProvider serviceProvider, IBank bank)
        {
            InitializeComponent();
            _account = account;
            _serviceProvider = serviceProvider;
            _bank = bank;
        }
        // DashboardSignUp
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            Login login = _serviceProvider.GetRequiredService<Login>();
            string accountType = rdbSavings.Checked ? "Saving" : "Current";
            var account = _bank.CreateAccount(login.user.Id,accountType);
            _bank.AddAccount(account);
            rtbAccountCreationMessage.Text = $"Bank Account Added!\n Your Account Number is : {account.AccountNumber}";
        }
        //Deposit
        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            string accNum = txtDepositAccNum.Text;
            if (await _bank.VerifyAccountNumber(accNum))
            {
                if (double.TryParse(txtDepositAmt.Text, out double amt))
                {
                    var successFul = await _account.Deposit(accNum, amt);
                    if (successFul)
                    {
                        MessageBox.Show("Transaction successful");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid amount");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Account Details!!");
            }
            
        }
        //Withdraw
        private async void btnWithdraw_Click(object sender, EventArgs e)
        {
            string accNum = txtWithdrawAccNum.Text;
            if (await _bank.VerifyAccountNumber(accNum))
            {
                if (double.TryParse(txtWithdrawAmt.Text, out double amt))
                {
                    var successFul = await _account.Withdraw(accNum, amt);
                    if (successFul)
                    {
                        MessageBox.Show("Transaction successful");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Fund!!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid amount");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Account Details!!");
            }
        }
        //Transfer
        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            string senderAccountDetails = txtSenderAccNum.Text;
            string receiverAccountDetails = txtReceiverAccNum.Text;
            bool proceed = true;
            if (!await _bank.VerifyAccountNumber(senderAccountDetails))
            {
                MessageBox.Show("Incorrect Debit Account Details!!");
                proceed = false;
            }
            if (!await _bank.VerifyAccountNumber(receiverAccountDetails))
            {
                MessageBox.Show("Receiver Account Details Cannot be found!!");
                proceed = false;
            }
            if (!double.TryParse(txtTransferAmount.Text, out double amt))
            {
                MessageBox.Show("Enter a valid amount");
                proceed = false;
            }
            if (proceed)
            {
                 var success=await _account.Withdraw(senderAccountDetails, amt);
                if (success)
                {
                     await _account.Deposit(receiverAccountDetails, amt);
                     MessageBox.Show("Transaction successful");
                }
                else
                {
                    MessageBox.Show("Insufficient Fund!!");
                }
            }
        }
        //Statement
        private async void btnProceedStatement_Click(object sender, EventArgs e)
        {
            string accNum = txtAccNumDetails.Text;
            dgAccountStatement.Rows.Clear();
            var transactions= await _account.GetAllTransactionsForThisAccount(accNum);
            if (transactions!=null)
            {
                foreach (var item in transactions)
                {
                    string[] row = new string[5];

                    row[0] = item.Date.ToString();
                    row[1] = item.AccountNumber;
                    row[2] = item.Amount;
                    row[3] = item.Description;
                    row[4] = item.Balance;
                    dgAccountStatement.Rows.Add(row);
                }
            }


        }
        //DashBoardPrintAccDetails
        private  async void btnAccountDetails_Click(object sender, EventArgs e)
        {
            Login login = _serviceProvider.GetRequiredService<Login>();
            dgAccountDetails.Rows.Clear();
            var acc = await _bank.PrintAccountDetails(login.user);
            foreach (var item in acc)
            {
                string[] row = new string[4];
                row[0] =login.user.FirstName + " " + login.user.LastName;
                row[1] =item.AccountNumber;
                row[2] =item.AccountType;
                row[3] =item.Balance.ToString();
                dgAccountDetails.Rows.Add(row);
            }
        }
        //DashBoardGetbalance
        private async void btnProceed_Click(object sender, EventArgs e)
        {
            string accNum = txtAccountNum.Text;
            if (await _bank.VerifyAccountNumber(accNum))
            {
                var accBal = await _account.GetBalance(accNum);
                rtbCheckBalanceMessage.Text = $"Your account balance = {accBal}";
            }
            else
            {
                MessageBox.Show("Account Not Found!!");
            }
        }
        // DashboardLogOut
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome fm = _serviceProvider.GetRequiredService<Welcome>();
            fm.Show();
        }
    }
}
