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
    
    public partial class Farmer_VisitReq
    {
        public int Rid { get; set; }
        public string gr_code { get; set; }
        public string MobileNo { get; set; }
        public string VisitRequest { get; set; }
        public string Remarks { get; set; }
        public string Prd_code { get; set; }
        public string Prd_desc { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<byte> Flag { get; set; }
        public string StaffRemarks { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
    }
}
