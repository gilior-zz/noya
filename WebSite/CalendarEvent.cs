//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite
{
    using System;
    using System.Collections.Generic;
    
    public partial class CalendarEvent
    {
        public int ID { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool Visible { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public long CalendaryOrder { get; set; }
        public string Text_Heb { get; set; }
        public string Text_Eng { get; set; }
    }
}
