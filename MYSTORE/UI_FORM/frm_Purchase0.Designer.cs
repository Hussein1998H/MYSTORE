
namespace MYSTORE.UI_FORM
{
    partial class frm_Purchase0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Purchase0));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_c_top = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbsupp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPur_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_Pinvoice = new DevExpress.XtraGrid.GridControl();
            this.pnl_Pinvoice = new System.Windows.Forms.Panel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_c_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pinvoice)).BeginInit();
            this.pnl_Pinvoice.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 162);
            this.panel2.TabIndex = 1;
            // 
            // pnl_c_top
            // 
            this.pnl_c_top.Controls.Add(this.groupControl1);
            this.pnl_c_top.Controls.Add(this.panel2);
            this.pnl_c_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_c_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_c_top.Name = "pnl_c_top";
            this.pnl_c_top.Size = new System.Drawing.Size(800, 245);
            this.pnl_c_top.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtsum);
            this.groupControl1.Controls.Add(this.cmbsupp);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 162);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 83);
            this.groupControl1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(140, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 35);
            this.label8.TabIndex = 31;
            this.label8.Text = "مجموع الفواتير الكلي";
            // 
            // txtsum
            // 
            this.txtsum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtsum.BorderColorFocused = System.Drawing.Color.Red;
            this.txtsum.BorderColorIdle = System.Drawing.Color.Brown;
            this.txtsum.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtsum.BorderThickness = 3;
            this.txtsum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsum.Enabled = false;
            this.txtsum.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsum.isPassword = false;
            this.txtsum.Location = new System.Drawing.Point(6, 23);
            this.txtsum.Margin = new System.Windows.Forms.Padding(4);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(127, 44);
            this.txtsum.TabIndex = 30;
            this.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbsupp
            // 
            this.cmbsupp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbsupp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbsupp.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsupp.FormattingEnabled = true;
            this.cmbsupp.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.cmbsupp.Location = new System.Drawing.Point(427, 25);
            this.cmbsupp.Name = "cmbsupp";
            this.cmbsupp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbsupp.Size = new System.Drawing.Size(247, 33);
            this.cmbsupp.TabIndex = 27;
            this.cmbsupp.SelectedIndexChanged += new System.EventHandler(this.cmbsupp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(680, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "اسم المورد";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPur_ID,
            this.colDate,
            this.colTotalPrice});
            this.gridView1.GridControl = this.grid_Pinvoice;
            this.gridView1.Name = "gridView1";
            // 
            // colPur_ID
            // 
            this.colPur_ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPur_ID.AppearanceCell.Options.UseFont = true;
            this.colPur_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colPur_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPur_ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPur_ID.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colPur_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPur_ID.AppearanceHeader.Options.UseBackColor = true;
            this.colPur_ID.AppearanceHeader.Options.UseFont = true;
            this.colPur_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPur_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPur_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPur_ID.Caption = "قيمة الفاتورة";
            this.colPur_ID.FieldName = "TotalPrice";
            this.colPur_ID.Name = "colPur_ID";
            this.colPur_ID.Visible = true;
            this.colPur_ID.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDate.AppearanceCell.Options.UseFont = true;
            this.colDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colDate.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDate.AppearanceHeader.Options.UseBackColor = true;
            this.colDate.AppearanceHeader.Options.UseFont = true;
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDate.Caption = "تاريخ الشراء";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotalPrice.AppearanceCell.Options.UseFont = true;
            this.colTotalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalPrice.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.colTotalPrice.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTotalPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colTotalPrice.AppearanceHeader.Options.UseFont = true;
            this.colTotalPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTotalPrice.Caption = "رقم الفاتورة";
            this.colTotalPrice.FieldName = "Pur_ID";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            // 
            // grid_Pinvoice
            // 
            this.grid_Pinvoice.DataSource = typeof(MYSTORE.M_EntityFramework.purchase);
            this.grid_Pinvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Pinvoice.Location = new System.Drawing.Point(0, 245);
            this.grid_Pinvoice.MainView = this.gridView1;
            this.grid_Pinvoice.Name = "grid_Pinvoice";
            this.grid_Pinvoice.Size = new System.Drawing.Size(800, 281);
            this.grid_Pinvoice.TabIndex = 2;
            this.grid_Pinvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pnl_Pinvoice
            // 
            this.pnl_Pinvoice.Controls.Add(this.grid_Pinvoice);
            this.pnl_Pinvoice.Controls.Add(this.pnl_c_top);
            this.pnl_Pinvoice.Controls.Add(this.pnl_buttons);
            this.pnl_Pinvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Pinvoice.Location = new System.Drawing.Point(0, 0);
            this.pnl_Pinvoice.Name = "pnl_Pinvoice";
            this.pnl_Pinvoice.Size = new System.Drawing.Size(800, 581);
            this.pnl_Pinvoice.TabIndex = 5;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_add);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 526);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(800, 55);
            this.pnl_buttons.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.AllowFocus = false;
            this.btn_add.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(12, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(167, 46);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "إضافة فاتورة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // frm_Purchase0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.pnl_Pinvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Purchase0";
            this.ShowInTaskbar = false;
            this.Text = "frm_Purchase0";
            this.pnl_c_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pinvoice)).EndInit();
            this.pnl_Pinvoice.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_c_top;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbsupp;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_Pinvoice;
        public System.Windows.Forms.Panel pnl_Pinvoice;
        private System.Windows.Forms.Panel pnl_buttons;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsum;
    }
}