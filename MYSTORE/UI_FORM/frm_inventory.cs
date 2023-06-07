using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MYSTORE.M_EntityFramework;
using MYSTORE.UI_FORM;


namespace MYSTORE.UI_FORM
{
    public partial class frm_inventory : Form
    {
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        public frm_inventory()
        {
            InitializeComponent();
            MYSTORE.M_EntityFramework.Manege_StoreEntities4 dbContext = new MYSTORE.M_EntityFramework.Manege_StoreEntities4();
            dbContext.Products.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl3.DataSource = dbContext.Products.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            //////////////////////////////////////////////////////
            MYSTORE.M_EntityFramework.Manege_StoreEntities4 dbContext1 = new MYSTORE.M_EntityFramework.Manege_StoreEntities4();
            dbContext1.Customers.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext1.Customers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            ///////////////////////////////////////////////////////
            MYSTORE.M_EntityFramework.Manege_StoreEntities4 dbContext2 = new MYSTORE.M_EntityFramework.Manege_StoreEntities4(); 
            dbContext2.Suppolers.LoadAsync().ContinueWith(loadTask =>
            {
              gridControl2.DataSource = dbContext2.Suppolers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            /////////////////////////////////////////////////////////////////////

            var x1 = db.Products.Sum(x => (x.Net_Price * x.Quantity));
            var x2 = db.Products.Sum(x => (x.Sale_price * x.Quantity));
            var x3 = db.Customers.Sum(x => x.Account);
            var x4 = db.Suppolers.Sum(x => x.Account);
            var x5 = db.purchases.Sum(x => x.TotalPrice);
            var x6 = db.Sales.Sum(x => x.TotalPrice);
            txtcapt.Text = x1.ToString();
            txtgoods.Text = x2.ToString();
            txtproft.Text = (x5 - x6).ToString();
            txthave.Text = x3.ToString();
            txtowen.Text = x4.ToString();
            txttsale.Text = x5.ToString();
            txttpur.Text = x6.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
