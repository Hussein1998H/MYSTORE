
namespace MYSTORE.UI_FORM
{
    partial class frm_inventory
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
            this.pnl_inventory = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNet_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtcapt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtgoods = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtowen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txthave = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txttpur = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txttsale = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtproft = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_inventory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_inventory
            // 
            this.pnl_inventory.Controls.Add(this.panel2);
            this.pnl_inventory.Controls.Add(this.tableLayoutPanel1);
            this.pnl_inventory.Controls.Add(this.panel1);
            this.pnl_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_inventory.Location = new System.Drawing.Point(0, 0);
            this.pnl_inventory.Name = "pnl_inventory";
            this.pnl_inventory.Size = new System.Drawing.Size(800, 581);
            this.pnl_inventory.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 201);
            this.panel2.TabIndex = 2;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = typeof(MYSTORE.M_EntityFramework.Product);
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(800, 201);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCategory,
            this.colQuantity,
            this.colNet_Price,
            this.colSale_price,
            this.colDate});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceCell.Options.UseTextOptions = true;
            this.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colName.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colName.AppearanceHeader.Options.UseBackColor = true;
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.AppearanceHeader.Options.UseForeColor = true;
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName.Caption = "التاريخ";
            this.colName.FieldName = "Date";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCategory
            // 
            this.colCategory.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategory.AppearanceCell.Options.UseFont = true;
            this.colCategory.AppearanceCell.Options.UseTextOptions = true;
            this.colCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCategory.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colCategory.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colCategory.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategory.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colCategory.AppearanceHeader.Options.UseBackColor = true;
            this.colCategory.AppearanceHeader.Options.UseFont = true;
            this.colCategory.AppearanceHeader.Options.UseForeColor = true;
            this.colCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCategory.Caption = "سعر المبيع";
            this.colCategory.FieldName = "Sale_price";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQuantity.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colQuantity.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Options.UseForeColor = true;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQuantity.Caption = "سعر الشراء";
            this.colQuantity.FieldName = "Net_Price";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colNet_Price
            // 
            this.colNet_Price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNet_Price.AppearanceCell.Options.UseFont = true;
            this.colNet_Price.AppearanceCell.Options.UseTextOptions = true;
            this.colNet_Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNet_Price.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNet_Price.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colNet_Price.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colNet_Price.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNet_Price.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colNet_Price.AppearanceHeader.Options.UseBackColor = true;
            this.colNet_Price.AppearanceHeader.Options.UseFont = true;
            this.colNet_Price.AppearanceHeader.Options.UseForeColor = true;
            this.colNet_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.colNet_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNet_Price.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNet_Price.Caption = "الكمية";
            this.colNet_Price.FieldName = "Quantity";
            this.colNet_Price.Name = "colNet_Price";
            this.colNet_Price.Visible = true;
            this.colNet_Price.VisibleIndex = 3;
            // 
            // colSale_price
            // 
            this.colSale_price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSale_price.AppearanceCell.Options.UseFont = true;
            this.colSale_price.AppearanceCell.Options.UseTextOptions = true;
            this.colSale_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSale_price.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSale_price.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colSale_price.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colSale_price.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSale_price.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSale_price.AppearanceHeader.Options.UseBackColor = true;
            this.colSale_price.AppearanceHeader.Options.UseFont = true;
            this.colSale_price.AppearanceHeader.Options.UseForeColor = true;
            this.colSale_price.AppearanceHeader.Options.UseTextOptions = true;
            this.colSale_price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSale_price.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSale_price.Caption = "الصنف";
            this.colSale_price.FieldName = "Category";
            this.colSale_price.Name = "colSale_price";
            this.colSale_price.Visible = true;
            this.colSale_price.VisibleIndex = 4;
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
            this.colDate.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colDate.AppearanceHeader.Options.UseBackColor = true;
            this.colDate.AppearanceHeader.Options.UseFont = true;
            this.colDate.AppearanceHeader.Options.UseForeColor = true;
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate.Caption = "اسم المادة";
            this.colDate.FieldName = "Name";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 343);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 238);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(MYSTORE.M_EntityFramework.Customer);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(394, 232);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colCompanyName,
            this.colAddress,
            this.colAccount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colName1
            // 
            this.colName1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName1.AppearanceCell.Options.UseFont = true;
            this.colName1.AppearanceCell.Options.UseTextOptions = true;
            this.colName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName1.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colName1.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colName1.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName1.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colName1.AppearanceHeader.Options.UseBackColor = true;
            this.colName1.AppearanceHeader.Options.UseFont = true;
            this.colName1.AppearanceHeader.Options.UseForeColor = true;
            this.colName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName1.Caption = "الرصيد";
            this.colName1.FieldName = "Account";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCompanyName.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colCompanyName.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCompanyName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colCompanyName.AppearanceHeader.Options.UseBackColor = true;
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Options.UseForeColor = true;
            this.colCompanyName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCompanyName.Caption = "العنوان";
            this.colCompanyName.FieldName = "Address";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colAddress.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colAddress.AppearanceHeader.Options.UseBackColor = true;
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Options.UseForeColor = true;
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress.Caption = "اسم الشركة";
            this.colAddress.FieldName = "CompanyName";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colAccount
            // 
            this.colAccount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAccount.AppearanceCell.Options.UseFont = true;
            this.colAccount.AppearanceCell.Options.UseTextOptions = true;
            this.colAccount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAccount.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colAccount.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colAccount.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAccount.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colAccount.AppearanceHeader.Options.UseBackColor = true;
            this.colAccount.AppearanceHeader.Options.UseFont = true;
            this.colAccount.AppearanceHeader.Options.UseForeColor = true;
            this.colAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAccount.Caption = "الاسم";
            this.colAccount.FieldName = "Name";
            this.colAccount.Name = "colAccount";
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 3;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = typeof(MYSTORE.M_EntityFramework.Suppoler);
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(403, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(394, 232);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName2,
            this.colCompanyName1,
            this.colAddress1,
            this.colAccount1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colName2
            // 
            this.colName2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName2.AppearanceCell.Options.UseFont = true;
            this.colName2.AppearanceCell.Options.UseTextOptions = true;
            this.colName2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName2.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colName2.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colName2.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName2.AppearanceHeader.Options.UseBackColor = true;
            this.colName2.AppearanceHeader.Options.UseFont = true;
            this.colName2.AppearanceHeader.Options.UseTextOptions = true;
            this.colName2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName2.Caption = "الرصيد";
            this.colName2.FieldName = "Account";
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 0;
            // 
            // colCompanyName1
            // 
            this.colCompanyName1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCompanyName1.AppearanceCell.Options.UseFont = true;
            this.colCompanyName1.AppearanceCell.Options.UseTextOptions = true;
            this.colCompanyName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyName1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCompanyName1.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colCompanyName1.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colCompanyName1.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCompanyName1.AppearanceHeader.Options.UseBackColor = true;
            this.colCompanyName1.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompanyName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompanyName1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCompanyName1.Caption = "العنوان";
            this.colCompanyName1.FieldName = "Address";
            this.colCompanyName1.Name = "colCompanyName1";
            this.colCompanyName1.Visible = true;
            this.colCompanyName1.VisibleIndex = 1;
            // 
            // colAddress1
            // 
            this.colAddress1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress1.AppearanceCell.Options.UseFont = true;
            this.colAddress1.AppearanceCell.Options.UseTextOptions = true;
            this.colAddress1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress1.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colAddress1.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colAddress1.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress1.AppearanceHeader.Options.UseBackColor = true;
            this.colAddress1.AppearanceHeader.Options.UseFont = true;
            this.colAddress1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress1.Caption = "اسم الشركة";
            this.colAddress1.FieldName = "CompanyName";
            this.colAddress1.Name = "colAddress1";
            this.colAddress1.Visible = true;
            this.colAddress1.VisibleIndex = 2;
            // 
            // colAccount1
            // 
            this.colAccount1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAccount1.AppearanceCell.Options.UseFont = true;
            this.colAccount1.AppearanceCell.Options.UseTextOptions = true;
            this.colAccount1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAccount1.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colAccount1.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.colAccount1.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAccount1.AppearanceHeader.Options.UseBackColor = true;
            this.colAccount1.AppearanceHeader.Options.UseFont = true;
            this.colAccount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAccount1.Caption = "الاسم";
            this.colAccount1.FieldName = "Name";
            this.colAccount1.Name = "colAccount1";
            this.colAccount1.Visible = true;
            this.colAccount1.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 142);
            this.panel1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 41.17F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43.37F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.66F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.49F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.32F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.59F)});
            this.tablePanel1.Controls.Add(this.txtcapt);
            this.tablePanel1.Controls.Add(this.txtgoods);
            this.tablePanel1.Controls.Add(this.txtowen);
            this.tablePanel1.Controls.Add(this.txthave);
            this.tablePanel1.Controls.Add(this.txttpur);
            this.tablePanel1.Controls.Add(this.txttsale);
            this.tablePanel1.Controls.Add(this.txtproft);
            this.tablePanel1.Controls.Add(this.label7);
            this.tablePanel1.Controls.Add(this.label6);
            this.tablePanel1.Controls.Add(this.label5);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 47F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(800, 142);
            this.tablePanel1.TabIndex = 0;
            // 
            // txtcapt
            // 
            this.txtcapt.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtcapt.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtcapt.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtcapt.BorderThickness = 3;
            this.tablePanel1.SetColumn(this.txtcapt, 0);
            this.txtcapt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcapt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcapt.Enabled = false;
            this.txtcapt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcapt.isPassword = false;
            this.txtcapt.Location = new System.Drawing.Point(694, 52);
            this.txtcapt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtcapt.Name = "txtcapt";
            this.tablePanel1.SetRow(this.txtcapt, 1);
            this.txtcapt.Size = new System.Drawing.Size(100, 85);
            this.txtcapt.TabIndex = 13;
            this.txtcapt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtgoods
            // 
            this.txtgoods.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtgoods.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtgoods.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtgoods.BorderThickness = 3;
            this.tablePanel1.SetColumn(this.txtgoods, 1);
            this.txtgoods.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtgoods.Enabled = false;
            this.txtgoods.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtgoods.isPassword = false;
            this.txtgoods.Location = new System.Drawing.Point(588, 52);
            this.txtgoods.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtgoods.Name = "txtgoods";
            this.tablePanel1.SetRow(this.txtgoods, 1);
            this.txtgoods.Size = new System.Drawing.Size(94, 85);
            this.txtgoods.TabIndex = 12;
            this.txtgoods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtowen
            // 
            this.txtowen.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtowen.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtowen.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtowen.BorderThickness = 3;
            this.tablePanel1.SetColumn(this.txtowen, 2);
            this.txtowen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtowen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtowen.Enabled = false;
            this.txtowen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtowen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtowen.isPassword = false;
            this.txtowen.Location = new System.Drawing.Point(476, 52);
            this.txtowen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtowen.Name = "txtowen";
            this.tablePanel1.SetRow(this.txtowen, 1);
            this.txtowen.Size = new System.Drawing.Size(100, 85);
            this.txtowen.TabIndex = 11;
            this.txtowen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthave
            // 
            this.txthave.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txthave.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txthave.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txthave.BorderThickness = 3;
            this.tablePanel1.SetColumn(this.txthave, 3);
            this.txthave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txthave.Enabled = false;
            this.txthave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txthave.isPassword = false;
            this.txthave.Location = new System.Drawing.Point(353, 52);
            this.txthave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txthave.Name = "txthave";
            this.tablePanel1.SetRow(this.txthave, 1);
            this.txthave.Size = new System.Drawing.Size(111, 85);
            this.txthave.TabIndex = 10;
            this.txthave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttpur
            // 
            this.txttpur.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txttpur.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txttpur.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txttpur.BorderThickness = 3;
            this.tablePanel1.SetColumn(this.txttpur, 4);
            this.txttpur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttpur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttpur.Enabled = false;
            this.txttpur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttpur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttpur.isPassword = false;
            this.txttpur.Location = new System.Drawing.Point(233, 52);
            this.txttpur.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txttpur.Name = "txttpur";
            this.tablePanel1.SetRow(this.txttpur, 1);
            this.txttpur.Size = new System.Drawing.Size(108, 85);
            this.txttpur.TabIndex = 9;
            this.txttpur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttsale
            // 
            this.txttsale.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txttsale.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txttsale.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txttsale.BorderThickness = 3;
            this.tablePanel1.SetColumn(this.txttsale, 5);
            this.txttsale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttsale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttsale.Enabled = false;
            this.txttsale.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttsale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttsale.isPassword = false;
            this.txttsale.Location = new System.Drawing.Point(116, 52);
            this.txttsale.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txttsale.Name = "txttsale";
            this.tablePanel1.SetRow(this.txttsale, 1);
            this.txttsale.Size = new System.Drawing.Size(105, 85);
            this.txttsale.TabIndex = 8;
            this.txttsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproft
            // 
            this.txtproft.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtproft.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtproft.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtproft.BorderThickness = 3;
            this.tablePanel1.SetColumn(this.txtproft, 6);
            this.txtproft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtproft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtproft.Enabled = false;
            this.txtproft.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtproft.isPassword = false;
            this.txtproft.Location = new System.Drawing.Point(6, 52);
            this.txtproft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtproft.Name = "txtproft";
            this.tablePanel1.SetRow(this.txtproft, 1);
            this.txtproft.Size = new System.Drawing.Size(98, 85);
            this.txtproft.TabIndex = 7;
            this.txtproft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tablePanel1.SetColumn(this.label7, 0);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(691, 0);
            this.label7.Name = "label7";
            this.tablePanel1.SetRow(this.label7, 0);
            this.label7.Size = new System.Drawing.Size(106, 47);
            this.label7.TabIndex = 6;
            this.label7.Text = "رأس المال";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tablePanel1.SetColumn(this.label6, 1);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(585, 0);
            this.label6.Name = "label6";
            this.tablePanel1.SetRow(this.label6, 0);
            this.label6.Size = new System.Drawing.Size(100, 47);
            this.label6.TabIndex = 5;
            this.label6.Text = "مجموع البضائع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tablePanel1.SetColumn(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(473, 0);
            this.label5.Name = "label5";
            this.tablePanel1.SetRow(this.label5, 0);
            this.label5.Size = new System.Drawing.Size(106, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "مجموع الديون التي علي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tablePanel1.SetColumn(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(350, 0);
            this.label4.Name = "label4";
            this.tablePanel1.SetRow(this.label4, 0);
            this.label4.Size = new System.Drawing.Size(117, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "مجموع الديون التي لي";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 4);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(230, 0);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(114, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "مجموع المشتريات";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 5);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(113, 0);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(111, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "مجموع المبيعات";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 6);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(104, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "الأرباح";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.pnl_inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inventory";
            this.ShowInTaskbar = false;
            this.Text = "frm_inventory";
            this.pnl_inventory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtproft;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttsale;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttpur;
        private Bunifu.Framework.UI.BunifuMetroTextbox txthave;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtowen;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtgoods;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcapt;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNet_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_price;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount1;
        public System.Windows.Forms.Panel pnl_inventory;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}