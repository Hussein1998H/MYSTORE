using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYSTORE.M_EntityFramework;
using MYSTORE.UI_FORM;
namespace MYSTORE.UI_FORM
{
    public partial class frm_FastAdd : Form
    {
        #region init 
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        Product prod = new Product();
        public frm_FastAdd()
        {
            InitializeComponent();
            txtname.Focus();
            txtname.Select();
        }
        #endregion

        #region add 
        private void btnADD_Click_1(object sender, EventArgs e)
        {
            frm_Notivecation note = new frm_Notivecation();
            frm_Product fp = new frm_Product();
            // frm_Purchase p = new frm_Purchase();
            MemoryStream ms = new MemoryStream();
            Regex reg = new Regex(@"^(\d+)|(\d+\.\d+)$");

            if ((!reg.IsMatch(txtnetprice.Text) && !reg.IsMatch(txtsaleprice.Text)))
            {
                MessageBox.Show("Please Enter The Correct Formula ! ");
            }
            else
            {
                try
                {

                    fp.pic_prod.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    prod.image = ms.ToArray();
                    prod.Name = txtname.Text;
                    prod.Category = txtcat.Text;
                    prod.Quantity = 0;
                    prod.Date = dateprod.Value;
                    prod.Net_Price = Convert.ToDouble(txtnetprice.Text);
                    prod.Sale_price = Convert.ToDouble(txtsaleprice.Text);
                    db.Products.Add(prod);
                    db.SaveChanges();
                    note.lab_message.Text = "تمت إضافة المنتج بنجاح";
                    note.Show();
                    // p.cmbprod.DataSource = db.Products.ToList();
                    this.Close();

                }
                catch
                {


                }
            }
        }
        #endregion

       #region Key controles

    
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Left:
                    txtcat.Focus();
                    break;
                case Keys.Right:
                    txtcat.Focus();
                    break;
                case Keys.Down:
                    txtnetprice.Focus();
                    break;
                default:
                    break;

            }
        }

        private void txtnetprice_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Left:
                    txtsaleprice.Focus();
                    break;
                case Keys.Right:
                    txtsaleprice.Focus();
                    break;
                case Keys.Down:
                    txtname.Focus();
                    break;
                case Keys.Up:
                    txtname.Focus();
                    break;
                case Keys.Enter:
                    btnADD.PerformClick();
                    break;

                default:
                    break;

            }
        }

        private void txtcat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Left:
                    txtname.Focus();
                    break;
                case Keys.Right:
                    txtname.Focus();
                    break;
                case Keys.Down:
                    txtsaleprice.Focus();
                    break;
                case Keys.Up:
                    txtsaleprice.Focus();
                    break;

                default:
                    break;

            }
        }

        private void txtsaleprice_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Left:
                    txtnetprice.Focus();
                    break;
                case Keys.Right:
                    txtnetprice.Focus();
                    break;
                case Keys.Down:
                    txtcat.Focus();
                    break;
                case Keys.Up:
                    txtcat.Focus();
                    break;
                case Keys.Enter:
                    btnADD.PerformClick();
                    break;

                default:
                    break;

            }
        }
        #endregion

      
    }
}
