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
    
    public partial class EXT_TblUserMaster
    {
        public long TrId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string mobileNo { get; set; }
        public string password { get; set; }
        public Nullable<int> Flag { get; set; }
        public string IMEI { get; set; }
        public string OTP { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
    }
}
