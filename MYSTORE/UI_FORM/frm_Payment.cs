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
    public partial class frm_Payment : Form
    {

        #region init 
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        Customer cust = new Customer();
        Suppoler supp = new Suppoler();
        public frm_Payment()
        {
            InitializeComponent();
            var rs2 = db.Customers.Select(x => x.Name).ToList();
            cmbcust.DataSource = rs2;
            AutoCompleteStringCollection acsc2 = new AutoCompleteStringCollection();
            acsc2.AddRange(rs2.ToArray());
            cmbcust.AutoCompleteCustomSource = acsc2;
            //////////////////////////////////
            var rs1 = db.Suppolers.Select(x => x.Name).ToList();
            cmbsupp.DataSource = rs1;
            AutoCompleteStringCollection acsc1 = new AutoCompleteStringCollection();
            acsc2.AddRange(rs1.ToArray());
            cmbsupp.AutoCompleteCustomSource = acsc1;

        }
        #endregion

        #region add  suppoler payment

        private void btnADD1_Click_1(object sender, EventArgs e)
        {
            try
            {
                frm_Notivecation note = new frm_Notivecation();
                double patc = Convert.ToDouble(txtSpay.Text);
                double acc = Convert.ToDouble(txt_s_acc.Text);
                if (patc > acc)
                {

                    var res = MessageBox.Show("your account les than are you sure !", "payment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        db.ACDebtor(cmbsupp.Text, patc, dateSpay.Value);
                        db.SaveChanges();
                        note.lab_message.Text = "Payment done successfully";
                        note.Show();

                        var qu = from x in db.Debtors
                                 where x.Supp_ID == supp.Supp_ID
                                 select new { x.batches, x.Date };
                        datashowSpay.DataSource = qu.ToList();
                        txtCpay.Text = "";

                    }
                }
                else
                {
                    db.ACDebtor(cmbsupp.Text, patc, dateSpay.Value);
                    db.SaveChanges();
                    note.lab_message.Text = "Payment done successfully";
                    note.Show();

                    var qu = from x in db.Debtors
                             where x.Supp_ID == supp.Supp_ID
                             select new { x.batches, x.Date };
                    datashowSpay.DataSource = qu.ToList();
                    txtCpay.Text = "";


                }
            }
            catch (Exception)
            {


            }
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
           
        }
        #endregion





        #region add customer payment  


        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Notivecation note = new frm_Notivecation();
                double patc = Convert.ToDouble(txtCpay.Text);
                double acc = Convert.ToDouble(txt_c_acc.Text);
                if (patc > acc)
                {
                    var res = MessageBox.Show(" your account les than are you sure !", "payment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        db.ACBorrower(cmbcust.Text, patc, dateCpay.Value);
                        db.SaveChanges();
                        note.lab_message.Text = "Payment done successfully";
                        note.Show();

                        var qu = from x in db.Borrowers
                                 where x.Cust_ID == cust.Cust_ID
                                 select new { x.batches, x.Date };
                        datashowCpay.DataSource = qu.ToList();
                        txtCpay.Text = "";

                    }
                }
                else
                {
                    db.ACBorrower(cmbcust.Text, patc, dateCpay.Value);
                    db.SaveChanges();
                    note.lab_message.Text = "Payment done successfully";
                    note.Show();

                    var qu = from x in db.Borrowers
                             where x.Cust_ID == cust.Cust_ID
                             select new { x.batches, x.Date };
                    datashowCpay.DataSource = qu.ToList();
                    txtCpay.Text = "";

                }

               

            }
            catch (Exception)
            {


            }
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            

        }
        #endregion

        #region combo box  
        private void dateCpay_onValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = db.Customers.Where(x => x.Name == cmbcust.Text).FirstOrDefault();
            txt_c_acc.Text = cust.Account.ToString();

            var qu = from x in db.Borrowers
                     where x.Cust_ID == cust.Cust_ID
                     select new { x.batches, x.Date };
            datashowCpay.DataSource = qu.ToList();
         
        }

        private void cmbsupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            supp = db.Suppolers.Where(x => x.Name == cmbsupp.Text).FirstOrDefault();
            txt_s_acc.Text = supp.Account.ToString();

            var qu = from x in db.Debtors
                     where x.Supp_ID == supp.Supp_ID
                     select new { x.batches, x.Date };
            datashowSpay.DataSource = qu.ToList();
          
        }




        #endregion

        #region key controle
        private void txtCpay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                btnADD.PerformClick();
                cust = db.Customers.Where(x => x.Name == cmbcust.Text).FirstOrDefault();
                txt_c_acc.Text = cust.Account.ToString();
            }
        }
        private void txtSpay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnADD1.PerformClick();
            }
        }

       
        private void cmbsupp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtSpay.Focus();
            }
        }

        private void cmbcust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtCpay.Focus();
            }
        }



        #endregion

        private void frm_Payment_Activated(object sender, EventArgs e)
        {
            supp = db.Suppolers.Where(x => x.Name == cmbsupp.Text).FirstOrDefault();
            txt_s_acc.Text = supp.Account.ToString();

            cust = db.Customers.Where(x => x.Name == cmbcust.Text).FirstOrDefault();
            txt_c_acc.Text = cust.Account.ToString();

        }

        private void txtCpay_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
