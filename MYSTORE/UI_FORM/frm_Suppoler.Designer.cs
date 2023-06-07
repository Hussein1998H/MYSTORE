
namespace MYSTORE.UI_FORM
{
    partial class frm_Suppoler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Suppoler));
            this.btnrefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_down = new System.Windows.Forms.Panel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btn_colaps = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtaddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcomp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtaccount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_supp = new System.Windows.Forms.Panel();
            this.grid_supp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_c_top = new System.Windows.Forms.Panel();
            this.pnl_down.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_supp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_supp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_c_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrefresh
            // 
            this.btnrefresh.AllowFocus = false;
            this.btnrefresh.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnrefresh.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Appearance.Options.UseBackColor = true;
            this.btnrefresh.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnrefresh, 4);
            this.btnrefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.ImageOptions.Image")));
            this.btnrefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnrefresh.Location = new System.Drawing.Point(192, 4);
            this.btnrefresh.Name = "btnrefresh";
            this.tablePanel2.SetRow(this.btnrefresh, 0);
            this.btnrefresh.Size = new System.Drawing.Size(125, 46);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "تحديث";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.AllowFocus = false;
            this.btndelete.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.Options.UseBackColor = true;
            this.btndelete.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btndelete, 3);
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btndelete.Location = new System.Drawing.Point(324, 4);
            this.btndelete.Name = "btndelete";
            this.tablePanel2.SetRow(this.btndelete, 0);
            this.btndelete.Size = new System.Drawing.Size(136, 46);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "حذف";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.AllowFocus = false;
            this.btnadd.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Appearance.Options.UseBackColor = true;
            this.btnadd.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnadd, 1);
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnadd.Location = new System.Drawing.Point(606, 4);
            this.btnadd.Name = "btnadd";
            this.tablePanel2.SetRow(this.btnadd, 0);
            this.btnadd.Size = new System.Drawing.Size(132, 46);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "إضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pnl_down
            // 
            this.pnl_down.Controls.Add(this.tablePanel2);
            this.pnl_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_down.Location = new System.Drawing.Point(0, 526);
            this.pnl_down.Name = "pnl_down";
            this.pnl_down.Size = new System.Drawing.Size(800, 55);
            this.pnl_down.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 61.44F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 61.88F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 63.2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 57.92F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 34.16F)});
            this.tablePanel2.Controls.Add(this.btnprint);
            this.tablePanel2.Controls.Add(this.btnadd);
            this.tablePanel2.Controls.Add(this.btnupdate);
            this.tablePanel2.Controls.Add(this.btnrefresh);
            this.tablePanel2.Controls.Add(this.btndelete);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(800, 55);
            this.tablePanel2.TabIndex = 0;
            // 
            // btnprint
            // 
            this.btnprint.AllowFocus = false;
            this.btnprint.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnprint.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Appearance.Options.UseBackColor = true;
            this.btnprint.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnprint, 5);
            this.btnprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.ImageOptions.Image")));
            this.btnprint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnprint.Location = new System.Drawing.Point(80, 4);
            this.btnprint.Name = "btnprint";
            this.tablePanel2.SetRow(this.btnprint, 0);
            this.btnprint.Size = new System.Drawing.Size(107, 46);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "طباعة";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AllowFocus = false;
            this.btnupdate.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Appearance.Options.UseBackColor = true;
            this.btnupdate.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnupdate, 2);
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnupdate.Location = new System.Drawing.Point(466, 4);
            this.btnupdate.Name = "btnupdate";
            this.tablePanel2.SetRow(this.btnupdate, 0);
            this.btnupdate.Size = new System.Drawing.Size(133, 46);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_colaps);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 275);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tablePanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(20, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 255);
            this.groupControl1.TabIndex = 2;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.65F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.35F)});
            this.tablePanel1.Controls.Add(this.panel4);
            this.tablePanel1.Controls.Add(this.panel3);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(2, 23);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(776, 230);
            this.tablePanel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.tablePanel1.SetColumn(this.panel4, 0);
            this.panel4.Controls.Add(this.txtaddress);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtcomp);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtname);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(396, 3);
            this.panel4.Name = "panel4";
            this.tablePanel1.SetRow(this.panel4, 0);
            this.panel4.Size = new System.Drawing.Size(377, 224);
            this.panel4.TabIndex = 12;
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtaddress.HintText = "";
            this.txtaddress.isPassword = false;
            this.txtaddress.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtaddress.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtaddress.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtaddress.LineThickness = 3;
            this.txtaddress.Location = new System.Drawing.Point(16, 178);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(340, 41);
            this.txtaddress.TabIndex = 16;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddress_KeyDown_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(288, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "العنوان";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtcomp
            // 
            this.txtcomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcomp.BackColor = System.Drawing.Color.White;
            this.txtcomp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcomp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcomp.HintForeColor = System.Drawing.Color.Empty;
            this.txtcomp.HintText = "";
            this.txtcomp.isPassword = false;
            this.txtcomp.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtcomp.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtcomp.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtcomp.LineThickness = 3;
            this.txtcomp.Location = new System.Drawing.Point(16, 101);
            this.txtcomp.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(340, 43);
            this.txtcomp.TabIndex = 13;
            this.txtcomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcomp.OnValueChanged += new System.EventHandler(this.txtcomp_OnValueChanged);
            this.txtcomp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcomp_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(278, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "اسم الشركة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtname.Location = new System.Drawing.Point(16, 31);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(340, 41);
            this.txtname.TabIndex = 14;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(315, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "الاسم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 1);
            this.panel3.Controls.Add(this.txtaccount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtmail);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtphone);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 0);
            this.panel3.Size = new System.Drawing.Size(387, 224);
            this.panel3.TabIndex = 11;
            // 
            // txtaccount
            // 
            this.txtaccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaccount.BackColor = System.Drawing.Color.White;
            this.txtaccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaccount.HintForeColor = System.Drawing.Color.Empty;
            this.txtaccount.HintText = "";
            this.txtaccount.isPassword = false;
            this.txtaccount.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtaccount.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtaccount.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtaccount.LineThickness = 3;
            this.txtaccount.Location = new System.Drawing.Point(20, 178);
            this.txtaccount.Margin = new System.Windows.Forms.Padding(4);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(335, 41);
            this.txtaccount.TabIndex = 15;
            this.txtaccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtaccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaccount_KeyDown_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(289, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "الرصيد";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtmail
            // 
            this.txtmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmail.BackColor = System.Drawing.Color.White;
            this.txtmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtmail.HintText = "";
            this.txtmail.isPassword = false;
            this.txtmail.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtmail.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtmail.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtmail.LineThickness = 3;
            this.txtmail.Location = new System.Drawing.Point(20, 105);
            this.txtmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(335, 41);
            this.txtmail.TabIndex = 12;
            this.txtmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmail_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(248, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "البريد الالكتروني";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtphone.HintForeColor = System.Drawing.Color.Empty;
            this.txtphone.HintText = "";
            this.txtphone.isPassword = false;
            this.txtphone.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtphone.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtphone.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtphone.LineThickness = 3;
            this.txtphone.Location = new System.Drawing.Point(20, 30);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(335, 41);
            this.txtphone.TabIndex = 13;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtphone_KeyDown_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(289, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "رقم الهاتف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnl_supp
            // 
            this.pnl_supp.Controls.Add(this.grid_supp);
            this.pnl_supp.Controls.Add(this.pnl_c_top);
            this.pnl_supp.Controls.Add(this.pnl_down);
            this.pnl_supp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_supp.Location = new System.Drawing.Point(0, 0);
            this.pnl_supp.Name = "pnl_supp";
            this.pnl_supp.Size = new System.Drawing.Size(800, 581);
            this.pnl_supp.TabIndex = 1;
            // 
            // grid_supp
            // 
            this.grid_supp.DataSource = typeof(MYSTORE.M_EntityFramework.Suppoler);
            this.grid_supp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_supp.Location = new System.Drawing.Point(0, 275);
            this.grid_supp.MainView = this.gridView1;
            this.grid_supp.Name = "grid_supp";
            this.grid_supp.Size = new System.Drawing.Size(800, 251);
            this.grid_supp.TabIndex = 2;
            this.grid_supp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_supp.DoubleClick += new System.EventHandler(this.grid_supp_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccount,
            this.colMail,
            this.colPhone,
            this.colAddress,
            this.colCompanyName,
            this.colName});
            this.gridView1.GridControl = this.grid_supp;
            this.gridView1.Name = "gridView1";
            // 
            // colAccount
            // 
            this.colAccount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colAccount.AppearanceCell.Options.UseFont = true;
            this.colAccount.AppearanceCell.Options.UseTextOptions = true;
            this.colAccount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAccount.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colAccount.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAccount.AppearanceHeader.Options.UseBackColor = true;
            this.colAccount.AppearanceHeader.Options.UseFont = true;
            this.colAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colAccount.Caption = "الاسم";
            this.colAccount.FieldName = "Name";
            this.colAccount.MinWidth = 40;
            this.colAccount.Name = "colAccount";
            this.colAccount.OptionsColumn.AllowEdit = false;
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 5;
            this.colAccount.Width = 113;
            // 
            // colMail
            // 
            this.colMail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colMail.AppearanceCell.Options.UseFont = true;
            this.colMail.AppearanceCell.Options.UseTextOptions = true;
            this.colMail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMail.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMail.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colMail.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMail.AppearanceHeader.Options.UseBackColor = true;
            this.colMail.AppearanceHeader.Options.UseFont = true;
            this.colMail.AppearanceHeader.Options.UseTextOptions = true;
            this.colMail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMail.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colMail.Caption = "اسم الشركة";
            this.colMail.FieldName = "CompanyName";
            this.colMail.MinWidth = 40;
            this.colMail.Name = "colMail";
            this.colMail.OptionsColumn.AllowEdit = false;
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 4;
            this.colMail.Width = 129;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPhone.AppearanceCell.Options.UseFont = true;
            this.colPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPhone.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colPhone.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPhone.AppearanceHeader.Options.UseBackColor = true;
            this.colPhone.AppearanceHeader.Options.UseFont = true;
            this.colPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colPhone.Caption = "العنوان";
            this.colPhone.FieldName = "Address";
            this.colPhone.MinWidth = 40;
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 147;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceHeader.Options.UseBackColor = true;
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colAddress.Caption = "رقم الهاتف";
            this.colAddress.FieldName = "Phone";
            this.colAddress.MinWidth = 40;
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 147;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCompanyName.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCompanyName.AppearanceHeader.Options.UseBackColor = true;
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colCompanyName.Caption = "البريد الالكتروني";
            this.colCompanyName.FieldName = "Mail";
            this.colCompanyName.MinWidth = 40;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.AllowEdit = false;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            this.colCompanyName.Width = 159;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceCell.Options.UseTextOptions = true;
            this.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceHeader.Options.UseBackColor = true;
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colName.Caption = "الرصيد";
            this.colName.FieldName = "Account";
            this.colName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colName.MinWidth = 40;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 114;
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
            // frm_Suppoler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.pnl_supp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Suppoler";
            this.ShowInTaskbar = false;
            this.Text = "frm_Suppoler";
            this.pnl_down.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_supp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_supp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_c_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnrefresh;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.Panel pnl_down;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btn_colaps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public System.Windows.Forms.Panel pnl_supp;
        private System.Windows.Forms.Panel pnl_c_top;
        private DevExpress.XtraGrid.GridControl grid_supp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
        public DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtaddress;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcomp;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtaccount;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmail;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtphone;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
    }
}