//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WalletAPI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class EXT_TblTransactionStatusMaster
    {
        public long tsID { get; set; }
        public Nullable<long> userID { get; set; }
        public Nullable<long> orderID { get; set; }
        public string rzp_order_id { get; set; }
        public string rzp_payment_id { get; set; }
        public string rzp_signature { get; set; }
        public Nullable<int> NumOfInstallment { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public Nullable<int> Flag { get; set; }
    }
}
