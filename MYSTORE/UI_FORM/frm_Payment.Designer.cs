
namespace MYSTORE.UI_FORM
{
    partial class frm_Payment
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
            this.pnl_pay = new System.Windows.Forms.Panel();
            this.tpnl_contain = new DevExpress.Utils.Layout.TablePanel();
            this.pnl_supp = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.datashowSpay = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbatches1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_b_supp = new System.Windows.Forms.Panel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btnADD1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSpay = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnl_inf_supp = new System.Windows.Forms.Panel();
            this.txt_s_acc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbsupp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateSpay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lab_h_supp = new System.Windows.Forms.Label();
            this.pnl_cust = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.datashowCpay = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbatches = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_b_cust = new System.Windows.Forms.Panel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.btnADD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpay = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnl_inf_cust = new System.Windows.Forms.Panel();
            this.txt_c_acc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbcust = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateCpay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lab_h_cust = new System.Windows.Forms.Label();
            this.pnl_pay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpnl_contain)).BeginInit();
            this.tpnl_contain.SuspendLayout();
            this.pnl_supp.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datashowSpay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.pnl_b_supp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            this.pnl_inf_supp.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.pnl_cust.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datashowCpay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_b_cust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            this.pnl_inf_cust.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_pay
            // 
            this.pnl_pay.Controls.Add(this.tpnl_contain);
            this.pnl_pay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_pay.Location = new System.Drawing.Point(0, 0);
            this.pnl_pay.Name = "pnl_pay";
            this.pnl_pay.Size = new System.Drawing.Size(800, 581);
            this.pnl_pay.TabIndex = 0;
            // 
            // tpnl_contain
            // 
            this.tpnl_contain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tpnl_contain.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.37F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.63F)});
            this.tpnl_contain.Controls.Add(this.pnl_supp);
            this.tpnl_contain.Controls.Add(this.pnl_cust);
            this.tpnl_contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnl_contain.Location = new System.Drawing.Point(0, 0);
            this.tpnl_contain.Name = "tpnl_contain";
            this.tpnl_contain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpnl_contain.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tpnl_contain.Size = new System.Drawing.Size(800, 581);
            this.tpnl_contain.TabIndex = 4;
            // 
            // pnl_supp
            // 
            this.pnl_supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tpnl_contain.SetColumn(this.pnl_supp, 0);
            this.pnl_supp.Controls.Add(this.panel9);
            this.pnl_supp.Controls.Add(this.pnl_inf_supp);
            this.pnl_supp.Controls.Add(this.panel2);
            this.pnl_supp.Location = new System.Drawing.Point(398, 3);
            this.pnl_supp.Name = "pnl_supp";
            this.tpnl_contain.SetRow(this.pnl_supp, 0);
            this.pnl_supp.Size = new System.Drawing.Size(399, 575);
            this.pnl_supp.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.datashowSpay);
            this.panel9.Controls.Add(this.pnl_b_supp);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 213);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(399, 362);
            this.panel9.TabIndex = 3;
            // 
            // datashowSpay
            // 
            this.datashowSpay.DataSource = typeof(MYSTORE.M_EntityFramework.Debtor);
            this.datashowSpay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datashowSpay.Location = new System.Drawing.Point(0, 0);
            this.datashowSpay.MainView = this.gridView2;
            this.datashowSpay.Name = "datashowSpay";
            this.datashowSpay.Size = new System.Drawing.Size(399, 295);
            this.datashowSpay.TabIndex = 0;
            this.datashowSpay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbatches1,
            this.colDate1});
            this.gridView2.GridControl = this.datashowSpay;
            this.gridView2.Name = "gridView2";
            // 
            // colbatches1
            // 
            this.colbatches1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbatches1.AppearanceCell.Options.UseFont = true;
            this.colbatches1.AppearanceCell.Options.UseTextOptions = true;
            this.colbatches1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbatches1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbatches1.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colbatches1.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbatches1.AppearanceHeader.Options.UseBackColor = true;
            this.colbatches1.AppearanceHeader.Options.UseFont = true;
            this.colbatches1.AppearanceHeader.Options.UseTextOptions = true;
            this.colbatches1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbatches1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbatches1.Caption = "الدفعة";
            this.colbatches1.FieldName = "batches";
            this.colbatches1.Name = "colbatches1";
            this.colbatches1.Visible = true;
            this.colbatches1.VisibleIndex = 0;
            // 
            // colDate1
            // 
            this.colDate1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDate1.AppearanceCell.Options.UseFont = true;
            this.colDate1.AppearanceCell.Options.UseTextOptions = true;
            this.colDate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate1.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colDate1.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDate1.AppearanceHeader.Options.UseBackColor = true;
            this.colDate1.AppearanceHeader.Options.UseFont = true;
            this.colDate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate1.Caption = "تاريخ الدفعة";
            this.colDate1.FieldName = "Date";
            this.colDate1.Name = "colDate1";
            this.colDate1.Visible = true;
            this.colDate1.VisibleIndex = 1;
            // 
            // pnl_b_supp
            // 
            this.pnl_b_supp.Controls.Add(this.tablePanel4);
            this.pnl_b_supp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_b_supp.Location = new System.Drawing.Point(0, 295);
            this.pnl_b_supp.Name = "pnl_b_supp";
            this.pnl_b_supp.Size = new System.Drawing.Size(399, 67);
            this.pnl_b_supp.TabIndex = 2;
            // 
            // tablePanel4
            // 
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 58.18F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 58.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 81.74F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6.6F)});
            this.tablePanel4.Controls.Add(this.btnADD1);
            this.tablePanel4.Controls.Add(this.label8);
            this.tablePanel4.Controls.Add(this.txtSpay);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(0, 0);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(399, 67);
            this.tablePanel4.TabIndex = 3;
            // 
            // btnADD1
            // 
            this.btnADD1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnADD1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tablePanel4.SetColumn(this.btnADD1, 1);
            this.btnADD1.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD1.ForeColor = System.Drawing.Color.White;
            this.btnADD1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD1.Location = new System.Drawing.Point(281, 7);
            this.btnADD1.Name = "btnADD1";
            this.tablePanel4.SetRow(this.btnADD1, 0);
            this.btnADD1.Size = new System.Drawing.Size(105, 53);
            this.btnADD1.TabIndex = 34;
            this.btnADD1.Text = "إضافة";
            this.btnADD1.UseVisualStyleBackColor = false;
            this.btnADD1.Click += new System.EventHandler(this.btnADD1_Click_1);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel4.SetColumn(this.label8, 2);
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(171, 11);
            this.label8.Name = "label8";
            this.tablePanel4.SetRow(this.label8, 0);
            this.label8.Size = new System.Drawing.Size(105, 44);
            this.label8.TabIndex = 9;
            this.label8.Text = "الدفعة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSpay
            // 
            this.txtSpay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpay.BorderColorFocused = System.Drawing.Color.Red;
            this.txtSpay.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtSpay.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtSpay.BorderThickness = 3;
            this.tablePanel4.SetColumn(this.txtSpay, 3);
            this.txtSpay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSpay.isPassword = false;
            this.txtSpay.Location = new System.Drawing.Point(17, 11);
            this.txtSpay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpay.Name = "txtSpay";
            this.tablePanel4.SetRow(this.txtSpay, 0);
            this.txtSpay.Size = new System.Drawing.Size(147, 44);
            this.txtSpay.TabIndex = 27;
            this.txtSpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpay_KeyDown);
            // 
            // pnl_inf_supp
            // 
            this.pnl_inf_supp.Controls.Add(this.txt_s_acc);
            this.pnl_inf_supp.Controls.Add(this.cmbsupp);
            this.pnl_inf_supp.Controls.Add(this.label10);
            this.pnl_inf_supp.Controls.Add(this.label6);
            this.pnl_inf_supp.Controls.Add(this.dateSpay);
            this.pnl_inf_supp.Controls.Add(this.label2);
            this.pnl_inf_supp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_inf_supp.Location = new System.Drawing.Point(0, 62);
            this.pnl_inf_supp.Name = "pnl_inf_supp";
            this.pnl_inf_supp.Size = new System.Drawing.Size(399, 151);
            this.pnl_inf_supp.TabIndex = 1;
            // 
            // txt_s_acc
            // 
            this.txt_s_acc.BorderColorFocused = System.Drawing.Color.Red;
            this.txt_s_acc.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txt_s_acc.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txt_s_acc.BorderThickness = 3;
            this.txt_s_acc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_s_acc.Enabled = false;
            this.txt_s_acc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_s_acc.isPassword = false;
            this.txt_s_acc.Location = new System.Drawing.Point(25, 100);
            this.txt_s_acc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_s_acc.Name = "txt_s_acc";
            this.txt_s_acc.Size = new System.Drawing.Size(139, 44);
            this.txt_s_acc.TabIndex = 29;
            this.txt_s_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbsupp
            // 
            this.cmbsupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbsupp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbsupp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbsupp.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsupp.FormattingEnabled = true;
            this.cmbsupp.Location = new System.Drawing.Point(200, 112);
            this.cmbsupp.Name = "cmbsupp";
            this.cmbsupp.Size = new System.Drawing.Size(178, 33);
            this.cmbsupp.TabIndex = 26;
            this.cmbsupp.SelectedIndexChanged += new System.EventHandler(this.cmbsupp_SelectedIndexChanged);
            this.cmbsupp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbsupp_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(288, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "اسم المورد";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(308, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "تاريخ الدفعة";
            // 
            // dateSpay
            // 
            this.dateSpay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateSpay.BackColor = System.Drawing.Color.DodgerBlue;
            this.dateSpay.BorderRadius = 0;
            this.dateSpay.ForeColor = System.Drawing.Color.White;
            this.dateSpay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSpay.FormatCustom = null;
            this.dateSpay.Location = new System.Drawing.Point(7, 36);
            this.dateSpay.Name = "dateSpay";
            this.dateSpay.Size = new System.Drawing.Size(389, 36);
            this.dateSpay.TabIndex = 24;
            this.dateSpay.Value = new System.DateTime(2022, 4, 12, 0, 15, 35, 351);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(60, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "رصيد المورد";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tablePanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 62);
            this.panel2.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel2.Controls.Add(this.lab_h_supp);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(399, 62);
            this.tablePanel2.TabIndex = 3;
            // 
            // lab_h_supp
            // 
            this.lab_h_supp.BackColor = System.Drawing.Color.White;
            this.tablePanel2.SetColumn(this.lab_h_supp, 0);
            this.lab_h_supp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_h_supp.Font = new System.Drawing.Font("Simplified Arabic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_h_supp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lab_h_supp.Location = new System.Drawing.Point(3, 0);
            this.lab_h_supp.Name = "lab_h_supp";
            this.tablePanel2.SetRow(this.lab_h_supp, 0);
            this.lab_h_supp.Size = new System.Drawing.Size(393, 62);
            this.lab_h_supp.TabIndex = 4;
            this.lab_h_supp.Text = "الدفعات إلى الموردين";
            this.lab_h_supp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_cust
            // 
            this.tpnl_contain.SetColumn(this.pnl_cust, 1);
            this.pnl_cust.Controls.Add(this.panel8);
            this.pnl_cust.Controls.Add(this.panel1);
            this.pnl_cust.Location = new System.Drawing.Point(3, 3);
            this.pnl_cust.Name = "pnl_cust";
            this.tpnl_contain.SetRow(this.pnl_cust, 0);
            this.pnl_cust.Size = new System.Drawing.Size(389, 575);
            this.pnl_cust.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.datashowCpay);
            this.panel8.Controls.Add(this.pnl_b_cust);
            this.panel8.Controls.Add(this.pnl_inf_cust);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(389, 513);
            this.panel8.TabIndex = 3;
            // 
            // datashowCpay
            // 
            this.datashowCpay.DataSource = typeof(MYSTORE.M_EntityFramework.Borrower);
            this.datashowCpay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datashowCpay.Location = new System.Drawing.Point(0, 151);
            this.datashowCpay.MainView = this.gridView1;
            this.datashowCpay.Name = "datashowCpay";
            this.datashowCpay.Size = new System.Drawing.Size(389, 295);
            this.datashowCpay.TabIndex = 0;
            this.datashowCpay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbatches,
            this.colDate});
            this.gridView1.GridControl = this.datashowCpay;
            this.gridView1.Name = "gridView1";
            // 
            // colbatches
            // 
            this.colbatches.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbatches.AppearanceCell.Options.UseFont = true;
            this.colbatches.AppearanceCell.Options.UseTextOptions = true;
            this.colbatches.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbatches.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbatches.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colbatches.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colbatches.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbatches.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colbatches.AppearanceHeader.Options.UseBackColor = true;
            this.colbatches.AppearanceHeader.Options.UseFont = true;
            this.colbatches.AppearanceHeader.Options.UseForeColor = true;
            this.colbatches.AppearanceHeader.Options.UseTextOptions = true;
            this.colbatches.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbatches.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colbatches.Caption = "الدفعة ";
            this.colbatches.FieldName = "batches";
            this.colbatches.Name = "colbatches";
            this.colbatches.Visible = true;
            this.colbatches.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDate.AppearanceCell.Options.UseFont = true;
            this.colDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colDate.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colDate.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDate.AppearanceHeader.Options.UseBackColor = true;
            this.colDate.AppearanceHeader.Options.UseFont = true;
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate.Caption = "تاريخ الدفعة";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // pnl_b_cust
            // 
            this.pnl_b_cust.Controls.Add(this.tablePanel3);
            this.pnl_b_cust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_b_cust.Location = new System.Drawing.Point(0, 446);
            this.pnl_b_cust.Name = "pnl_b_cust";
            this.pnl_b_cust.Size = new System.Drawing.Size(389, 67);
            this.pnl_b_cust.TabIndex = 2;
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 59.32F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 56.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 83.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5.8F)});
            this.tablePanel3.Controls.Add(this.btnADD);
            this.tablePanel3.Controls.Add(this.label7);
            this.tablePanel3.Controls.Add(this.txtCpay);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 0);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(389, 67);
            this.tablePanel3.TabIndex = 3;
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnADD.BackColor = System.Drawing.Color.DodgerBlue;
            this.tablePanel3.SetColumn(this.btnADD, 1);
            this.btnADD.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(273, 7);
            this.btnADD.Name = "btnADD";
            this.tablePanel3.SetRow(this.btnADD, 0);
            this.btnADD.Size = new System.Drawing.Size(104, 53);
            this.btnADD.TabIndex = 33;
            this.btnADD.Text = "إضافة";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel3.SetColumn(this.label7, 2);
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(168, 11);
            this.label7.Name = "label7";
            this.tablePanel3.SetRow(this.label7, 0);
            this.label7.Size = new System.Drawing.Size(99, 44);
            this.label7.TabIndex = 9;
            this.label7.Text = "الدفعة";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCpay
            // 
            this.txtCpay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpay.BorderColorFocused = System.Drawing.Color.Red;
            this.txtCpay.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtCpay.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtCpay.BorderThickness = 3;
            this.tablePanel3.SetColumn(this.txtCpay, 3);
            this.txtCpay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpay.isPassword = false;
            this.txtCpay.Location = new System.Drawing.Point(15, 11);
            this.txtCpay.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpay.Name = "txtCpay";
            this.tablePanel3.SetRow(this.txtCpay, 0);
            this.txtCpay.Size = new System.Drawing.Size(146, 44);
            this.txtCpay.TabIndex = 27;
            this.txtCpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpay.OnValueChanged += new System.EventHandler(this.txtCpay_OnValueChanged);
            this.txtCpay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpay_KeyDown);
            // 
            // pnl_inf_cust
            // 
            this.pnl_inf_cust.Controls.Add(this.txt_c_acc);
            this.pnl_inf_cust.Controls.Add(this.cmbcust);
            this.pnl_inf_cust.Controls.Add(this.label9);
            this.pnl_inf_cust.Controls.Add(this.label4);
            this.pnl_inf_cust.Controls.Add(this.dateCpay);
            this.pnl_inf_cust.Controls.Add(this.label5);
            this.pnl_inf_cust.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_inf_cust.Location = new System.Drawing.Point(0, 0);
            this.pnl_inf_cust.Name = "pnl_inf_cust";
            this.pnl_inf_cust.Size = new System.Drawing.Size(389, 151);
            this.pnl_inf_cust.TabIndex = 1;
            // 
            // txt_c_acc
            // 
            this.txt_c_acc.BorderColorFocused = System.Drawing.Color.Red;
            this.txt_c_acc.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txt_c_acc.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txt_c_acc.BorderThickness = 3;
            this.txt_c_acc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c_acc.Enabled = false;
            this.txt_c_acc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c_acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_c_acc.isPassword = false;
            this.txt_c_acc.Location = new System.Drawing.Point(20, 100);
            this.txt_c_acc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c_acc.Name = "txt_c_acc";
            this.txt_c_acc.Size = new System.Drawing.Size(141, 45);
            this.txt_c_acc.TabIndex = 28;
            this.txt_c_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbcust
            // 
            this.cmbcust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbcust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbcust.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcust.FormattingEnabled = true;
            this.cmbcust.Location = new System.Drawing.Point(207, 112);
            this.cmbcust.Name = "cmbcust";
            this.cmbcust.Size = new System.Drawing.Size(179, 33);
            this.cmbcust.TabIndex = 26;
            this.cmbcust.SelectedIndexChanged += new System.EventHandler(this.cmbcust_SelectedIndexChanged);
            this.cmbcust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcust_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(293, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "اسم الزبون";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(292, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "تاريخ الدفعة";
            // 
            // dateCpay
            // 
            this.dateCpay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCpay.BackColor = System.Drawing.Color.DodgerBlue;
            this.dateCpay.BorderRadius = 0;
            this.dateCpay.ForeColor = System.Drawing.Color.White;
            this.dateCpay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateCpay.FormatCustom = null;
            this.dateCpay.Location = new System.Drawing.Point(4, 36);
            this.dateCpay.Name = "dateCpay";
            this.dateCpay.Size = new System.Drawing.Size(382, 36);
            this.dateCpay.TabIndex = 24;
            this.dateCpay.Value = new System.DateTime(2022, 4, 12, 0, 15, 35, 351);
            this.dateCpay.onValueChanged += new System.EventHandler(this.dateCpay_onValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(47, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "رصيد الزبون";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 62);
            this.panel1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.lab_h_cust);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(389, 62);
            this.tablePanel1.TabIndex = 0;
            // 
            // lab_h_cust
            // 
            this.lab_h_cust.BackColor = System.Drawing.Color.White;
            this.tablePanel1.SetColumn(this.lab_h_cust, 0);
            this.lab_h_cust.Font = new System.Drawing.Font("Simplified Arabic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_h_cust.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lab_h_cust.Location = new System.Drawing.Point(3, 0);
            this.lab_h_cust.Name = "lab_h_cust";
            this.tablePanel1.SetRow(this.lab_h_cust, 0);
            this.lab_h_cust.Size = new System.Drawing.Size(383, 62);
            this.lab_h_cust.TabIndex = 4;
            this.lab_h_cust.Text = "الدفعات من الزبائن";
            this.lab_h_cust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.pnl_pay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Payment";
            this.ShowInTaskbar = false;
            this.Text = "frm_Payment";
            this.Activated += new System.EventHandler(this.frm_Payment_Activated);
            this.pnl_pay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpnl_contain)).EndInit();
            this.tpnl_contain.ResumeLayout(false);
            this.pnl_supp.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datashowSpay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.pnl_b_supp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.pnl_inf_supp.ResumeLayout(false);
            this.pnl_inf_supp.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.pnl_cust.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datashowCpay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_b_cust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.pnl_inf_cust.ResumeLayout(false);
            this.pnl_inf_cust.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_pay;
        private System.Windows.Forms.Panel pnl_supp;
        private System.Windows.Forms.Panel pnl_cust;
        private System.Windows.Forms.Panel pnl_b_supp;
        private System.Windows.Forms.Panel pnl_inf_supp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_b_cust;
        private System.Windows.Forms.Panel pnl_inf_cust;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_h_supp;
        private System.Windows.Forms.Label lab_h_cust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker dateSpay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dateCpay;
        private System.Windows.Forms.ComboBox cmbcust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cmbsupp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSpay;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCpay;
        private DevExpress.XtraGrid.GridControl datashowSpay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl datashowCpay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_s_acc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_c_acc;
        private DevExpress.XtraGrid.Columns.GridColumn colbatches;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colbatches1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate1;
        private DevExpress.Utils.Layout.TablePanel tpnl_contain;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnADD1;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}