using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MYSTORE.M_EntityFramework;
using MYSTORE.UI_FORM;
namespace MYSTORE.UI_FORM
{
    public partial class frm_Purchase : Form
    {
        #region init
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        HOME h = new HOME();
        Product prod = new Product();
        Suppoler supp = new Suppoler();
        #region clear data
        public void cleardata()
        {
            txtcat.Text = "";
            txtnetprice.Text = "";
            txtsaleprice.Text = "";
            txtqty.Text = 0.ToString();
            txtsum.Text = "";
            txtdis.Text = 0.ToString();
        }
        #endregion
        public frm_Purchase()
        {
            InitializeComponent();
            cmbprod1.SelectedIndex = -1;

            var rs1 = db.Products.Select(x => x.Name).ToList();
            var rs2 = db.Suppolers.Select(x => x.Name).ToList();

            cmbprod1.DataSource = rs1;
            AutoCompleteStringCollection acsc1 = new AutoCompleteStringCollection();


            acsc1.AddRange(rs1.ToArray());


            cmbprod1.AutoCompleteCustomSource = acsc1;

            //cmbprod.Focus();
            //cmbprod.Select();
        }
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
        #region combo box
        private void cmbprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cmbprod1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //i = int.Parse(cmbprod.SelectedValue.ToString());
                //prod = db.Products.SingleOrDefault(x => x.Prod_ID == i);
                prod = db.Products.Where(x => x.Name == cmbprod1.Text).FirstOrDefault();
                // txtqty.Text = prod.Quantity.ToString();
                txtsaleprice.Text = prod.Sale_price.ToString();
                txtnetprice.Text = prod.Net_Price.ToString();
                txtcat.Text = prod.Category;
                //txtqty.Focus();

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
            MemoryStream ms = new MemoryStream();
            frm_Product p = new frm_Product();
             double subtotal,tt;
            try
            {

                for (int i = 0; i < datashowdet.RowCount; i++)
                {
                    if (datashowdet.Rows[i].Cells["ID"].Value.ToString() == prod.Prod_ID.ToString())
                    {
                        int q = (int.Parse(datashowdet.Rows[i].Cells["QANTITY"].Value.ToString()) + int.Parse(txtqty.Text));
                       
                            datashowdet.Rows[i].Cells["QANTITY"].Value = int.Parse(datashowdet.Rows[i].Cells["QANTITY"].Value.ToString()) + int.Parse(txtqty.Text);


                            tt = Convert.ToDouble(datashowdet.Rows[i].Cells["TOTAL"].Value.ToString());
                            datashowdet.Rows[i].Cells["TOTAL"].Value = double.Parse(datashowdet.Rows[i].Cells["QANTITY"].Value.ToString()) * prod.Sale_price;
                            subtotal = double.Parse(datashowdet.Rows[i].Cells["QANTITY"].Value.ToString());
                            

                     
                        goto TOTAL;

                    }

                }





                string id = prod.Prod_ID.ToString();
                string prod_Name = cmbprod1.Text;
                int qantity = Convert.ToInt32(txtqty.Text);
                double Sprice = Convert.ToDouble(txtsaleprice.Text);
                double Nprice = Convert.ToDouble(txtnetprice.Text);
                double disc = Convert.ToDouble(txtdis.Text);
                subtotal = qantity * ((Nprice) * (1 - disc / 100));

                object[] row = {  id, prod_Name, txtcat.Text, txtnetprice.Text, txtsaleprice.Text, txtqty.Text, txtdis.Text, subtotal.ToString()};

                datashowdet.Rows.Add(row);
                txtqty.Text = 0.ToString();
            // cleardata();


               TOTAL:
                double sum = 0;
                for (int i = 0; i < datashowdet.RowCount; i++)
                {

                    double a1 = Convert.ToDouble(datashowdet.Rows[i].Cells[7].Value);
                    sum += a1;

                }
                txtsum.Text = sum.ToString();

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
                db.addpurinv(txtsupp.Text, datenow.Value, double.Parse(txtsum.Text));  //sror proc to add invoice 
                db.SaveChanges();
                for (int i = 0; i < datashowdet.RowCount; i++)
                {
                    var a1 = int.Parse(datashowdet.Rows[i].Cells["ID"].Value.ToString());
                    var a = datashowdet.Rows[i].Cells["_NAME"].Value.ToString();
                    var aa = datashowdet.Rows[i].Cells["CAT"].Value.ToString();
                    var a2 = int.Parse(datashowdet.Rows[i].Cells["QANTITY"].Value.ToString());
                    var a3 = double.Parse(datashowdet.Rows[i].Cells["NPRICE"].Value.ToString());
                    var a4 = double.Parse(datashowdet.Rows[i].Cells["PRICE"].Value.ToString());
                    var a5 = double.Parse(datashowdet.Rows[i].Cells["TOTAL"].Value.ToString());
                    var a6 = double.Parse(datashowdet.Rows[i].Cells["DIS"].Value.ToString());
                    db.updatecountprod(a, aa, a2, a3, a4, datenow.Value); //stor proc to update count the product
                    db.SaveChanges();
                    db.addpurditle(a1, a, a2, a3, a4, a5, a6); //stor proc to add detaile the invoice
                    db.SaveChanges();
                }
                db.updatesuppAccount(txtsupp.Text, double.Parse(txtsum.Text));
                db.SaveChanges();




                note.lab_message.Text = "purchase from" + txtsupp.Text + " done successfully";
                note.Show();
            }
            catch (Exception)
            {


            }

        }
        #endregion



