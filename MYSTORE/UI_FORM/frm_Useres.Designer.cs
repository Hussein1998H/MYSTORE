
namespace MYSTORE.UI_FORM
{
    partial class frm_Useres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Useres));
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_user = new System.Windows.Forms.Panel();
            this.cmbroll = new System.Windows.Forms.ComboBox();
            this.grid_user = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluser_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_roll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_c_top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_colaps = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.pnl_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_c_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.AllowFocus = false;
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_delete, 3);
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(267, 4);
            this.btn_delete.Name = "btn_delete";
            this.tablePanel1.SetRow(this.btn_delete, 0);
            this.btn_delete.Size = new System.Drawing.Size(147, 46);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.AllowFocus = false;
            this.btn_add.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_add, 1);
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(579, 4);
            this.btn_add.Name = "btn_add";
            this.tablePanel1.SetRow(this.btn_add, 0);
            this.btn_add.Size = new System.Drawing.Size(135, 46);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "إضافة ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panel4);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.panel3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtname);
            this.groupControl1.Controls.Add(this.txtpass);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 255);
            this.groupControl1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(693, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 230);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(572, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "الصلاحية";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(2, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 230);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(559, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(542, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtname.HintForeColor = System.Drawing.Color.Empty;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtname.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtname.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtname.LineThickness = 3;
            this.txtname.Location = new System.Drawing.Point(115, 48);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(528, 41);
            this.txtname.TabIndex = 2;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.White;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.HintForeColor = System.Drawing.Color.Empty;
            this.txtpass.HintText = "";
            this.txtpass.isPassword = false;
            this.txtpass.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtpass.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtpass.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtpass.LineThickness = 3;
            this.txtpass.Location = new System.Drawing.Point(119, 134);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(528, 38);
            this.txtpass.TabIndex = 2;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ref
            // 
            this.btn_ref.AllowFocus = false;
            this.btn_ref.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ref.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseBackColor = true;
            this.btn_ref.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_ref, 4);
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_ref.Location = new System.Drawing.Point(111, 4);
            this.btn_ref.Name = "btn_ref";
            this.tablePanel1.SetRow(this.btn_ref, 0);
            this.btn_ref.Size = new System.Drawing.Size(150, 46);
            this.btn_ref.TabIndex = 3;
            this.btn_ref.Text = "تحديث";
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.tablePanel1);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 526);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(800, 55);
            this.pnl_buttons.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 27F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.6F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.68F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.64F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35.28F)});
            this.tablePanel1.Controls.Add(this.btn_ref);
            this.tablePanel1.Controls.Add(this.btn_add);
            this.tablePanel1.Controls.Add(this.btn_update);
            this.tablePanel1.Controls.Add(this.btn_delete);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(800, 55);
            this.tablePanel1.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.AllowFocus = false;
            this.btn_update.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseBackColor = true;
            this.btn_update.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_update, 2);
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(420, 4);
            this.btn_update.Name = "btn_update";
            this.tablePanel1.SetRow(this.btn_update, 0);
            this.btn_update.Size = new System.Drawing.Size(153, 46);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // pnl_user
            // 
            this.pnl_user.Controls.Add(this.cmbroll);
            this.pnl_user.Controls.Add(this.grid_user);
            this.pnl_user.Controls.Add(this.pnl_c_top);
            this.pnl_user.Controls.Add(this.pnl_buttons);
            this.pnl_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_user.Location = new System.Drawing.Point(0, 0);
            this.pnl_user.Name = "pnl_user";
            this.pnl_user.Size = new System.Drawing.Size(800, 581);
            this.pnl_user.TabIndex = 3;
            // 
            // cmbroll
            // 
            this.cmbroll.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbroll.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbroll.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbroll.FormattingEnabled = true;
            this.cmbroll.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.cmbroll.Location = new System.Drawing.Point(400, 230);
            this.cmbroll.Name = "cmbroll";
            this.cmbroll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbroll.Size = new System.Drawing.Size(247, 33);
            this.cmbroll.TabIndex = 27;
            // 
            // grid_user
            // 
            this.grid_user.DataSource = typeof(MYSTORE.M_EntityFramework.TB_Users);
            this.grid_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_user.Location = new System.Drawing.Point(0, 275);
            this.grid_user.MainView = this.gridView1;
            this.grid_user.Name = "grid_user";
            this.grid_user.Size = new System.Drawing.Size(800, 251);
            this.grid_user.TabIndex = 2;
            this.grid_user.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_user.DoubleClick += new System.EventHandler(this.grid_user_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser_Name,
            this.coluser_pass,
            this.coluser_roll});
            this.gridView1.GridControl = this.grid_user;
            this.gridView1.Name = "gridView1";
            // 
            // coluser_Name
            // 
            this.coluser_Name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluser_Name.AppearanceCell.Options.UseFont = true;
            this.coluser_Name.AppearanceCell.Options.UseTextOptions = true;
            this.coluser_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_Name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_Name.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.coluser_Name.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluser_Name.AppearanceHeader.Options.UseBackColor = true;
            this.coluser_Name.AppearanceHeader.Options.UseFont = true;
            this.coluser_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.coluser_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_Name.Caption = "كلمة المرور";
            this.coluser_Name.FieldName = "user_pass";
            this.coluser_Name.Name = "coluser_Name";
            this.coluser_Name.Visible = true;
            this.coluser_Name.VisibleIndex = 0;
            // 
            // coluser_pass
            // 
            this.coluser_pass.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluser_pass.AppearanceCell.Options.UseFont = true;
            this.coluser_pass.AppearanceCell.Options.UseTextOptions = true;
            this.coluser_pass.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_pass.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_pass.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.coluser_pass.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluser_pass.AppearanceHeader.Options.UseBackColor = true;
            this.coluser_pass.AppearanceHeader.Options.UseFont = true;
            this.coluser_pass.AppearanceHeader.Options.UseTextOptions = true;
            this.coluser_pass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_pass.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_pass.Caption = "اسم المستخدم";
            this.coluser_pass.FieldName = "user_Name";
            this.coluser_pass.Name = "coluser_pass";
            this.coluser_pass.Visible = true;
            this.coluser_pass.VisibleIndex = 2;
            // 
            // coluser_roll
            // 
            this.coluser_roll.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluser_roll.AppearanceCell.Options.UseFont = true;
            this.coluser_roll.AppearanceCell.Options.UseTextOptions = true;
            this.coluser_roll.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_roll.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_roll.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.coluser_roll.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluser_roll.AppearanceHeader.Options.UseBackColor = true;
            this.coluser_roll.AppearanceHeader.Options.UseFont = true;
            this.coluser_roll.AppearanceHeader.Options.UseTextOptions = true;
            this.coluser_roll.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluser_roll.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coluser_roll.Caption = "الصلاحية";
            this.coluser_roll.FieldName = "user_roll";
            this.coluser_roll.Name = "coluser_roll";
            this.coluser_roll.Visible = true;
            this.coluser_roll.VisibleIndex = 1;
            // 
            // pnl_c_top
            // 
            this.pnl_c_top.Controls.Add(this.groupControl1);
            this.pnl_c_top.Controls.Add(this.panel2);
            this.pnl_c_top.Controls.Add(this.panel1);
            this.pnl_c_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_c_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_c_top.Name = "pnl_c_top";
            this.pnl_c_top.Size = new System.Drawing.Size(800, 275);
            this.pnl_c_top.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_colaps);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(780, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 275);
            this.panel1.TabIndex = 0;
            // 
            // btn_colaps
            // 
            this.btn_colaps.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_colaps.ImageOptions.Image")));
            this.btn_colaps.Location = new System.Drawing.Point(0, 255);
            this.btn_colaps.Name = "btn_colaps";
            this.btn_colaps.Size = new System.Drawing.Size(20, 20);
            this.btn_colaps.TabIndex = 2;
            this.btn_colaps.Click += new System.EventHandler(this.btn_colaps_Click);
            // 
            // frm_Useres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.pnl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Useres";
            this.ShowInTaskbar = false;
            this.Text = "frm_Useres";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.pnl_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_c_top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private System.Windows.Forms.Panel pnl_buttons;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        public System.Windows.Forms.Panel pnl_user;
        private DevExpress.XtraGrid.GridControl grid_user;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnl_c_top;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_colaps;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_pass;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_roll;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.ComboBox cmbroll;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}