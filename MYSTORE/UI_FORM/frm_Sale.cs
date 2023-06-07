using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYSTORE.M_EntityFramework;
using MYSTORE.UI_FORM;

namespace MYSTORE.UI_FORM
{
    public partial class frm_Sale : Form
    {
        #region init 
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        Customer cust = new Customer();
        HOME h = new HOME();
        Product prod = new Product();
        #region clear data
        public void cleardata()
        {
            txtcat.Text = "";
            txtsaleprice.Text = "";
            txtsaleprice.Text = "";
            txtdisc.Text = 0.ToString();
            txtqty.Text = 0.ToString();
            txtaqty.Text = "";
            // txtsum.Text = "";
        }
        #endregion
        public frm_Sale()
        {
            InitializeComponent();
            var rs1 = db.Products.Select(x => x.Name).ToList();


            cmbprod.DataSource = rs1;
            AutoCompleteStringCollection acsc1 = new AutoCompleteStringCollection();


            acsc1.AddRange(rs1.ToArray());

            cmbprod.AutoCompleteCustomSource = acsc1;

        }
        #region nothing
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


        }

        private void frm_Sale_Resize(object sender, EventArgs e)
        {

        }
        #endregion
        #region colaps
        private void btn_colaps_Click(object sender, EventArgs e)
        {
            if (pnl_c_top.Height == 275)
            {
                pnl_c_top.Height = 20;
                btn_colaps.Location = new Point(0, 0);
            }
            else
            {
                pnl_c_top.Height = 275;
                btn_colaps.Location = new Point(0, 255);
            }
        }
        #endregion

