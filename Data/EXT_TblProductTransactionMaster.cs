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
    
    public partial class EXT_TblProductTransactionMaster
    {
        public long TrId { get; set; }
        public Nullable<long> userID { get; set; }
        public string userMobileNo { get; set; }
        public string userAddress { get; set; }
        public string userName { get; set; }
        public string productVariety { get; set; }
        public string selectedYear { get; set; }
        public string selectedMonth { get; set; }
        public string selectedWeek { get; set; }
        public Nullable<int> productQuantity { get; set; }
        public string remarks { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<long> productID { get; set; }
        public string productName { get; set; }
        public string cropName { get; set; }
        public string payentStatus { get; set; }
        public string transStatus { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public string rzp_order_id { get; set; }
        public Nullable<decimal> firstInstallment { get; set; }
        public Nullable<System.DateTime> firstInstallmentDate { get; set; }
        public Nullable<decimal> secondInstallment { get; set; }
        public Nullable<System.DateTime> secondInstallmentDate { get; set; }
        public Nullable<decimal> thirdInstallment { get; set; }
        public Nullable<System.DateTime> thirdInstallmentDate { get; set; }
        public Nullable<decimal> totalInstallment { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    }
}
