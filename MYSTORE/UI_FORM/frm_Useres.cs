﻿using System;
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
    public partial class frm_Useres : Form
    {
        #region init
        Manege_StoreEntities4 db = new Manege_StoreEntities4();
        TB_Users users = new TB_Users();
        int id = 0;
        #region clear data
        private void claredata()
        {
            txtname.Text = "";
            txtpass.Text = "";
            cmbroll.Text = "";

        }
        #endregion
        public frm_Useres()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            MYSTORE.M_EntityFramework.Manege_StoreEntities4 dbContext = new MYSTORE.M_EntityFramework.Manege_StoreEntities4();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                grid_user.DataSource = dbContext.TB_Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
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
                btn_colaps.Location = new Point(0, 250);
            }
        }
        #endregion
        #endregion
        #region add 

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtpass.Text == "" || cmbroll.Text == "")
            {
                MessageBox.Show("Please Enter All Data !", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnl_c_top.Height = 275;
                btn_colaps.Location = new Point(0, 250);
                txtname.Focus();
            }
            else
            {
                if (db.TB_Users.Any(x => x.user_Name == txtname.Text && x.user_pass == txtpass.Text))
                {
                    var res = MessageBox.Show("This Customer Is Alredy Exists", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grid_user.DataSource = db.TB_Users.Where(y => y.user_Name == txtname.Text).ToList();
                }
                else
                {
                    try
                    {
                        frm_Notivecation note = new frm_Notivecation();
                        users.user_Name = txtname.Text;
                        users.user_pass = txtpass.Text;
                        users.user_roll = cmbroll.Text;
                        // users.user_stat = "false";
                        db.TB_Users.Add(users);
                        db.SaveChanges();
                        claredata();
                        grid_user.DataSource = db.TB_Users.ToList();
                        note.lab_message.Text = "User added successfully";
                        note.Show();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                   
                }
            }
        }
        #endregion

        #region update 
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtpass.Text == "" || cmbroll.Text == "")
            {
                MessageBox.Show("Please Select Data TO Update It!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    frm_Notivecation note = new frm_Notivecation();
                    users.user_Name = txtname.Text;
                    users.user_pass = txtpass.Text;
                    users.user_roll = cmbroll.Text;
                    // users.user_stat = "false";
                    db.Entry(users).State = EntityState.Modified;
                    db.SaveChanges();
                    claredata();

                    grid_user.DataSource = db.TB_Users.ToList();
                    note.lab_message.Text = "user Update successfully";
                    note.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void grid_user_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
            txtname.Text = users.user_Name;
            txtpass.Text = users.user_pass;
            cmbroll.Text = users.user_roll;
            if (pnl_c_top.Height == 20)
            {
                pnl_c_top.Height = 275;
                btn_colaps.Location = new Point(0, 250);
            }
            txtname.Focus();
            txtname.Select();
        }
        #endregion



        #region delete 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                var res = MessageBox.Show("Are you Sure", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(users).State = EntityState.Deleted;
                    db.SaveChanges();
                    grid_user.DataSource = db.TB_Users.ToList();
                    claredata();
                    frm_Notivecation note = new frm_Notivecation();
                    note.lab_message.Text = "user Deleted";
                    note.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region refresh 
        private void btn_ref_Click(object sender, EventArgs e)
        {
            grid_user.DataSource = db.TB_Users.ToList();
        }
        #endregion

        
    }
}
