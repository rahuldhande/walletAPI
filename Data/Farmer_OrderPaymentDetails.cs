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
    
    public partial class Farmer_OrderPaymentDetails
    {
        public int TrId { get; set; }
        public int OrderNo { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> AdvAmount { get; set; }
        public string AmountType { get; set; }
        public Nullable<decimal> AdvAmtReceived { get; set; }
        public Nullable<decimal> BalAmtReceived { get; set; }
        public Nullable<System.DateTime> AdvRecDate { get; set; }
        public Nullable<System.DateTime> BalRecDate { get; set; }
        public string ModeOfPayemnt { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> BalancePending { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
    }
}
