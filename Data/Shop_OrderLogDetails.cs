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
    
    public partial class Shop_OrderLogDetails
    {
        public int tr_id { get; set; }
        public string retailer_id { get; set; }
        public string retailer_mobile { get; set; }
        public string paymentMode { get; set; }
        public string total_price { get; set; }
        public string Qty { get; set; }
        public string csv_file { get; set; }
        public Nullable<System.DateTime> tr_date { get; set; }
    }
}
