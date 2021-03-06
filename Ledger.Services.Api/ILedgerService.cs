﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ledger.Services.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILedgerService" in both code and config file together.
    [ServiceContract]
    public interface ILedgerService
    {
        [OperationContract]
        void UseTestDatabase(bool isInMemoryDb);
    }
}
