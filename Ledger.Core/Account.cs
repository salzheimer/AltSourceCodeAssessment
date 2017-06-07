using System;
namespace Ledger.Core
{
    public class Account:BaseEntity    
    {
        public Account()
        {
            _id = Guid.NewGuid();
        }

        private Guid _id;
        public Guid Id { get { return _id; }  }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
