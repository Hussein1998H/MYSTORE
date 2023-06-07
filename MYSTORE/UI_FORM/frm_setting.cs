using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MYSTORE.M_EntityFramework;

namespace MYSTORE.UI_FORM
{
    public partial class frm_setting : Form
    {
        #region init 
        MemoryStream ms = new MemoryStream();
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        public frm_setting()
        {
            InitializeComponent();
            getdata();
        }
        private void frm_setting_Load(object sender, EventArgs e)
        {

        }
        private void pic_logo_EditValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region method 
        private void getdata()
        {
            var compname = Properties.Settings.Default.CompanyName;
            var compdes = Properties.Settings.Default.CompanyDescription;
            txtname.Text = compname;
            txt_description.Text = compdes;
            try
            {
                var img = Convert.FromBase64String(Properties.Settings.Default.Logo);
                ms = new MemoryStream(img);
                pic_logo.Image = Image.FromStream(ms);

            }
            catch
            {


            }
        }
        private void savedata()
        {
            Properties.Settings.Default.CompanyName = txtname.Text;
            Properties.Settings.Default.CompanyDescription = txt_description.Text;

            try
            {

                //settingحفظ الصورة في متغيرات    

                ms = new MemoryStream();
                pic_logo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.Logo = Convert.ToBase64String(ms.ToArray()); // ToBase64String عملية تحويل مصفوفة البايت الى نص 
            }
            catch
            {


            }
            Properties.Settings.Default.Save();
            MessageBox.Show("save data done !", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion



        #region save 
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            savedata();
        }
        #endregion

        #region take backup 
        private  void btnadd_Click(object sender, EventArgs e) //لان هذه الملية تحتاج الئ وقت حتى تتم 
        {


            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var res = folder.ShowDialog();
                if (res == DialogResult.OK)
                {
                  
                    db = new Manege_StoreEntities4();
                    string dbname = db.Database.Connection.Database;
                    string dbBackup = "MYdbBackup" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm");//
                    var fullpath = folder.SelectedPath.ToString()+"\\" + dbBackup + ".bak";
                    string sqlcommand = @"BACKUP DATABASE [Manege_Store] TO DISK = N'" + fullpath + "' WITH NOFORMAT,NOINIT, NAME = N'Manege_Store', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                    

                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlcommand, dbname, dbBackup));
                  
                    MessageBox.Show("take back up done !");
                  
                }
            }
            catch
            {
               

            }








            ////////////////////////////////////////////////////////////
           


            //SaveFileDialog save = new SaveFileDialog();
            //save.Filter = "data base|*.mdb";
            //if (save.ShowDialog() == DialogResult.OK)
            //{
            //    prg_pnl.Visible = true;
            //    try
            //    {
            //        File.Delete(save.FileName);
            //    }
            //    catch { }
            //    try
            //    {

            //        string path = Application.StartupPath + @"\Manege_Store.mdb";

            //        File.Copy(path, save.FileName, true);
            //        prg_pnl.Visible = true;
            //        MessageBox.Show("take back up done !");
            //    }
            //    catch
            //    {

            //        MessageBox.Show("can not take a bakup !");
            //    }
            //}
        }
        //private bool Backup(FolderBrowserDialog folder)
        //{
        //    try
        //    {
        //        db = new Manege_StoreEntities();
        //        string dbname = db.Database.Connection.Database;
        //        string dbBackup = "MYdbBackup" + DateTime.Now.ToString("yyyymmddHHmm");
        //        var fullpath = folder.SelectedPath.ToString() + dbBackup + ".bak";
        //        string sqlcommand = @"BACKUP DATABASE [{0}] TO DISK = " + fullpath + "'// WITH NOINIT, NAME = N'Manege_Store', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
        //        int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlcommand, dbname, dbBackup));
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;

            //    }
       // }
        #endregion

        #region Restor backup
        private  void btnRest_Click(object sender, EventArgs e)
        {


            try
            {
                OpenFileDialog folder = new OpenFileDialog();
                var res = folder.ShowDialog();
                if (res == DialogResult.OK)
                {
                    db = new Manege_StoreEntities4();

                    string dbname = db.Database.Connection.Database;
                    // string dbBackup = "MYdbBackup" + DateTime.Now.ToString("yyyymmddHHmm");
                   
                    string sqlcommand = @"USE [master] RESTORE DATABASE [Manege_Store] FROM  DISK = N'F:\New folder\MYdbBackup2022_05_13_23_52.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5 ";//"USE [master]; GO RESTORE DATABASE [{0}] FROM  DISK = N'" + folder.FileName + "'";
                    //"RESTORE DATABASE [Manege_Store] FROM  DISK = N'" + folder.FileName + "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5"
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlcommand, dbname));
                    MessageBox.Show("Restore Backup Do successfully !");
                }
            }
            catch
            {


            }



            //////////////////////////////////////////////////////////////
            //try
            //{
            //    OpenFileDialog folder = new OpenFileDialog();
            //    var res = folder.ShowDialog();
            //    if (res == DialogResult.OK)
            //    {

            //        var resulet = await Task.Run(() => Restore(folder));
            //        if (resulet == true)
            //        {
            //            prg_pnl.Visible = false;
            //            MessageBox.Show("Restore Backup Do successfully !");
            //        }
            //        else
            //        {
            //            prg_pnl.Visible = false;
            //            MessageBox.Show("Restore Backup  Feaild !");

            //        }
            //    }
            //}
            //catch
            //{
            //    prg_pnl.Visible = false;
            //    MessageBox.Show("Restore Backup  Feaild !");
            //}
        }
        //private bool Restore(OpenFileDialog folder)
        //{
        //    try
        //    {
        //        db = new Manege_StoreEntities();

        //        string dbname = db.Database.Connection.Database;
        //        //string sqlcommand = @"USE [master]; GO RESTORE DATABASE [{0}] FROM  DISK = N'" + folder.FileName + "'" + " WITH  FILE = 1, NOUNLOAD, STATS = 10";
        //        string sqlcommand = @"USE MASTER;RESTORE DATABASE [{0}] FROM  DISK =N'" + folder.FileName + "'";
        //        int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlcommand, dbname));
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;

        //    }
        //}
        #endregion












    }
}
