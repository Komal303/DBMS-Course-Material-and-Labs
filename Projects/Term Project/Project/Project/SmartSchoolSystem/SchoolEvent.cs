//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartSchoolSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class SchoolEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string EventDescription { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Contact { get; set; }
        public string Charges { get; set; }
    }
}