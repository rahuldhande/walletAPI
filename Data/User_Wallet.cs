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
    
    public partial class User_Wallet
    {
        public long Id { get; set; }
        public string UserBalance { get; set; }
        public string user_code { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Shop_Retailer_UserMaster Shop_Retailer_UserMaster { get; set; }
    }
}
