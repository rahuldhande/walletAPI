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
    
    public partial class EXT_TblProductCropMaster
    {
        public long productID { get; set; }
        public string cropName { get; set; }
        public string productName { get; set; }
        public Nullable<decimal> pricePerQty { get; set; }
        public string productImage { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<int> flag { get; set; }
    }
}
