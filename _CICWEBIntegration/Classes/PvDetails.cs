using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _CICWEBIntegration.Classes
{
    public class PvDetails
    {
        public string JournalType { get; set; }
        public string TranxTime { get; set; }
        public string TranxDatespecified { get; set; }
        public string LedgerAccount { get; set; }
        public string Dimensions { get; set; }
        public string Invoice { get; set; }
        public string Description { get; set; }
        public string AmountDebit { get; set; }
        public string AmtDebitspecified { get; set; }
        public string AmountCredit { get; set; }
        public string AmtCreditspecified { get; set; }
        public string OffsetAccount { get; set; }
        public string OffsetDimensions { get; set; }
        public string MethodofPayment { get; set; }
    }
}
