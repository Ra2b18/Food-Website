//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation_table
    {
        public int id { get; set; }
        public int c_id { get; set; }
        public System.DateTime date_time { get; set; }
        public int no_of_seats_required { get; set; }
        public string ocassion { get; set; }
        public string table_number { get; set; }
    
        public virtual customer_master customer_master { get; set; }
    }
}
