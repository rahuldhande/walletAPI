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
    
    public partial class Shop_Retailer_UserMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Retailer_UserMaster()
        {
            this.User_Wallet = new HashSet<User_Wallet>();
        }
    
        public string user_code { get; set; }
        public string User_pwd { get; set; }
        public string retailer_name { get; set; }
        public string mobile_number { get; set; }
        public string email_id { get; set; }
        public string address { get; set; }
        public string geo_address { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public string taluka { get; set; }
        public string cstn_number { get; set; }
        public string vat_number { get; set; }
        public string pan_number { get; set; }
        public string license_no { get; set; }
        public string imei_number { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string pincode { get; set; }
        public string seed_license_validity { get; set; }
        public string gst_number { get; set; }
        public string firm_name { get; set; }
        public string depo { get; set; }
        public Nullable<byte> Flag { get; set; }
        public string town { get; set; }
        public string sap_retailer_id { get; set; }
        public string fcm_token { get; set; }
        public string fcm_subscription_topic { get; set; }
        public string bank_account_number { get; set; }
        public string birth_date { get; set; }
        public string retailer_last_name { get; set; }
        public string houseNo { get; set; }
        public string streetLine1 { get; set; }
        public string streetLine2 { get; set; }
        public Nullable<int> profileUpdate { get; set; }
        public string user_company { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Wallet> User_Wallet { get; set; }
    }
}
