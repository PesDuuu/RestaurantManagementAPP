//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyQuanAn.Database
{
    using System;
    
    public partial class USP_GetTotalBillsInDay_Result
    {
        public int idBill { get; set; }
        public System.DateTime dateCheckIn { get; set; }
        public Nullable<System.DateTime> dateCheckOut { get; set; }
        public int idTable { get; set; }
        public int statusBill { get; set; }
        public Nullable<int> discount { get; set; }
        public Nullable<double> totalPrice { get; set; }
        public string payerId { get; set; }
    }
}
