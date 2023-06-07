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
using MYSTORE.M_EntityFramework;
using MYSTORE.UI_FORM;


namespace MYSTORE.UI_FORM
{
    public partial class frm_login : Form
    {
        #region init 
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        HOME h = new HOME();
        TB_Users users = new TB_Users();
        SpeechSynthesizer Reader = new SpeechSynthesizer();
        public frm_login()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            txtname.Select();
        }
        #endregion

        #region login 
        private void btnlog_Click(object sender, EventArgs e)
        {
            HOME frm_main = new HOME();
            frm_Product prod = new frm_Product();
            frm_Customer cust = new frm_Customer();
            frm_Suppoler supp = new frm_Suppoler();

            try
            {
                users = db.TB_Users.Where(x => x.user_Name.Equals(txtname.Text) && x.user_pass.Equals(txtpass.Text)).FirstOrDefault();
                if (users != null)
                {
                    frm_main.txtusername.Caption = users.user_Name;
                    frm_main.txtuserrol.Caption = users.user_roll;
                    if (users.user_roll == "USER")
                    {
                        frm_main.btnusers.Visible = false;
                        frm_main.btn_setting.Visible = false;
                        prod.btndelete.Visible = false;
                        prod.btndelete.Enabled = false;
                        cust.btndelete.Visible = false;
                        supp.btndelete.Visible = false;

                    }


                    frm_main.Show();
                    this.Hide();
                    Reader.Dispose();
                    Reader = new SpeechSynthesizer();
                    Reader.Speak("hello " + txtname.Text + "have a nice day");

                }
                else
                {
                    MessageBox.Show(" ! اسم المستخدم أو كلمة المرور خاطئة", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        #endregion

        #region Key controles



        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    txtpass.Focus();
                    break;
                case Keys.Down:
                    txtpass.Focus();
                    break;
                case Keys.Enter:
                    btnlog.PerformClick();
                    break;
                default:
                    break;

            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    txtname.Focus();
                    break;
                case Keys.Down:
                    txtname.Focus();
                    break;
                case Keys.Enter:
                    btnlog.PerformClick();
                    break;
                default:
                    break;

            }
        }



        #endregion

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (txtpass.isPassword==true)
            {
                txtpass.isPassword = false;
            }
            else
            {
                txtpass.isPassword = true;
            }
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Reader.Dispose();
            //Reader = new SpeechSynthesizer();
            //Reader.Speak("Good bye ");
        }
    }
}
