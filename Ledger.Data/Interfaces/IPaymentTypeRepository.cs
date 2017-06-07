using System.Collections.Generic;
using Ledger.Core;
using Microsoft.EntityFrameworkCore;

namespace Ledger.Data.Interfaces
{
    public interface IPaymentTypeRepository
    {
        int Create(PaymentType paymentType, DbContextOptionsBuilder<LedgerContext> context);
        PaymentType GetPaymentType(int id, DbContextOptionsBuilder<LedgerContext> context);
        List<PaymentType> GetPaymentTypes(DbContextOptionsBuilder<LedgerContext> context);
    }
}