        #region comboBox
        private void cmbprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                prod = db.Products.Where(x => x.Name == cmbprod.Text).FirstOrDefault();
                txtaqty.Text = prod.Quantity.ToString();
                txtsaleprice.Text = prod.Sale_price.ToString();
                txtcat.Text = prod.Category;
                // txtqty.Focus();
            }
            catch (Exception)
            {


            }
        }
        #endregion

        #endregion

        #region add 
       
        private void btnADD_Click(object sender, EventArgs e)
        {

                frm_Product p = new frm_Product();
            double subtotal, Aqty, Sqty, Nqty,tt;

            Aqty = Convert.ToInt32(txtaqty.Text);
            Sqty = Convert.ToInt32(txtqty.Text);
            Nqty = Aqty - Sqty;

            //for (int i = 0; i < datashowdet1.RowCount; i++)
            //{



            //    if (datashowdet1.Rows[i].Cells["_NAME"].Value.ToString() == cmbprod.Text && datashowdet1.Rows[i].Cells["CAT"].Value.ToString() == txtcat.Text)
            //    {
            //        MessageBox.Show("this element is olredy Exist ! ");
                   
            //    }
            //}
            //        int qindata = int.Parse(datashowdet1.Rows[i].Cells["QANTITY"].Value.ToString()) + int.Parse(txtqty.Text);
            //        if (qindata  - Aqty >= 0) 
            //        {
            //            datashowdet1.Rows[i].Cells["QANTITY"].Value = qindata/*int.Parse(datashowdet1.Rows[i].Cells["QANTITY"].Value.ToString()) + int.Parse(txtqty.Text)*/;

            //        }
            //        else
            //        {
            //            MessageBox.Show("can not do ");
            //        }
            //    }

            //     return;
            //}


            /////////////////////////////////////////////////////////////////////////////////////
            try
                    {


                        if (Nqty >= 0)
                        {

                    for (int i = 0; i < datashowdet1.RowCount ; i++)
                    {
                        if (datashowdet1.Rows[i].Cells["ID"].Value.ToString() == prod.Prod_ID.ToString())
                        {
                            int q = (int.Parse(datashowdet1.Rows[i].Cells["QANTITY"].Value.ToString()) + int.Parse(txtqty.Text));
                            Nqty = Aqty - q;
                            if (Nqty >= 0)
                            {
                                datashowdet1.Rows[i].Cells["QANTITY"].Value = int.Parse(datashowdet1.Rows[i].Cells["QANTITY"].Value.ToString()) + int.Parse(txtqty.Text);
                               

                                tt = Convert.ToDouble(datashowdet1.Rows[i].Cells["TOTAL"].Value.ToString());
                                datashowdet1.Rows[i].Cells["TOTAL"].Value = double.Parse(datashowdet1.Rows[i].Cells["QANTITY"].Value.ToString()) * prod.Sale_price;
                                subtotal = double.Parse(datashowdet1.Rows[i].Cells["QANTITY"].Value.ToString());
                                txtaqty.Text = prod.Quantity.ToString();

                            }
                            goto TOTAL;

                        }

                    }
                    string id = prod.Prod_ID.ToString();
                            string prod_Name = cmbprod.Text;
                            int qantity = Convert.ToInt32(txtqty.Text);
                            double price = Convert.ToDouble(txtsaleprice.Text);
                            double disc = Convert.ToDouble(txtdisc.Text);
                            subtotal = qantity * ((price) * (1 - disc / 100));

                            object[] row = { id, prod_Name, txtcat.Text, txtsaleprice.Text, txtaqty.Text, txtqty.Text, txtdisc.Text, subtotal.ToString() };
                            datashowdet1.Rows.Add(row);





                        TOTAL:
                    double sum = 0;
                            for (int j = 0; j < datashowdet1.RowCount; j++)
                            {
                                double a1 = Convert.ToDouble(datashowdet1.Rows[j].Cells[7].Value);
                                sum += a1;

                            }
                            txtsum.Text = sum.ToString();

                            //cleardata();
                        }

                        if (Nqty < 0)
                        {
                            MessageBox.Show("There Is Not Enoff Quantity ! ");
                        }
                    }
                    catch (Exception)
                    {


                    }
               
            
        }
        #endregion


        #region save 
        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_Notivecation note = new frm_Notivecation();
            try
            {


                db.addsaleinv(txtcust1.Text, datenow.Value, double.Parse(txtsum.Text));
                db.SaveChanges();
                Sale_Detile sd = new Sale_Detile();
                for (int i = 0; i < datashowdet1.RowCount; i++)
                {

                    var a1 = int.Parse(datashowdet1.Rows[i].Cells["ID"].Value.ToString());              // "ID"
                    var a = datashowdet1.Rows[i].Cells["_NAME"].Value.ToString();                      //  "_NAME"
                    var aa = datashowdet1.Rows[i].Cells["CAT"].Value.ToString();                      //   "CAT" 
                    var aa1 = int.Parse(datashowdet1.Rows[i].Cells["QTY"].Value.ToString());          //   "PRICE"
                    //sd.Sal_ID = int.Parse(db.detlastsaleid().ToString());QTY                         //  "QANTITY"
                    var a2 = int.Parse(datashowdet1.Rows[i].Cells["QANTITY"].Value.ToString());         // "DIS" 
                    var a3 = double.Parse(datashowdet1.Rows[i].Cells["PRICE"].Value.ToString());         //"TOTAL"
                    var a4 = double.Parse(datashowdet1.Rows[i].Cells["DIS"].Value.ToString());
                    var a5 = double.Parse(datashowdet1.Rows[i].Cells["TOTAL"].Value.ToString());

                    db.safesale(a, aa, aa1, a2);
                    db.SaveChanges();
                    db.addsaleditle(a1, a, a2, a3, a5, a4);
                    db.SaveChanges();

                }
                db.updatecustAccount(txtcust1.Text, double.Parse(txtsum.Text));
                db.SaveChanges();

                note.lab_message.Text = "sale to" + txtcust1.Text + " done successfully";
                note.Show();

            }
            catch (Exception)
            {


            }
        }
        #endregion

        #region back to invoice 
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            frm_Sale0 frm_sale0 = new frm_Sale0();
            pnl_sale.Controls.Clear();
            pnl_sale.Controls.Add(frm_sale0.pnl_invoice);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_Sale0 frm_sale0 = new frm_Sale0();
            pnl_sale.Controls.Clear();
            pnl_sale.Controls.Add(frm_sale0.pnl_invoice);
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            frm_Sale0 frm_sale0 = new frm_Sale0();
            pnl_sale.Controls.Clear();
            pnl_sale.Controls.Add(frm_sale0.pnl_invoice);
        }
        #endregion

        #region Key controles
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Up:
                    txtcat.Focus();
                    break;
                case Keys.Right:
                    txtdisc.Focus();
                    break;
                case Keys.Left:
                    txtdisc.Focus();
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
                case Keys.Up:
                    cmbprod.Focus();
                    break;
                case Keys.Down:
                    txtqty.Focus();
                    break;
                case Keys.Right:
                    txtsaleprice.Focus();
                    break;
                case Keys.Left:
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
                case Keys.Up:
                    cmbprod.Focus();
                    break;
                case Keys.Left:
                    txtcat.Focus();
                    break;
                case Keys.Right:
                    txtcat.Focus();
                    break;
                case Keys.Down:
                    txtdisc.Focus();
                    break;
                default:
                    break;

            }
        }

        private void txtdisc_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Up:
                    txtsaleprice.Focus();
                    break;
                case Keys.Right:
                    txtqty.Focus();
                    break;
                case Keys.Left:
                    txtqty.Focus();
                    break;
                case Keys.Enter:
                    btnADD.PerformClick();
                    break;
                default:
                    break;

            }
        }
        private void cmbprod_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Enter:
                    txtqty.Focus();
                    break;

                default:
                    break;

            }
        }
        #endregion

        #region print 
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            HOME h = new HOME();
            frm_login log = new frm_login();
            cust = db.Customers.Where(x => x.Name == txtcust1.Text).FirstOrDefault();
            string suppolerN = "Suppoler Name : " + txtcust1.Text;
            string datainv = " Date  : " + datenow.Value;
            string phone = "Phone : " + cust.Phone.ToString();
            string comp = "Company  : " + cust.CompanyName.ToString();
            e.Graphics.DrawString(h.labCompName.Text + " StoreHouse", new System.Drawing.Font("SimSun", 30, FontStyle.Bold), Brushes.DodgerBlue, 230, 5);
            e.Graphics.DrawString(suppolerN, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 175, 60);
            e.Graphics.DrawString(comp, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 175, 95);
            e.Graphics.DrawString(phone, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 175, 135);
            e.Graphics.DrawString(datainv, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 550, 60);


            e.Graphics.DrawImage(h.pic_logoComp.Image, 5, 20, 150, 150);
            //string curdhead = "Purchase invoice";
            //e.Graphics.DrawString(curdhead, new System.Drawing.Font("Book Antiqua", 20, FontStyle.Bold), Brushes.Black, 300, 50);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 0, 180);

            string g1 = "# NO ";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 5, 220);

            string g2 = "NAME";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 90, 220);

            string g3 = "Category";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 230, 220);
            string g4 = "Sale Price";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 350, 220);
            string g5 = "Quantity";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 480, 220);
            string g6 = "Discount";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 620, 220);
            string g7 = "TOTAL";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 750, 220);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 0, 240);
            /////////////////////////////////////////////////////////////////
            int height = 245;
            for (int l = numberOfItemsPrintedSoFar; l < datashowdet1.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= datashowdet1.Rows.Count)
                    {

                        height += datashowdet1.Rows[0].Height;
                        e.Graphics.DrawString(datashowdet1.Rows[l].Cells["ID"].FormattedValue.ToString(), datashowdet1.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(5, height, datashowdet1.Columns[0].Width, datashowdet1.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet1.Rows[l].Cells["_NAME"].FormattedValue.ToString(), datashowdet1.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(90, height, datashowdet1.Columns[0].Width, datashowdet1.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet1.Rows[l].Cells["CAT"].FormattedValue.ToString(), datashowdet1.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(250, height, datashowdet1.Columns[0].Width, datashowdet1.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet1.Rows[l].Cells["PRICE"].FormattedValue.ToString(), datashowdet1.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(370, height, datashowdet1.Columns[0].Width, datashowdet1.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet1.Rows[l].Cells["QANTITY"].FormattedValue.ToString(), datashowdet1.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(500, height, datashowdet1.Columns[0].Width, datashowdet1.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet1.Rows[l].Cells["DIS"].FormattedValue.ToString(), datashowdet1.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(650, height, datashowdet1.Columns[0].Width, datashowdet1.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet1.Rows[l].Cells["TOTAL"].FormattedValue.ToString(), datashowdet1.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(780, height, datashowdet1.Columns[0].Width, datashowdet1.Rows[0].Height));


                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }

            string lin = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(lin, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 0, height + 10);

            string t = "SUMION :";
            e.Graphics.DrawString(t, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Red, 620, height + 25);
            string t1 = txtsum.Text;
            e.Graphics.DrawString(t1, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Red, 750, height + 25);
            string t2 = "Saler " ;
            e.Graphics.DrawString(t2, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.DodgerBlue, 90, height + 70);
            string t3 = "Signature and Seal";//التوقيع والختم 
            e.Graphics.DrawString(t3, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.DodgerBlue, 600, height + 70);

            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;

        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        #endregion
    }
}
