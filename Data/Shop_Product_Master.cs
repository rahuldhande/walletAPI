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
    
    public partial class Shop_Product_Master
    {
        public int pkSkuId { get; set; }
        public string SkuName { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string CurrentQuantity { get; set; }
        public Nullable<System.DateTime> SkuCreatedDate { get; set; }
        public string GSTPercent { get; set; }
        public string imageUrl { get; set; }
        public string min_qty_to_book { get; set; }
        public string max_qty_to_book { get; set; }
        public string Prd_company_name { get; set; }
        public Nullable<int> Allow_SAP_Order { get; set; }
        public string prd_State { get; set; }
        public string Status { get; set; }
        public Nullable<int> ProductPriority { get; set; }
        public string isApprove { get; set; }
        public string crp_catagory { get; set; }
        public string crp_type { get; set; }
        public string packingSize { get; set; }
        public string TC { get; set; }
        public Nullable<int> cmp_priority { get; set; }
        public Nullable<int> crp_priority { get; set; }
    }
}