        #region fast add 
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            frm_FastAdd frmfast = new frm_FastAdd();
            frmfast.ShowDialog();
        }

        #endregion

        #region refresh 
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cmbprod1.Text = "";
            /////////////////////////////////////////////////////
            cmbprod1.DataSource = db.Products.Select(x => x.Name).ToList();
        }
        #endregion

        #region Key controles


        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Left:
                    txtdis.Focus();
                    break;
                case Keys.Right:
                    txtdis.Focus();
                    break;
                case Keys.Down:
                    txtsaleprice.Focus();
                    break;
                case Keys.Up:
                    cmbprod1.Focus();
                    break;
                case Keys.Enter:
                    btnADD.PerformClick();
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
                case Keys.Up:
                    txtqty.Focus();
                    break;
                default:
                    break;

            }
        }

        private void txtnetprice_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Up:
                    txtdis.Focus();
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

        private void txtcat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Down:
                    txtqty.Focus();
                    break;
                case Keys.Right:
                    cmbprod1.Focus();
                    break;
                case Keys.Up:
                    txtqty.Focus();
                    break;
                default:
                    break;

            }

        }
        private void txtdis_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Down:
                    txtnetprice.Focus();
                    break;
                case Keys.Right:
                    txtqty.Focus();
                    break;
                case Keys.Up:
                    cmbprod1.Focus();
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
           
        }
        private void cmbprod1_KeyDown(object sender, KeyEventArgs e)
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

        #region back to invoice form
        private void cmbsupp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Purchase0 frm_pur0 = new frm_Purchase0();
            pnl_pur.Controls.Clear();
            pnl_pur.Controls.Add(frm_pur0.pnl_Pinvoice);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_Purchase0 frm_pur0 = new frm_Purchase0();
            pnl_pur.Controls.Clear();
            pnl_pur.Controls.Add(frm_pur0.pnl_Pinvoice);
        }

        #endregion

        #region print
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            HOME h = new HOME();
            supp = db.Suppolers.Where(x => x.Name == txtsupp.Text).FirstOrDefault();
            string phone = supp.Phone.ToString();
            string suppolerN = "Suppoler Name : " + txtsupp.Text;
            string datainv = " Date  : " + datenow.Value;
            string comp = "Company  : " + supp.CompanyName.ToString();
            e.Graphics.DrawString(h.labCompName.Text + " StoreHouse", new System.Drawing.Font("SimSun", 30, FontStyle.Bold), Brushes.DodgerBlue, 230, 5);
            e.Graphics.DrawString(suppolerN, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 175, 60);
            e.Graphics.DrawString(comp, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 175, 95);
            e.Graphics.DrawString("Phone : "+phone, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 175, 135);
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
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 200, 220);    
            string g4 = "NET Price";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua",15, FontStyle.Bold), Brushes.Black,  310, 220);    
            string g5 = "Sale Price";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 430, 220);    
            string g6 = "Quantity";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 550 ,220);
            string g7 = "Discount";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 640, 220);

            string g8 = "TOTAL";
            e.Graphics.DrawString(g8, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 750, 220);    

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 0, 240);
            /////////////////////////////////////////////////////////////////
            int height = 245;
            for (int l = numberOfItemsPrintedSoFar; l < datashowdet.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= datashowdet.Rows.Count)
                    {

                        height += datashowdet.Rows[0].Height;
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[0].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(15, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[1].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(100, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[2].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(240, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[3].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(340, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[4].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(460, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[5].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(580, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[6].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(680, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));
                        e.Graphics.DrawString(datashowdet.Rows[l].Cells[7].FormattedValue.ToString(), datashowdet.Font = new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(790, height, datashowdet.Columns[0].Width, datashowdet.Rows[0].Height));


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
            e.Graphics.DrawString(lin, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 0, height+10);

            string t = "SUMION :";
            e.Graphics.DrawString(t, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 620, height + 25);
            string t1 = txtsum.Text;
            e.Graphics.DrawString(t1, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 750, height + 25);

            string t2 = "Saler " ;
            e.Graphics.DrawString(t2, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 90, height + 70);
            string t3 = "Signature and Seal";//التوقيع والختم 
            e.Graphics.DrawString(t3, new System.Drawing.Font("Book Antiqua", 15, FontStyle.Bold), Brushes.Black, 600, height + 70);

            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;

        }



        #endregion

        

      
    }
}
