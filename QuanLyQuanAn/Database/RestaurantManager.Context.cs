﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyQuanAnEntities : DbContext
    {
        public QuanLyQuanAnEntities()
            : base("name=QuanLyQuanAnEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AttendanceList> AttendanceLists { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<BillInfoOfWareHouse> BillInfoOfWareHouses { get; set; }
        public virtual DbSet<BillOfWareHouse> BillOfWareHouses { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<TableFood> TableFoods { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
    
        public virtual int UpdateAccount(string userName, string displayName, string passWord, string newpass)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var displayNameParameter = displayName != null ?
                new ObjectParameter("displayName", displayName) :
                new ObjectParameter("displayName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("passWord", passWord) :
                new ObjectParameter("passWord", typeof(string));
    
            var newpassParameter = newpass != null ?
                new ObjectParameter("newpass", newpass) :
                new ObjectParameter("newpass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAccount", userNameParameter, displayNameParameter, passWordParameter, newpassParameter);
        }
    
        public virtual int UpdateFood(Nullable<int> idFood, string nameFood, Nullable<int> idFC, Nullable<double> price, string imageFood)
        {
            var idFoodParameter = idFood.HasValue ?
                new ObjectParameter("idFood", idFood) :
                new ObjectParameter("idFood", typeof(int));
    
            var nameFoodParameter = nameFood != null ?
                new ObjectParameter("nameFood", nameFood) :
                new ObjectParameter("nameFood", typeof(string));
    
            var idFCParameter = idFC.HasValue ?
                new ObjectParameter("idFC", idFC) :
                new ObjectParameter("idFC", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var imageFoodParameter = imageFood != null ?
                new ObjectParameter("imageFood", imageFood) :
                new ObjectParameter("imageFood", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateFood", idFoodParameter, nameFoodParameter, idFCParameter, priceParameter, imageFoodParameter);
        }
    
        public virtual int UpdateFoodCategory(Nullable<int> idFoodCategory, string nameFoodCategory)
        {
            var idFoodCategoryParameter = idFoodCategory.HasValue ?
                new ObjectParameter("idFoodCategory", idFoodCategory) :
                new ObjectParameter("idFoodCategory", typeof(int));
    
            var nameFoodCategoryParameter = nameFoodCategory != null ?
                new ObjectParameter("nameFoodCategory", nameFoodCategory) :
                new ObjectParameter("nameFoodCategory", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateFoodCategory", idFoodCategoryParameter, nameFoodCategoryParameter);
        }
    
        public virtual int UpdateTableFood(Nullable<int> idTable, string nameTable)
        {
            var idTableParameter = idTable.HasValue ?
                new ObjectParameter("idTable", idTable) :
                new ObjectParameter("idTable", typeof(int));
    
            var nameTableParameter = nameTable != null ?
                new ObjectParameter("nameTable", nameTable) :
                new ObjectParameter("nameTable", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTableFood", idTableParameter, nameTableParameter);
        }
    
        public virtual int USP_CheckOut(Nullable<int> discount, Nullable<double> totalPrice, string payerId, Nullable<int> id)
        {
            var discountParameter = discount.HasValue ?
                new ObjectParameter("discount", discount) :
                new ObjectParameter("discount", typeof(int));
    
            var totalPriceParameter = totalPrice.HasValue ?
                new ObjectParameter("totalPrice", totalPrice) :
                new ObjectParameter("totalPrice", typeof(double));
    
            var payerIdParameter = payerId != null ?
                new ObjectParameter("payerId", payerId) :
                new ObjectParameter("payerId", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_CheckOut", discountParameter, totalPriceParameter, payerIdParameter, idParameter);
        }
    
        public virtual ObjectResult<USP_GetAccountByName_Result> USP_GetAccountByName(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAccountByName_Result>("USP_GetAccountByName", userNameParameter);
        }
    
        public virtual ObjectResult<USP_GetListBillByDate_Result> USP_GetListBillByDate(Nullable<System.DateTime> checkIn, Nullable<System.DateTime> checkOut)
        {
            var checkInParameter = checkIn.HasValue ?
                new ObjectParameter("checkIn", checkIn) :
                new ObjectParameter("checkIn", typeof(System.DateTime));
    
            var checkOutParameter = checkOut.HasValue ?
                new ObjectParameter("checkOut", checkOut) :
                new ObjectParameter("checkOut", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetListBillByDate_Result>("USP_GetListBillByDate", checkInParameter, checkOutParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> USP_GetMaxBill()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("USP_GetMaxBill");
        }
    
        public virtual ObjectResult<USP_GetTableList_Result> USP_GetTableList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetTableList_Result>("USP_GetTableList");
        }
    
        public virtual ObjectResult<USP_GetTopFood_Result> USP_GetTopFood(Nullable<System.DateTime> checkIn, Nullable<System.DateTime> checkOut)
        {
            var checkInParameter = checkIn.HasValue ?
                new ObjectParameter("checkIn", checkIn) :
                new ObjectParameter("checkIn", typeof(System.DateTime));
    
            var checkOutParameter = checkOut.HasValue ?
                new ObjectParameter("checkOut", checkOut) :
                new ObjectParameter("checkOut", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetTopFood_Result>("USP_GetTopFood", checkInParameter, checkOutParameter);
        }
    
        public virtual int USP_InsertBill(Nullable<int> idTable)
        {
            var idTableParameter = idTable.HasValue ?
                new ObjectParameter("idTable", idTable) :
                new ObjectParameter("idTable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertBill", idTableParameter);
        }
    
        public virtual int USP_InsertBillInfo(Nullable<int> idBill, Nullable<int> idFood, Nullable<int> countFood)
        {
            var idBillParameter = idBill.HasValue ?
                new ObjectParameter("idBill", idBill) :
                new ObjectParameter("idBill", typeof(int));
    
            var idFoodParameter = idFood.HasValue ?
                new ObjectParameter("idFood", idFood) :
                new ObjectParameter("idFood", typeof(int));
    
            var countFoodParameter = countFood.HasValue ?
                new ObjectParameter("countFood", countFood) :
                new ObjectParameter("countFood", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertBillInfo", idBillParameter, idFoodParameter, countFoodParameter);
        }
    
        public virtual ObjectResult<USP_Login_Result> USP_Login(string userName, string passWord)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("passWord", passWord) :
                new ObjectParameter("passWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Login_Result>("USP_Login", userNameParameter, passWordParameter);
        }
    
        public virtual int USP_InsertUnit(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertUnit", nameParameter);
        }
    
        public virtual int USP_InsertBillOfWareHouse(string supplier, string note, string userName)
        {
            var supplierParameter = supplier != null ?
                new ObjectParameter("supplier", supplier) :
                new ObjectParameter("supplier", typeof(string));
    
            var noteParameter = note != null ?
                new ObjectParameter("note", note) :
                new ObjectParameter("note", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertBillOfWareHouse", supplierParameter, noteParameter, userNameParameter);
        }
    
        public virtual int USP_InsertBillInfoOfWareHouse(Nullable<int> idBillOfWareHouse, Nullable<int> idMaterial, Nullable<int> number, Nullable<int> price, Nullable<int> totalPrice)
        {
            var idBillOfWareHouseParameter = idBillOfWareHouse.HasValue ?
                new ObjectParameter("idBillOfWareHouse", idBillOfWareHouse) :
                new ObjectParameter("idBillOfWareHouse", typeof(int));
    
            var idMaterialParameter = idMaterial.HasValue ?
                new ObjectParameter("idMaterial", idMaterial) :
                new ObjectParameter("idMaterial", typeof(int));
    
            var numberParameter = number.HasValue ?
                new ObjectParameter("number", number) :
                new ObjectParameter("number", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            var totalPriceParameter = totalPrice.HasValue ?
                new ObjectParameter("totalPrice", totalPrice) :
                new ObjectParameter("totalPrice", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertBillInfoOfWareHouse", idBillOfWareHouseParameter, idMaterialParameter, numberParameter, priceParameter, totalPriceParameter);
        }
    
        public virtual int USP_DeleteMaterial(Nullable<int> idMaterial)
        {
            var idMaterialParameter = idMaterial.HasValue ?
                new ObjectParameter("idMaterial", idMaterial) :
                new ObjectParameter("idMaterial", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DeleteMaterial", idMaterialParameter);
        }
    
        public virtual int USP_InsertMaterial(string name, Nullable<int> idUnit)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var idUnitParameter = idUnit.HasValue ?
                new ObjectParameter("idUnit", idUnit) :
                new ObjectParameter("idUnit", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertMaterial", nameParameter, idUnitParameter);
        }
    
        public virtual ObjectResult<USP_CheckExitsAttendanceList_Result> USP_CheckExitsAttendanceList(string idStaff)
        {
            var idStaffParameter = idStaff != null ?
                new ObjectParameter("idStaff", idStaff) :
                new ObjectParameter("idStaff", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CheckExitsAttendanceList_Result>("USP_CheckExitsAttendanceList", idStaffParameter);
        }
    
        public virtual ObjectResult<USP_GetTotalAttendanceList_Result> USP_GetTotalAttendanceList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetTotalAttendanceList_Result>("USP_GetTotalAttendanceList");
        }
    
        public virtual int USP_InsertAttendanceList(string idStaff)
        {
            var idStaffParameter = idStaff != null ?
                new ObjectParameter("idStaff", idStaff) :
                new ObjectParameter("idStaff", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertAttendanceList", idStaffParameter);
        }
    
        public virtual ObjectResult<USP_GetTotalBillsInDay_Result> USP_GetTotalBillsInDay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetTotalBillsInDay_Result>("USP_GetTotalBillsInDay");
        }
    
        public virtual int USP_InsertAccount(string userName, string passWord, string displayName, Nullable<int> typeAccount, string idStaff)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("passWord", passWord) :
                new ObjectParameter("passWord", typeof(string));
    
            var displayNameParameter = displayName != null ?
                new ObjectParameter("displayName", displayName) :
                new ObjectParameter("displayName", typeof(string));
    
            var typeAccountParameter = typeAccount.HasValue ?
                new ObjectParameter("typeAccount", typeAccount) :
                new ObjectParameter("typeAccount", typeof(int));
    
            var idStaffParameter = idStaff != null ?
                new ObjectParameter("idStaff", idStaff) :
                new ObjectParameter("idStaff", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertAccount", userNameParameter, passWordParameter, displayNameParameter, typeAccountParameter, idStaffParameter);
        }
    
        public virtual int USP_InsertFood(string nameFood, Nullable<int> idFC, Nullable<double> price, string imageFood)
        {
            var nameFoodParameter = nameFood != null ?
                new ObjectParameter("nameFood", nameFood) :
                new ObjectParameter("nameFood", typeof(string));
    
            var idFCParameter = idFC.HasValue ?
                new ObjectParameter("idFC", idFC) :
                new ObjectParameter("idFC", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var imageFoodParameter = imageFood != null ?
                new ObjectParameter("imageFood", imageFood) :
                new ObjectParameter("imageFood", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertFood", nameFoodParameter, idFCParameter, priceParameter, imageFoodParameter);
        }
    
        public virtual int USP_InsertStaff(string idStaff, string nameStaff, string sex, Nullable<int> idPosition, Nullable<System.DateTime> dateOfBirth, string identityCard, string phoneNumber, string address)
        {
            var idStaffParameter = idStaff != null ?
                new ObjectParameter("idStaff", idStaff) :
                new ObjectParameter("idStaff", typeof(string));
    
            var nameStaffParameter = nameStaff != null ?
                new ObjectParameter("nameStaff", nameStaff) :
                new ObjectParameter("nameStaff", typeof(string));
    
            var sexParameter = sex != null ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(string));
    
            var idPositionParameter = idPosition.HasValue ?
                new ObjectParameter("idPosition", idPosition) :
                new ObjectParameter("idPosition", typeof(int));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("dateOfBirth", dateOfBirth) :
                new ObjectParameter("dateOfBirth", typeof(System.DateTime));
    
            var identityCardParameter = identityCard != null ?
                new ObjectParameter("identityCard", identityCard) :
                new ObjectParameter("identityCard", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("phoneNumber", phoneNumber) :
                new ObjectParameter("phoneNumber", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertStaff", idStaffParameter, nameStaffParameter, sexParameter, idPositionParameter, dateOfBirthParameter, identityCardParameter, phoneNumberParameter, addressParameter);
        }
    }
}