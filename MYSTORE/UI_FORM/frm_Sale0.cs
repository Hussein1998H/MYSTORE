using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYSTORE.M_EntityFramework;
using MYSTORE.UI_FORM;
using System.Data.Entity;

namespace MYSTORE.UI_FORM
{

    public partial class frm_Sale0 : Form
    {
        #region init 

        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        Customer cust = new Customer();
        public frm_Sale0()
        {
            InitializeComponent();

            var rs2 = db.Customers.Select(x => x.Name).ToList();
            cmbcust.DataSource = rs2;
            AutoCompleteStringCollection acsc2 = new AutoCompleteStringCollection();
            acsc2.AddRange(rs2.ToArray());
            cmbcust.AutoCompleteCustomSource = acsc2;

        }
        #endregion

        #region go to detaile 
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (db.Customers.Any(x => x.Name == cmbcust.Text))
            {
                frm_Sale frm_sale = new frm_Sale();
                frm_sale.txtcust1.Text = cmbcust.Text;
                pnl_invoice.Controls.Clear();
                pnl_invoice.Controls.Add(frm_sale.pnl_sale);
                frm_sale.cmbprod.Focus();
                frm_sale.cmbprod.Select();
            }
            else
            {
                MessageBox.Show(" !! هذا الزبون غير موجود الرجاء إضافته", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        #endregion

        #region comboBox 
        private void cmbcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = db.Customers.Where(x => x.Name == cmbcust.Text).FirstOrDefault();

            var qu = from x in db.Sales
                     where x.Cust_ID == cust.Cust_ID
                     select new { x.Sal_ID, x.Sal_Date, x.TotalPrice };
            grid_invoice.DataSource = qu.ToList();
            txtsum.Text = qu.Sum(x => x.TotalPrice).ToString();

        }
        #endregion

       


    }
}
