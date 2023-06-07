﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MYSTORE.M_EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Manege_StoreEntities4 : DbContext
    {
        public Manege_StoreEntities4()
            : base("name=Manege_StoreEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Borrower> Borrowers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Debtor> Debtors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<purchase> purchases { get; set; }
        public virtual DbSet<purchases_Detile> purchases_Detile { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Sale_Detile> Sale_Detile { get; set; }
        public virtual DbSet<Suppoler> Suppolers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TB_Users> TB_Users { get; set; }
        public virtual DbSet<View_2> View_2 { get; set; }
    
        public virtual int ACBorrower(string name, Nullable<double> patch, Nullable<System.DateTime> datep)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var patchParameter = patch.HasValue ?
                new ObjectParameter("Patch", patch) :
                new ObjectParameter("Patch", typeof(double));
    
            var datepParameter = datep.HasValue ?
                new ObjectParameter("datep", datep) :
                new ObjectParameter("datep", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACBorrower", nameParameter, patchParameter, datepParameter);
        }
    
        public virtual int ACDebtor(string name, Nullable<double> patch, Nullable<System.DateTime> datep)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var patchParameter = patch.HasValue ?
                new ObjectParameter("Patch", patch) :
                new ObjectParameter("Patch", typeof(double));
    
            var datepParameter = datep.HasValue ?
                new ObjectParameter("datep", datep) :
                new ObjectParameter("datep", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACDebtor", nameParameter, patchParameter, datepParameter);
        }
    
        public virtual int addpurditle(Nullable<int> prodid, string prodname, Nullable<int> quantity, Nullable<double> nprice, Nullable<double> sprice, Nullable<double> sumion, Nullable<double> dis)
        {
            var prodidParameter = prodid.HasValue ?
                new ObjectParameter("prodid", prodid) :
                new ObjectParameter("prodid", typeof(int));
    
            var prodnameParameter = prodname != null ?
                new ObjectParameter("Prodname", prodname) :
                new ObjectParameter("Prodname", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var npriceParameter = nprice.HasValue ?
                new ObjectParameter("nprice", nprice) :
                new ObjectParameter("nprice", typeof(double));
    
            var spriceParameter = sprice.HasValue ?
                new ObjectParameter("sprice", sprice) :
                new ObjectParameter("sprice", typeof(double));
    
            var sumionParameter = sumion.HasValue ?
                new ObjectParameter("sumion", sumion) :
                new ObjectParameter("sumion", typeof(double));
    
            var disParameter = dis.HasValue ?
                new ObjectParameter("dis", dis) :
                new ObjectParameter("dis", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addpurditle", prodidParameter, prodnameParameter, quantityParameter, npriceParameter, spriceParameter, sumionParameter, disParameter);
        }
    
        public virtual int addpurinv(string suppname, Nullable<System.DateTime> datainv, Nullable<double> totalprice)
        {
            var suppnameParameter = suppname != null ?
                new ObjectParameter("suppname", suppname) :
                new ObjectParameter("suppname", typeof(string));
    
            var datainvParameter = datainv.HasValue ?
                new ObjectParameter("datainv", datainv) :
                new ObjectParameter("datainv", typeof(System.DateTime));
    
            var totalpriceParameter = totalprice.HasValue ?
                new ObjectParameter("totalprice", totalprice) :
                new ObjectParameter("totalprice", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addpurinv", suppnameParameter, datainvParameter, totalpriceParameter);
        }
    
        public virtual int addsaleditle(Nullable<int> prodid, string prodName, Nullable<int> quantity, Nullable<double> price, Nullable<double> sumion, Nullable<double> dis)
        {
            var prodidParameter = prodid.HasValue ?
                new ObjectParameter("prodid", prodid) :
                new ObjectParameter("prodid", typeof(int));
    
            var prodNameParameter = prodName != null ?
                new ObjectParameter("ProdName", prodName) :
                new ObjectParameter("ProdName", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var sumionParameter = sumion.HasValue ?
                new ObjectParameter("sumion", sumion) :
                new ObjectParameter("sumion", typeof(double));
    
            var disParameter = dis.HasValue ?
                new ObjectParameter("dis", dis) :
                new ObjectParameter("dis", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addsaleditle", prodidParameter, prodNameParameter, quantityParameter, priceParameter, sumionParameter, disParameter);
        }
    
        public virtual int addsaleinv(string custname, Nullable<System.DateTime> datainv, Nullable<double> totalprice)
        {
            var custnameParameter = custname != null ?
                new ObjectParameter("custname", custname) :
                new ObjectParameter("custname", typeof(string));
    
            var datainvParameter = datainv.HasValue ?
                new ObjectParameter("datainv", datainv) :
                new ObjectParameter("datainv", typeof(System.DateTime));
    
            var totalpriceParameter = totalprice.HasValue ?
                new ObjectParameter("totalprice", totalprice) :
                new ObjectParameter("totalprice", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addsaleinv", custnameParameter, datainvParameter, totalpriceParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> detlastsaleid()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("detlastsaleid");
        }
    
        public virtual int modifaycustAcoount(string name, Nullable<double> total)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("modifaycustAcoount", nameParameter, totalParameter);
        }
    
        public virtual int safeadd(string name, string category, Nullable<double> quantity, Nullable<float> netprice, Nullable<float> saleprice, Nullable<System.DateTime> datep, byte[] image)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(double));
    
            var netpriceParameter = netprice.HasValue ?
                new ObjectParameter("netprice", netprice) :
                new ObjectParameter("netprice", typeof(float));
    
            var salepriceParameter = saleprice.HasValue ?
                new ObjectParameter("saleprice", saleprice) :
                new ObjectParameter("saleprice", typeof(float));
    
            var datepParameter = datep.HasValue ?
                new ObjectParameter("datep", datep) :
                new ObjectParameter("datep", typeof(System.DateTime));
    
            var imageParameter = image != null ?
                new ObjectParameter("image", image) :
                new ObjectParameter("image", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("safeadd", nameParameter, categoryParameter, quantityParameter, netpriceParameter, salepriceParameter, datepParameter, imageParameter);
        }
    
        public virtual int safesale(string name, string category, Nullable<int> quantity, Nullable<int> sqty)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var sqtyParameter = sqty.HasValue ?
                new ObjectParameter("sqty", sqty) :
                new ObjectParameter("sqty", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("safesale", nameParameter, categoryParameter, quantityParameter, sqtyParameter);
        }
    
        public virtual int ShowPurchase_detile()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ShowPurchase_detile");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int testsafesale(string name, string category, Nullable<int> quantity, Nullable<int> sqty, ObjectParameter rrqty)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var sqtyParameter = sqty.HasValue ?
                new ObjectParameter("sqty", sqty) :
                new ObjectParameter("sqty", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("testsafesale", nameParameter, categoryParameter, quantityParameter, sqtyParameter, rrqty);
        }
    
        public virtual int updatecountprod(string name, string category, Nullable<double> quantity, Nullable<double> netprice, Nullable<double> saleprice, Nullable<System.DateTime> datep)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(double));
    
            var netpriceParameter = netprice.HasValue ?
                new ObjectParameter("netprice", netprice) :
                new ObjectParameter("netprice", typeof(double));
    
            var salepriceParameter = saleprice.HasValue ?
                new ObjectParameter("saleprice", saleprice) :
                new ObjectParameter("saleprice", typeof(double));
    
            var datepParameter = datep.HasValue ?
                new ObjectParameter("datep", datep) :
                new ObjectParameter("datep", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatecountprod", nameParameter, categoryParameter, quantityParameter, netpriceParameter, salepriceParameter, datepParameter);
        }
    
        public virtual int updatecustAccount(string name, Nullable<double> total)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatecustAccount", nameParameter, totalParameter);
        }
    
        public virtual int updatesuppAccount(string name, Nullable<double> total)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatesuppAccount", nameParameter, totalParameter);
        }
    }
}
