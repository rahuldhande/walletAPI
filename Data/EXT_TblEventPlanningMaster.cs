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
    
    public partial class EXT_TblEventPlanningMaster
    {
        public long EventID { get; set; }
        public string EventTitle { get; set; }
        public string EventURL { get; set; }
        public string EventLocation { get; set; }
        public Nullable<System.DateTime> EventFromDate { get; set; }
        public Nullable<System.DateTime> EventToDate { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public string EventDuration { get; set; }
        public string EventDescription { get; set; }
        public byte[] EventPhoto { get; set; }
        public string EventPhotoName { get; set; }
        public Nullable<long> userID { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public Nullable<int> Flag { get; set; }
    }
}
