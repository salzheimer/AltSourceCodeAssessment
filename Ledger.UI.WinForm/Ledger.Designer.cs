using System;

namespace Ledger.UI.WinForm
{
    partial class Ledger
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
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCreateAccMessage = new System.Windows.Forms.Label();
            this.lblLogInUserName = new System.Windows.Forms.Label();
            this.lblLogInPassword = new System.Windows.Forms.Label();
            this.plLogIn = new System.Windows.Forms.Panel();
            this.lblLoginMessage = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.txtLogInUserName = new System.Windows.Forms.TextBox();
            this.pnCreateAccount = new System.Windows.Forms.Panel();
            this.dgvTransactionHistory = new System.Windows.Forms.DataGridView();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Withdrawal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.lblTransactionMessage = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.dtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.btnDesposit = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.plLogIn.SuspendLayout();
            this.pnCreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).BeginInit();
            this.pnlTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(440, 21);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(106, 23);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(1, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(0, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(209, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(209, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(77, 18);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(77, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(288, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(288, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblCreateAccMessage
            // 
            this.lblCreateAccMessage.AutoSize = true;
            this.lblCreateAccMessage.Location = new System.Drawing.Point(74, 101);
            this.lblCreateAccMessage.Name = "lblCreateAccMessage";
            this.lblCreateAccMessage.Size = new System.Drawing.Size(0, 13);
            this.lblCreateAccMessage.TabIndex = 9;
            // 
            // lblLogInUserName
            // 
            this.lblLogInUserName.AutoSize = true;
            this.lblLogInUserName.Location = new System.Drawing.Point(3, 17);
            this.lblLogInUserName.Name = "lblLogInUserName";
            this.lblLogInUserName.Size = new System.Drawing.Size(60, 13);
            this.lblLogInUserName.TabIndex = 10;
            this.lblLogInUserName.Text = "User Name";
            // 
            // lblLogInPassword
            // 
            this.lblLogInPassword.AutoSize = true;
            this.lblLogInPassword.Location = new System.Drawing.Point(3, 39);
            this.lblLogInPassword.Name = "lblLogInPassword";
            this.lblLogInPassword.Size = new System.Drawing.Size(53, 13);
            this.lblLogInPassword.TabIndex = 11;
            this.lblLogInPassword.Text = "Password";
            // 
            // plLogIn
            // 
            this.plLogIn.Controls.Add(this.lblLoginMessage);
            this.plLogIn.Controls.Add(this.btnLogIn);
            this.plLogIn.Controls.Add(this.txtLogInPassword);
            this.plLogIn.Controls.Add(this.txtLogInUserName);
            this.plLogIn.Controls.Add(this.lblLogInUserName);
            this.plLogIn.Controls.Add(this.lblLogInPassword);
            this.plLogIn.Location = new System.Drawing.Point(16, 184);
            this.plLogIn.Name = "plLogIn";
            this.plLogIn.Size = new System.Drawing.Size(364, 100);
            this.plLogIn.TabIndex = 1;
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.AutoSize = true;
            this.lblLoginMessage.Location = new System.Drawing.Point(19, 76);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(0, 13);
            this.lblLoginMessage.TabIndex = 14;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(231, 17);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Location = new System.Drawing.Point(69, 36);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.Size = new System.Drawing.Size(100, 20);
            this.txtLogInPassword.TabIndex = 2;
            // 
            // txtLogInUserName
            // 
            this.txtLogInUserName.Location = new System.Drawing.Point(69, 10);
            this.txtLogInUserName.Name = "txtLogInUserName";
            this.txtLogInUserName.Size = new System.Drawing.Size(100, 20);
            this.txtLogInUserName.TabIndex = 0;
            // 
            // pnCreateAccount
            // 
            this.pnCreateAccount.Controls.Add(this.txtPassword);
            this.pnCreateAccount.Controls.Add(this.btnCreateAccount);
            this.pnCreateAccount.Controls.Add(this.lblCreateAccMessage);
            this.pnCreateAccount.Controls.Add(this.lblFirstName);
            this.pnCreateAccount.Controls.Add(this.lblLastName);
            this.pnCreateAccount.Controls.Add(this.txtUserName);
            this.pnCreateAccount.Controls.Add(this.lblUserName);
            this.pnCreateAccount.Controls.Add(this.txtLastName);
            this.pnCreateAccount.Controls.Add(this.lblPassword);
            this.pnCreateAccount.Controls.Add(this.txtFirstName);
            this.pnCreateAccount.Location = new System.Drawing.Point(12, 10);
            this.pnCreateAccount.Name = "pnCreateAccount";
            this.pnCreateAccount.Size = new System.Drawing.Size(568, 143);
            this.pnCreateAccount.TabIndex = 0;
            // 
            // dgvTransactionHistory
            // 
            this.dgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionDate,
            this.PaymentType,
            this.Category,
            this.Description,
            this.Deposit,
            this.Withdrawal,
            this.Balance});
            this.dgvTransactionHistory.Location = new System.Drawing.Point(20, 345);
            this.dgvTransactionHistory.Name = "dgvTransactionHistory";
            this.dgvTransactionHistory.Size = new System.Drawing.Size(725, 150);
            this.dgvTransactionHistory.TabIndex = 14;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "Transaction Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            // 
            // PaymentType
            // 
            this.PaymentType.HeaderText = "Payment Type";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Deposit
            // 
            this.Deposit.HeaderText = "Desposit";
            this.Deposit.Name = "Deposit";
            this.Deposit.ReadOnly = true;
            // 
            // Withdrawal
            // 
            this.Withdrawal.HeaderText = "Withdrawal";
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.Controls.Add(this.lblTransactionMessage);
            this.pnlTransaction.Controls.Add(this.lblAmount);
            this.pnlTransaction.Controls.Add(this.lblCategory);
            this.pnlTransaction.Controls.Add(this.lblPaymentType);
            this.pnlTransaction.Controls.Add(this.lblDescription);
            this.pnlTransaction.Controls.Add(this.lblTransactionDate);
            this.pnlTransaction.Controls.Add(this.txtAmount);
            this.pnlTransaction.Controls.Add(this.txtDescription);
            this.pnlTransaction.Controls.Add(this.cbCategory);
            this.pnlTransaction.Controls.Add(this.cbPaymentType);
            this.pnlTransaction.Controls.Add(this.dtTransactionDate);
            this.pnlTransaction.Controls.Add(this.btnDesposit);
            this.pnlTransaction.Controls.Add(this.btnWithdrawal);
            this.pnlTransaction.Location = new System.Drawing.Point(22, 650);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(550, 200);
            this.pnlTransaction.TabIndex = 2;
            // 
            // lblTransactionMessage
            // 
            this.lblTransactionMessage.AutoSize = true;
            this.lblTransactionMessage.Location = new System.Drawing.Point(23, 134);
            this.lblTransactionMessage.Name = "lblTransactionMessage";
            this.lblTransactionMessage.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionMessage.TabIndex = 12;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(20, 50);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 20);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(320, 20);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 20);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Location = new System.Drawing.Point(320, 50);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(70, 20);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(20, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(20, 80);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(70, 40);
            this.lblTransactionDate.TabIndex = 4;
            this.lblTransactionDate.Text = "Transaction Date";
            this.lblTransactionDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(90, 50);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(70, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(90, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategory.DropDownWidth = 150;
            this.cbCategory.Location = new System.Drawing.Point(390, 20);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPaymentType.Location = new System.Drawing.Point(390, 50);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentType.TabIndex = 4;
            // 
            // dtTransactionDate
            // 
            this.dtTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransactionDate.Location = new System.Drawing.Point(90, 80);
            this.dtTransactionDate.Name = "dtTransactionDate";
            this.dtTransactionDate.Size = new System.Drawing.Size(80, 20);
            this.dtTransactionDate.TabIndex = 2;
            // 
            // btnDesposit
            // 
            this.btnDesposit.Location = new System.Drawing.Point(370, 80);
            this.btnDesposit.Name = "btnDesposit";
            this.btnDesposit.Size = new System.Drawing.Size(75, 23);
            this.btnDesposit.TabIndex = 5;
            this.btnDesposit.Text = "Desposit";
            this.btnDesposit.Click += new System.EventHandler(this.btnDesposit_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(450, 80);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawal.TabIndex = 7;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.pnlTransaction);
            this.Controls.Add(this.dgvTransactionHistory);
            this.Controls.Add(this.pnCreateAccount);
            this.Controls.Add(this.plLogIn);
            this.Name = "Ledger";
            this.Text = "World\'s Greatest Bank Ledger";
            this.Load += new System.EventHandler(this.Ledger_Load);
            this.plLogIn.ResumeLayout(false);
            this.plLogIn.PerformLayout();
            this.pnCreateAccount.ResumeLayout(false);
            this.pnCreateAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).EndInit();
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            this.ResumeLayout(false);

        }

    


        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCreateAccMessage;
        private System.Windows.Forms.Label lblLogInUserName;
        private System.Windows.Forms.Label lblLogInPassword;
        private System.Windows.Forms.Panel plLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.TextBox txtLogInUserName;
        private System.Windows.Forms.Panel pnCreateAccount;
        private System.Windows.Forms.Label lblLoginMessage;
        private System.Windows.Forms.DataGridView dgvTransactionHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Withdrawal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtTransactionDate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Button btnDesposit;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label lblTransactionMessage;
    }
}