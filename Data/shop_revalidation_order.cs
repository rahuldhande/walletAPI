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
    
    public partial class shop_revalidation_order
    {
        public int revalidation_order_id { get; set; }
        public string prd_name { get; set; }
        public string item_code { get; set; }
        public string re_price { get; set; }
        public string Total_price { get; set; }
        public string retailer_id { get; set; }
        public string retailer_mobile { get; set; }
        public Nullable<System.DateTime> tr_date { get; set; }
        public string isApprove { get; set; }
        public string qty { get; set; }
        public string remark { get; set; }
    }
}