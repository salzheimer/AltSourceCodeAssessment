using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LedgerService;
namespace Ledger.UI.WinForm
{
    public partial class Ledger : Form
    {
        private static Guid _acctId;
        public Ledger()
        {
            InitializeComponent();
        }
        private void Ledger_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var acctService = new AccountServiceClient();
            var acct = new Account();
            acct.FirstName = txtFirstName.Text;
            acct.LastName = txtLastName.Text;
            acct.UserName = txtUserName.Text;
            acct.Password = txtPassword.Text;

            lblCreateAccMessage.Text = acctService.CreateAccount(acct);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Guid acctId;
            var service = new AccountServiceClient();
            var result = service.LogIn(txtLogInUserName.Text, txtLogInPassword.Text);

            if (Guid.TryParse(result, out acctId))
            {
                _acctId = acctId;
                GetTransactionHistory();
            }
            else
            {
                lblLoginMessage.Text = result;
            }
        }

        private void GetTransactionHistory()
        {
            decimal balance=0.00M;
            var transService = new TransactionServiceClient();
            var history = transService.GetTransactions(_acctId);
            dgvTransactionHistory.AutoGenerateColumns = false;
            dgvTransactionHistory.DataSource = history;
            for (int i = 0; i < history.Length; i++)
            {
                dgvTransactionHistory["TransactionDate", i].Value = history[i].TransactionDate.ToShortDateString();
                dgvTransactionHistory["PaymentType", i].Value = history[i].PaymentTypeName;
                dgvTransactionHistory["Category", i].Value = history[i].CategoryName;
                dgvTransactionHistory["Description", i].Value = history[i].Description;
                if (history[i].IsDeposit)
                {
                    dgvTransactionHistory["Deposit", i].Value = history[i].Amount;
                    balance += history[i].Amount;
                }
                else
                {
                    dgvTransactionHistory["Withdrawal", i].Value = history[i].Amount;
                    balance -= history[i].Amount;
                }
                
                dgvTransactionHistory["Balance", i].Value = balance;
            }
        }

        private void PopulateComboboxes()
        {
            var catService = new CategoryServiceClient();
            cbCategory.DataSource = catService.GetCategories();
            cbCategory.DisplayMember = "CategoryName";
            
            cbCategory.ValueMember = "Id";

            var ptService = new PaymentTypeServiceClient();
            cbPaymentType.DataSource = ptService.GetPaymentTypes();
            cbPaymentType.DisplayMember = "Name";
            cbPaymentType.ValueMember = "id";
        }

        private void CreateTransaction(bool isDesposit)
        {
            try
            {
                Guid transId;
                string result;
                var transService = new TransactionServiceClient();
                var trans = new TransactionModel();

                
                trans.AccountId = _acctId;
                trans.Amount = decimal.Parse(txtAmount.Text);
                trans.CategoryId = (int)cbCategory.SelectedValue;
                trans.CategoryName = cbCategory.Text;
                trans.DateCreated = DateTime.Now;
                trans.Description = txtAmount.Text;
                trans.IsDeposit = isDesposit;
                trans.PaymentTypeId = (int)cbPaymentType.SelectedValue;
                trans.PaymentTypeName = cbPaymentType.Text;
                trans.TransactionDate = dtTransactionDate.Value;

                if (isDesposit)
                {
                    result = transService.MakeDeposit(trans);
                }
                else
                {
                    result = transService.MakeWithdrawal(trans);
                }
                //verify trans id is returned if not there is an error
                if (Guid.TryParse(result, out transId) == false)
                {
                    lblTransactionMessage.Text = result;
                }
                else
                {
                    GetTransactionHistory();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDesposit_Click(object sender, EventArgs e)
        {
            CreateTransaction(true);
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            CreateTransaction(false);
        }
    }
}
