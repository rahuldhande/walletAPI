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
    
    public partial class EXT_TblAnswerCommentMaster
    {
        public long AcmID { get; set; }
        public Nullable<long> userID { get; set; }
        public Nullable<long> answerID { get; set; }
        public string answerComment { get; set; }
        public Nullable<System.DateTime> ACDate { get; set; }
        public Nullable<int> Flag { get; set; }
    }
}
