using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ledger.UI.Web.LedgerService;

namespace Ledger.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private LedgerServiceClient _client = null;
        private static Guid AccountId;
        public ActionResult Index()
        {
            ConnectToService();
            if (ViewBag.Categories == null)
            {
                ViewBag.Categories = GetCategories();
            }
            if (ViewBag.PaymentTypes == null)
            {
                ViewBag.PaymentTypes = GetPaymentTypes();
            }
            return View();
        }

        public void ConnectToService()
        {
            _client = new LedgerServiceClient();
            _client.UseTestDatabase(true);

        }

        #region page setup
        public Category[] GetCategories()
        {
            var cat = new LedgerService.CategoryServiceClient();
            return cat.GetCategories();

        }
        public PaymentType[] GetPaymentTypes()
        {
            var pt = new PaymentTypeServiceClient();
            return pt.GetPaymentTypes();
        }


        #endregion

        #region account creation
        [HttpPost]
        public ActionResult CreateAccount(Models.AccountViewModel acct)
        {
            var acctService = new AccountServiceClient();

            var profile = new Account();
            profile.FirstName = acct.FirstName;
            profile.LastName = acct.LastName;
            profile.UserName = acct.UserName;
            profile.Password = acct.Password;

            var message = acctService.CreateAccount(profile);
            return Json(message, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            var accService = new AccountServiceClient();
             var result= accService.LogIn(userName, password);
            Guid acctNum;
            bool isScccessful=false;
            if (Guid.TryParse(result,out acctNum)!= false) {
                isScccessful = true;
                AccountId = acctNum;
            }

            
            
            return Json(new {success= isScccessful,message=result }, JsonRequestBehavior.AllowGet);
        }
        #endregion
        [HttpPost]
        public ActionResult CreateTransaction(Models.TransactionViewModel trans)
        {
            string serviceMessage;
            bool isSuccessful=false;
            Guid transId;
            var service = new TransactionServiceClient();

            var transaction = new TransactionModel();

            transaction.AccountId = AccountId;
            transaction.Amount = trans.Amount;
            transaction.CategoryId = trans.CategoryId;
            transaction.CategoryName = trans.CategoryName;
            transaction.Description = trans.Description;
            transaction.IsDeposit = trans.IsDeposit;
            transaction.PaymentTypeId = trans.PaymentTypeId;
            transaction.PaymentTypeName = trans.PaymentTypeName;
            transaction.TransactionDate = trans.TransactionDate;
            transaction.CreatedBy = trans.CreatedBy;
            transaction.DateCreated = DateTime.Now.ToUniversalTime();

            if (trans.IsDeposit) {
                serviceMessage = service.MakeDeposit(transaction);
            }
            else
            {
                serviceMessage = service.MakeWithdrawal(transaction);
            }
            if (Guid.TryParse(serviceMessage, out transId)) { isSuccessful = true; }
            return Json(new {success=isSuccessful, message = serviceMessage }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetTransactions()
        {

            var service = new TransactionServiceClient();
            var transactions = service.GetTransactions(AccountId);
            var transactionsView = new List<Models.TransactionViewModel>();
            foreach(var trans in transactions)
            {
                var tView = new Models.TransactionViewModel();
                tView.AccoutId = trans.AccountId;
                tView.Amount = trans.Amount;
                tView.CategoryId = trans.CategoryId;
                tView.CategoryName = trans.CategoryName;
                tView.Description = trans.Description;
                tView.IsDeposit = trans.IsDeposit;
                tView.PaymentTypeId = trans.PaymentTypeId;
                tView.PaymentTypeName = trans.PaymentTypeName;
                tView.DisplayTransactionDate = trans.TransactionDate.ToLocalTime().ToShortDateString();

                transactionsView.Add(tView);
            }
            return Json(transactionsView, JsonRequestBehavior.AllowGet);

        }
    }
}