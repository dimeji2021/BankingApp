
namespace BankAppUI
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDashBoard = new System.Windows.Forms.TabControl();
            this.tbDeposit = new System.Windows.Forms.TabPage();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.txtDepositAccNum = new System.Windows.Forms.TextBox();
            this.tbWithdraw = new System.Windows.Forms.TabPage();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdrawAmt = new System.Windows.Forms.TextBox();
            this.txtWithdrawAccNum = new System.Windows.Forms.TextBox();
            this.tbTransfer = new System.Windows.Forms.TabPage();
            this.txtSenderAccNum = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.txtReceiverAccNum = new System.Windows.Forms.TextBox();
            this.tbAccountStatement = new System.Windows.Forms.TabPage();
            this.dgAccountStatement = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProceedStatement = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccNumDetails = new System.Windows.Forms.TextBox();
            this.tbAccountDetails = new System.Windows.Forms.TabPage();
            this.dgAccountDetails = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccountDetails = new System.Windows.Forms.Button();
            this.tbCheckBalance = new System.Windows.Forms.TabPage();
            this.btnProceed = new System.Windows.Forms.Button();
            this.rtbCheckBalanceMessage = new System.Windows.Forms.RichTextBox();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSetUpAccount = new System.Windows.Forms.TabPage();
            this.rtbAccountCreationMessage = new System.Windows.Forms.RichTextBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.rdbCurrent = new System.Windows.Forms.RadioButton();
            this.rdbSavings = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogOut = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tbDashBoard.SuspendLayout();
            this.tbDeposit.SuspendLayout();
            this.tbWithdraw.SuspendLayout();
            this.tbTransfer.SuspendLayout();
            this.tbAccountStatement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).BeginInit();
            this.tbAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountDetails)).BeginInit();
            this.tbCheckBalance.SuspendLayout();
            this.tbSetUpAccount.SuspendLayout();
            this.tbLogOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDashBoard
            // 
            this.tbDashBoard.Controls.Add(this.tbDeposit);
            this.tbDashBoard.Controls.Add(this.tbWithdraw);
            this.tbDashBoard.Controls.Add(this.tbTransfer);
            this.tbDashBoard.Controls.Add(this.tbAccountStatement);
            this.tbDashBoard.Controls.Add(this.tbAccountDetails);
            this.tbDashBoard.Controls.Add(this.tbCheckBalance);
            this.tbDashBoard.Controls.Add(this.tbSetUpAccount);
            this.tbDashBoard.Controls.Add(this.tbLogOut);
            this.tbDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDashBoard.Location = new System.Drawing.Point(0, 0);
            this.tbDashBoard.Name = "tbDashBoard";
            this.tbDashBoard.SelectedIndex = 0;
            this.tbDashBoard.Size = new System.Drawing.Size(896, 450);
            this.tbDashBoard.TabIndex = 0;
            // 
            // tbDeposit
            // 
            this.tbDeposit.BackColor = System.Drawing.Color.IndianRed;
            this.tbDeposit.Controls.Add(this.btnDeposit);
            this.tbDeposit.Controls.Add(this.txtDepositAmt);
            this.tbDeposit.Controls.Add(this.txtDepositAccNum);
            this.tbDeposit.Location = new System.Drawing.Point(4, 24);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeposit.Size = new System.Drawing.Size(888, 422);
            this.tbDeposit.TabIndex = 0;
            this.tbDeposit.Text = "Deposit";
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Location = new System.Drawing.Point(56, 206);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(151, 33);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtDepositAmt
            // 
            this.txtDepositAmt.Location = new System.Drawing.Point(56, 156);
            this.txtDepositAmt.Name = "txtDepositAmt";
            this.txtDepositAmt.PlaceholderText = "Amount";
            this.txtDepositAmt.Size = new System.Drawing.Size(483, 23);
            this.txtDepositAmt.TabIndex = 1;
            // 
            // txtDepositAccNum
            // 
            this.txtDepositAccNum.Location = new System.Drawing.Point(56, 109);
            this.txtDepositAccNum.Name = "txtDepositAccNum";
            this.txtDepositAccNum.PlaceholderText = "Account Number";
            this.txtDepositAccNum.Size = new System.Drawing.Size(483, 23);
            this.txtDepositAccNum.TabIndex = 0;
            // 
            // tbWithdraw
            // 
            this.tbWithdraw.BackColor = System.Drawing.Color.Coral;
            this.tbWithdraw.Controls.Add(this.btnWithdraw);
            this.tbWithdraw.Controls.Add(this.txtWithdrawAmt);
            this.tbWithdraw.Controls.Add(this.txtWithdrawAccNum);
            this.tbWithdraw.Location = new System.Drawing.Point(4, 24);
            this.tbWithdraw.Name = "tbWithdraw";
            this.tbWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tbWithdraw.Size = new System.Drawing.Size(888, 422);
            this.tbWithdraw.TabIndex = 1;
            this.tbWithdraw.Text = "Withdraw";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Location = new System.Drawing.Point(105, 243);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(151, 33);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtWithdrawAmt
            // 
            this.txtWithdrawAmt.Location = new System.Drawing.Point(105, 193);
            this.txtWithdrawAmt.Name = "txtWithdrawAmt";
            this.txtWithdrawAmt.PlaceholderText = "Amount";
            this.txtWithdrawAmt.Size = new System.Drawing.Size(483, 23);
            this.txtWithdrawAmt.TabIndex = 4;
            // 
            // txtWithdrawAccNum
            // 
            this.txtWithdrawAccNum.Location = new System.Drawing.Point(105, 146);
            this.txtWithdrawAccNum.Name = "txtWithdrawAccNum";
            this.txtWithdrawAccNum.PlaceholderText = "Account Number";
            this.txtWithdrawAccNum.Size = new System.Drawing.Size(483, 23);
            this.txtWithdrawAccNum.TabIndex = 3;
            // 
            // tbTransfer
            // 
            this.tbTransfer.BackColor = System.Drawing.Color.Chocolate;
            this.tbTransfer.Controls.Add(this.txtSenderAccNum);
            this.tbTransfer.Controls.Add(this.btnTransfer);
            this.tbTransfer.Controls.Add(this.txtTransferAmount);
            this.tbTransfer.Controls.Add(this.txtReceiverAccNum);
            this.tbTransfer.Location = new System.Drawing.Point(4, 24);
            this.tbTransfer.Name = "tbTransfer";
            this.tbTransfer.Size = new System.Drawing.Size(888, 422);
            this.tbTransfer.TabIndex = 2;
            this.tbTransfer.Text = "Transfer";
            // 
            // txtSenderAccNum
            // 
            this.txtSenderAccNum.Location = new System.Drawing.Point(105, 95);
            this.txtSenderAccNum.Name = "txtSenderAccNum";
            this.txtSenderAccNum.PlaceholderText = "Account Number to Debit";
            this.txtSenderAccNum.Size = new System.Drawing.Size(483, 23);
            this.txtSenderAccNum.TabIndex = 6;
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Location = new System.Drawing.Point(105, 243);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(151, 33);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(105, 193);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.PlaceholderText = "Amount";
            this.txtTransferAmount.Size = new System.Drawing.Size(483, 23);
            this.txtTransferAmount.TabIndex = 4;
            // 
            // txtReceiverAccNum
            // 
            this.txtReceiverAccNum.Location = new System.Drawing.Point(105, 146);
            this.txtReceiverAccNum.Name = "txtReceiverAccNum";
            this.txtReceiverAccNum.PlaceholderText = "Destination Account Details";
            this.txtReceiverAccNum.Size = new System.Drawing.Size(483, 23);
            this.txtReceiverAccNum.TabIndex = 3;
            // 
            // tbAccountStatement
            // 
            this.tbAccountStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbAccountStatement.Controls.Add(this.dgAccountStatement);
            this.tbAccountStatement.Controls.Add(this.btnProceedStatement);
            this.tbAccountStatement.Controls.Add(this.label5);
            this.tbAccountStatement.Controls.Add(this.txtAccNumDetails);
            this.tbAccountStatement.Location = new System.Drawing.Point(4, 24);
            this.tbAccountStatement.Name = "tbAccountStatement";
            this.tbAccountStatement.Size = new System.Drawing.Size(888, 422);
            this.tbAccountStatement.TabIndex = 3;
            this.tbAccountStatement.Text = "Account Statement";
            // 
            // dgAccountStatement
            // 
            this.dgAccountStatement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAccountStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAccountStatement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgAccountStatement.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgAccountStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column2});
            this.dgAccountStatement.Location = new System.Drawing.Point(3, 137);
            this.dgAccountStatement.Name = "dgAccountStatement";
            this.dgAccountStatement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgAccountStatement.RowTemplate.Height = 25;
            this.dgAccountStatement.Size = new System.Drawing.Size(885, 282);
            this.dgAccountStatement.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Account Number";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Balance";
            this.Column2.Name = "Column2";
            // 
            // btnProceedStatement
            // 
            this.btnProceedStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceedStatement.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProceedStatement.Location = new System.Drawing.Point(349, 68);
            this.btnProceedStatement.Name = "btnProceedStatement";
            this.btnProceedStatement.Size = new System.Drawing.Size(151, 37);
            this.btnProceedStatement.TabIndex = 6;
            this.btnProceedStatement.Text = "Proceed";
            this.btnProceedStatement.UseVisualStyleBackColor = true;
            this.btnProceedStatement.Click += new System.EventHandler(this.btnProceedStatement_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Account Number";
            // 
            // txtAccNumDetails
            // 
            this.txtAccNumDetails.Location = new System.Drawing.Point(349, 20);
            this.txtAccNumDetails.Multiline = true;
            this.txtAccNumDetails.Name = "txtAccNumDetails";
            this.txtAccNumDetails.PlaceholderText = "Account Number";
            this.txtAccNumDetails.Size = new System.Drawing.Size(474, 23);
            this.txtAccNumDetails.TabIndex = 1;
            // 
            // tbAccountDetails
            // 
            this.tbAccountDetails.BackColor = System.Drawing.Color.Maroon;
            this.tbAccountDetails.Controls.Add(this.dgAccountDetails);
            this.tbAccountDetails.Controls.Add(this.btnAccountDetails);
            this.tbAccountDetails.Location = new System.Drawing.Point(4, 24);
            this.tbAccountDetails.Name = "tbAccountDetails";
            this.tbAccountDetails.Size = new System.Drawing.Size(888, 422);
            this.tbAccountDetails.TabIndex = 4;
            this.tbAccountDetails.Text = "Account detatails";
            // 
            // dgAccountDetails
            // 
            this.dgAccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgAccountDetails.Location = new System.Drawing.Point(0, 127);
            this.dgAccountDetails.Name = "dgAccountDetails";
            this.dgAccountDetails.RowTemplate.Height = 25;
            this.dgAccountDetails.Size = new System.Drawing.Size(892, 295);
            this.dgAccountDetails.TabIndex = 6;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Account Number";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Account Type";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Balance";
            this.Column9.Name = "Column9";
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.BackColor = System.Drawing.Color.White;
            this.btnAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccountDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccountDetails.Location = new System.Drawing.Point(614, 33);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(244, 37);
            this.btnAccountDetails.TabIndex = 5;
            this.btnAccountDetails.Text = "Proceed to get statement";
            this.btnAccountDetails.UseVisualStyleBackColor = false;
            this.btnAccountDetails.Click += new System.EventHandler(this.btnAccountDetails_Click);
            // 
            // tbCheckBalance
            // 
            this.tbCheckBalance.BackColor = System.Drawing.Color.Maroon;
            this.tbCheckBalance.Controls.Add(this.btnProceed);
            this.tbCheckBalance.Controls.Add(this.rtbCheckBalanceMessage);
            this.tbCheckBalance.Controls.Add(this.txtAccountNum);
            this.tbCheckBalance.Controls.Add(this.label2);
            this.tbCheckBalance.Location = new System.Drawing.Point(4, 24);
            this.tbCheckBalance.Name = "tbCheckBalance";
            this.tbCheckBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tbCheckBalance.Size = new System.Drawing.Size(888, 422);
            this.tbCheckBalance.TabIndex = 5;
            this.tbCheckBalance.Text = "Check Balance";
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Silver;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProceed.Location = new System.Drawing.Point(438, 64);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(124, 37);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // rtbCheckBalanceMessage
            // 
            this.rtbCheckBalanceMessage.Location = new System.Drawing.Point(6, 113);
            this.rtbCheckBalanceMessage.Name = "rtbCheckBalanceMessage";
            this.rtbCheckBalanceMessage.Size = new System.Drawing.Size(876, 71);
            this.rtbCheckBalanceMessage.TabIndex = 2;
            this.rtbCheckBalanceMessage.Text = "";
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Location = new System.Drawing.Point(438, 35);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(426, 23);
            this.txtAccountNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Number";
            // 
            // tbSetUpAccount
            // 
            this.tbSetUpAccount.BackColor = System.Drawing.Color.Firebrick;
            this.tbSetUpAccount.Controls.Add(this.rtbAccountCreationMessage);
            this.tbSetUpAccount.Controls.Add(this.btnCreateAcc);
            this.tbSetUpAccount.Controls.Add(this.rdbCurrent);
            this.tbSetUpAccount.Controls.Add(this.rdbSavings);
            this.tbSetUpAccount.Controls.Add(this.label3);
            this.tbSetUpAccount.Location = new System.Drawing.Point(4, 24);
            this.tbSetUpAccount.Name = "tbSetUpAccount";
            this.tbSetUpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tbSetUpAccount.Size = new System.Drawing.Size(888, 422);
            this.tbSetUpAccount.TabIndex = 6;
            this.tbSetUpAccount.Text = "Set-Up Account";
            // 
            // rtbAccountCreationMessage
            // 
            this.rtbAccountCreationMessage.Location = new System.Drawing.Point(-4, 263);
            this.rtbAccountCreationMessage.Name = "rtbAccountCreationMessage";
            this.rtbAccountCreationMessage.Size = new System.Drawing.Size(892, 74);
            this.rtbAccountCreationMessage.TabIndex = 7;
            this.rtbAccountCreationMessage.Text = "";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCreateAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateAcc.Location = new System.Drawing.Point(445, 180);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(75, 32);
            this.btnCreateAcc.TabIndex = 6;
            this.btnCreateAcc.Text = "Add";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // rdbCurrent
            // 
            this.rdbCurrent.AutoSize = true;
            this.rdbCurrent.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbCurrent.Location = new System.Drawing.Point(583, 110);
            this.rdbCurrent.Name = "rdbCurrent";
            this.rdbCurrent.Size = new System.Drawing.Size(85, 21);
            this.rdbCurrent.TabIndex = 5;
            this.rdbCurrent.Text = "Current";
            this.rdbCurrent.UseVisualStyleBackColor = true;
            // 
            // rdbSavings
            // 
            this.rdbSavings.AutoSize = true;
            this.rdbSavings.Checked = true;
            this.rdbSavings.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbSavings.Location = new System.Drawing.Point(330, 110);
            this.rdbSavings.Name = "rdbSavings";
            this.rdbSavings.Size = new System.Drawing.Size(88, 22);
            this.rdbSavings.TabIndex = 4;
            this.rdbSavings.TabStop = true;
            this.rdbSavings.Text = "Savings";
            this.rdbSavings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Required Account Type.";
            // 
            // tbLogOut
            // 
            this.tbLogOut.BackColor = System.Drawing.Color.LightCoral;
            this.tbLogOut.Controls.Add(this.btnLogOut);
            this.tbLogOut.Location = new System.Drawing.Point(4, 24);
            this.tbLogOut.Name = "tbLogOut";
            this.tbLogOut.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogOut.Size = new System.Drawing.Size(888, 422);
            this.tbLogOut.TabIndex = 7;
            this.tbLogOut.Text = "LogOut";
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoEllipsis = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Moccasin;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(504, 120);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(181, 44);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Click to Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.tbDashBoard);
            this.Name = "DashBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DASHBOARD";
            this.tbDashBoard.ResumeLayout(false);
            this.tbDeposit.ResumeLayout(false);
            this.tbDeposit.PerformLayout();
            this.tbWithdraw.ResumeLayout(false);
            this.tbWithdraw.PerformLayout();
            this.tbTransfer.ResumeLayout(false);
            this.tbTransfer.PerformLayout();
            this.tbAccountStatement.ResumeLayout(false);
            this.tbAccountStatement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).EndInit();
            this.tbAccountDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountDetails)).EndInit();
            this.tbCheckBalance.ResumeLayout(false);
            this.tbCheckBalance.PerformLayout();
            this.tbSetUpAccount.ResumeLayout(false);
            this.tbSetUpAccount.PerformLayout();
            this.tbLogOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbDashBoard;
        private System.Windows.Forms.TabPage tbDeposit;
        private System.Windows.Forms.TabPage tbWithdraw;
        private System.Windows.Forms.TabPage tbTransfer;
        private System.Windows.Forms.TabPage tbAccountStatement;
        private System.Windows.Forms.TabPage tbAccountDetails;
        private System.Windows.Forms.TabPage tbCheckBalance;
        private System.Windows.Forms.TabPage tbSetUpAccount;
        private System.Windows.Forms.TabPage tbLogOut;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtDepositAmt;
        private System.Windows.Forms.TextBox txtDepositAccNum;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtWithdrawAmt;
        private System.Windows.Forms.TextBox txtWithdrawAccNum;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.TextBox txtReceiverAccNum;
        private System.Windows.Forms.TextBox txtSenderAccNum;
        private System.Windows.Forms.TextBox txtAccNumDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.RadioButton rdbCurrent;
        private System.Windows.Forms.RadioButton rdbSavings;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAccountCreationMessage;
        private System.Windows.Forms.RichTextBox rtbCheckBalance;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.RichTextBox rtbAccountDetails;
        private System.Windows.Forms.Button btnAccountDetails;
        private System.Windows.Forms.Button btnProceedStatement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbCheckBalanceMessage;
        private System.Windows.Forms.DataGridView dgAccountStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dgAccountDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}