using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using Ledger.Core;
using Ledger.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Repositories
{
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        public int Create(PaymentType paymentType, DbContextOptionsBuilder<LedgerContext> context)
        {
            try
            {
                using (var ctx = new LedgerContext(context.Options))
                {
                    ctx.PaymentTypes.Add(paymentType);
                    return ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PaymentType> GetPaymentTypes(DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                return ctx.PaymentTypes.ToList();
            }
        }

        public PaymentType GetPaymentType(int id, DbContextOptionsBuilder<LedgerContext> context)
        {
            using (var ctx = new LedgerContext(context.Options))
            {
                var pt = ctx.PaymentTypes.FirstOrDefault(p => p.Id == id);

                if (pt == null)
                    throw new Exception("Cannot find a payment type with this parameter");
                return pt;
                ;
            }
        }
    }
}