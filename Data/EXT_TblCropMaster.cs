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
    
    public partial class EXT_TblCropMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXT_TblCropMaster()
        {
            this.EXT_TblCropCategoryMaster = new HashSet<EXT_TblCropCategoryMaster>();
        }
    
        public long cropID { get; set; }
        public string cropName { get; set; }
        public string cropImageName { get; set; }
        public Nullable<long> createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<int> isCategory { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXT_TblCropCategoryMaster> EXT_TblCropCategoryMaster { get; set; }
        public virtual EXT_TblCropMaster EXT_TblCropMaster1 { get; set; }
        public virtual EXT_TblCropMaster EXT_TblCropMaster2 { get; set; }
    }
}
