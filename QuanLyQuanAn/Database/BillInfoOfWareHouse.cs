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
    using System.Collections.Generic;
    
    public partial class BillInfoOfWareHouse
    {
        public int idBillInfoOfWareHouse { get; set; }
        public Nullable<int> idBillOfWareHouse { get; set;}
        public Nullable<int> idMaterial { get; set; }
        public Nullable<int> number { get; set; }
        public int price { get; set; }
        public int totalPrice { get; set; }
    
        public virtual BillOfWareHouse BillOfWareHouse { get; set; }
        public virtual Material Material { get; set; }
    }
}