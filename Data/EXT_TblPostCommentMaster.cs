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
    
    public partial class EXT_TblPostCommentMaster
    {
        public long PcmID { get; set; }
        public Nullable<long> postID { get; set; }
        public Nullable<long> userID { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public Nullable<int> Flag { get; set; }
    
        public virtual EXT_TblPostMaster EXT_TblPostMaster { get; set; }
    }
}
