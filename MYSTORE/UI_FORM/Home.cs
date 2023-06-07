using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using MYSTORE.UI_FORM;
using MYSTORE.M_EntityFramework;

namespace MYSTORE
{
    public partial class HOME : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        
        frm_setting _Setting = new frm_setting();
        SpeechSynthesizer Reader = new SpeechSynthesizer();
        public HOME()
        {
            InitializeComponent();

            pic_logoComp.Image = _Setting.pic_logo.Image;
            labCompName.Text = _Setting.txtname.Text;
           

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            pic_logoComp.Image = _Setting.pic_logo.Image;
            labCompName.Text = _Setting.txtname.Text;

            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(pnl_m_t);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Home Page");

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frm_Product frm_p = new frm_Product();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(frm_p.pnl_prod);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Product Page");
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            frm_Suppoler frm_p = new frm_Suppoler();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(frm_p.pnl_supp);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Suppoler Page");
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            frm_Customer frm_p = new frm_Customer();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(frm_p.pnl_cust);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Customer Page");
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            frm_Purchase0 frm_pur0 = new frm_Purchase0();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(frm_pur0.pnl_Pinvoice);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Purchase Page");
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            frm_Sale0 frm_sale0 = new frm_Sale0();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(frm_sale0.pnl_invoice);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Sales Page");
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            frm_Payment frm_pay = new frm_Payment();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(frm_pay.pnl_pay);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Payments Manager Page");

        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            frm_Useres frm_user = new frm_Useres();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(frm_user.pnl_user);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Users Page");
        }

        private void HOME_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Application.Exit();
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_login _Login = new frm_login();
            _Login.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("dddd , dd MMMM yyyy HH:mm:ss");
        }

        private void accordionControlElement9_Click_1(object sender, EventArgs e)
        {
            
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(_Setting.pnl_setting);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Setting Page");
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            pic_logoComp.Image = _Setting.pic_logo.Image;
            labCompName.Text = _Setting.txtname.Text;
        }

        private void HOME_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Good bye ");
        }

        private void accordionControlElement9_Click_2(object sender, EventArgs e)
        {
            frm_inventory _inventory = new frm_inventory();
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(_inventory.pnl_inventory);
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
            Reader.Speak("Inventory Page");
        }

        private void pic_logoComp_Click(object sender, EventArgs e)
        {

        }
    }
}
