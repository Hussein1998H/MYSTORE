
namespace MYSTORE.UI_FORM
{
    partial class frm_Sale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sale));
            this.pnl_sale = new System.Windows.Forms.Panel();
            this.pnlP = new System.Windows.Forms.Panel();
            this.datashowdet1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnl_c_top = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtcat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtsaleprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdisc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtaqty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbprod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtcust1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.datenow = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_colaps = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_down = new System.Windows.Forms.Panel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_sale.SuspendLayout();
            this.pnlP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datashowdet1)).BeginInit();
            this.pnl_c_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_down.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sale
            // 
            this.pnl_sale.Controls.Add(this.pnlP);
            this.pnl_sale.Controls.Add(this.pnl_c_top);
            this.pnl_sale.Controls.Add(this.pnl_down);
            this.pnl_sale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_sale.Location = new System.Drawing.Point(0, 0);
            this.pnl_sale.Name = "pnl_sale";
            this.pnl_sale.Size = new System.Drawing.Size(800, 581);
            this.pnl_sale.TabIndex = 4;
            // 
            // pnlP
            // 
            this.pnlP.Controls.Add(this.datashowdet1);
            this.pnlP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP.Location = new System.Drawing.Point(0, 275);
            this.pnlP.Name = "pnlP";
            this.pnlP.Size = new System.Drawing.Size(800, 251);
            this.pnlP.TabIndex = 2;
            // 
            // datashowdet1
            // 
            this.datashowdet1.AllowUserToAddRows = false;
            this.datashowdet1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datashowdet1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datashowdet1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datashowdet1.BackgroundColor = System.Drawing.Color.White;
            this.datashowdet1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datashowdet1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datashowdet1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datashowdet1.ColumnHeadersHeight = 50;
            this.datashowdet1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datashowdet1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this._NAME,
            this.CAT,
            this.PRICE,
            this.QTY,
            this.QANTITY,
            this.DIS,
            this.TOTAL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datashowdet1.DefaultCellStyle = dataGridViewCellStyle3;
            this.datashowdet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datashowdet1.DoubleBuffered = true;
            this.datashowdet1.EnableHeadersVisualStyles = false;
            this.datashowdet1.GridColor = System.Drawing.Color.White;
            this.datashowdet1.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.datashowdet1.HeaderForeColor = System.Drawing.Color.White;
            this.datashowdet1.Location = new System.Drawing.Point(0, 0);
            this.datashowdet1.Name = "datashowdet1";
            this.datashowdet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datashowdet1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datashowdet1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datashowdet1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datashowdet1.Size = new System.Drawing.Size(800, 251);
            this.datashowdet1.TabIndex = 2;
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
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tablePanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(20, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 255);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.52F)});
            this.tablePanel2.Controls.Add(this.panel7);
            this.tablePanel2.Controls.Add(this.panel3);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(2, 23);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(776, 230);
            this.tablePanel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.tablePanel2.SetColumn(this.panel7, 0);
            this.panel7.Controls.Add(this.tablePanel1);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(346, 3);
            this.panel7.Name = "panel7";
            this.tablePanel2.SetRow(this.panel7, 0);
            this.panel7.Size = new System.Drawing.Size(427, 224);
            this.panel7.TabIndex = 27;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.7F)});
            this.tablePanel1.Controls.Add(this.panel6);
            this.tablePanel1.Controls.Add(this.panel5);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 82);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(427, 142);
            this.tablePanel1.TabIndex = 25;
            // 
            // panel6
            // 
            this.tablePanel1.SetColumn(this.panel6, 0);
            this.panel6.Controls.Add(this.txtcat);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtqty);
            this.panel6.Location = new System.Drawing.Point(221, 3);
            this.panel6.Name = "panel6";
            this.tablePanel1.SetRow(this.panel6, 0);
            this.panel6.Size = new System.Drawing.Size(203, 136);
            this.panel6.TabIndex = 26;
            // 
            // txtcat
            // 
            this.txtcat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcat.BackColor = System.Drawing.Color.White;
            this.txtcat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcat.HintForeColor = System.Drawing.Color.Empty;
            this.txtcat.HintText = "";
            this.txtcat.isPassword = false;
            this.txtcat.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtcat.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtcat.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtcat.LineThickness = 4;
            this.txtcat.Location = new System.Drawing.Point(4, 23);
            this.txtcat.Margin = new System.Windows.Forms.Padding(4);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(180, 38);
            this.txtcat.TabIndex = 19;
            this.txtcat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcat_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(133, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "الكمية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(133, -9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "الصنف";
            // 
            // txtqty
            // 
            this.txtqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtqty.BackColor = System.Drawing.Color.White;
            this.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqty.HintForeColor = System.Drawing.Color.Empty;
            this.txtqty.HintText = "";
            this.txtqty.isPassword = false;
            this.txtqty.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtqty.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtqty.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtqty.LineThickness = 4;
            this.txtqty.Location = new System.Drawing.Point(5, 94);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(179, 38);
            this.txtqty.TabIndex = 18;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            // 
            // panel5
            // 
            this.tablePanel1.SetColumn(this.panel5, 1);
            this.panel5.Controls.Add(this.txtsaleprice);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtdisc);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.tablePanel1.SetRow(this.panel5, 0);
            this.panel5.Size = new System.Drawing.Size(212, 136);
            this.panel5.TabIndex = 25;
            // 
            // txtsaleprice
            // 
            this.txtsaleprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsaleprice.BackColor = System.Drawing.Color.White;
            this.txtsaleprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsaleprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaleprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsaleprice.HintForeColor = System.Drawing.Color.Empty;
            this.txtsaleprice.HintText = "";
            this.txtsaleprice.isPassword = false;
            this.txtsaleprice.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtsaleprice.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtsaleprice.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtsaleprice.LineThickness = 4;
            this.txtsaleprice.Location = new System.Drawing.Point(4, 28);
            this.txtsaleprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtsaleprice.Name = "txtsaleprice";
            this.txtsaleprice.Size = new System.Drawing.Size(180, 38);
            this.txtsaleprice.TabIndex = 20;
            this.txtsaleprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsaleprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsaleprice_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(124, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "الخصم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(110, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "سعر المبيع";
            // 
            // txtdisc
            // 
            this.txtdisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdisc.BackColor = System.Drawing.Color.White;
            this.txtdisc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdisc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdisc.HintForeColor = System.Drawing.Color.Empty;
            this.txtdisc.HintText = "";
            this.txtdisc.isPassword = false;
            this.txtdisc.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtdisc.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtdisc.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtdisc.LineThickness = 4;
            this.txtdisc.Location = new System.Drawing.Point(7, 94);
            this.txtdisc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(180, 38);
            this.txtdisc.TabIndex = 21;
            this.txtdisc.Text = "0";
            this.txtdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdisc_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtaqty);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbprod);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 82);
            this.panel4.TabIndex = 24;
            // 
            // txtaqty
            // 
            this.txtaqty.BackColor = System.Drawing.Color.White;
            this.txtaqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaqty.Enabled = false;
            this.txtaqty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaqty.HintForeColor = System.Drawing.Color.Empty;
            this.txtaqty.HintText = "";
            this.txtaqty.isPassword = false;
            this.txtaqty.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtaqty.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtaqty.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtaqty.LineThickness = 4;
            this.txtaqty.Location = new System.Drawing.Point(10, 40);
            this.txtaqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtaqty.Name = "txtaqty";
            this.txtaqty.Size = new System.Drawing.Size(95, 38);
            this.txtaqty.TabIndex = 21;
            this.txtaqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(330, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المنتج";
            // 
            // cmbprod
            // 
            this.cmbprod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbprod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbprod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbprod.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbprod.FormattingEnabled = true;
            this.cmbprod.Location = new System.Drawing.Point(214, 40);
            this.cmbprod.Name = "cmbprod";
            this.cmbprod.Size = new System.Drawing.Size(199, 33);
            this.cmbprod.TabIndex = 11;
            this.cmbprod.SelectedIndexChanged += new System.EventHandler(this.cmbprod_SelectedIndexChanged);
            this.cmbprod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbprod_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(14, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "الكمية الكلية";
            // 
            // panel3
            // 
            this.tablePanel2.SetColumn(this.panel3, 1);
            this.panel3.Controls.Add(this.btnADD);
            this.panel3.Controls.Add(this.txtcust1);
            this.panel3.Controls.Add(this.datenow);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnrefresh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.tablePanel2.SetRow(this.panel3, 0);
            this.panel3.Size = new System.Drawing.Size(337, 224);
            this.panel3.TabIndex = 24;
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnADD.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnADD.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(54, 171);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(100, 53);
            this.btnADD.TabIndex = 31;
            this.btnADD.Text = "إضافة";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtcust1
            // 
            this.txtcust1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcust1.BorderColorFocused = System.Drawing.Color.Red;
            this.txtcust1.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtcust1.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtcust1.BorderThickness = 3;
            this.txtcust1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcust1.Enabled = false;
            this.txtcust1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcust1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcust1.isPassword = false;
            this.txtcust1.Location = new System.Drawing.Point(38, 32);
            this.txtcust1.Margin = new System.Windows.Forms.Padding(4);
            this.txtcust1.Name = "txtcust1";
            this.txtcust1.Size = new System.Drawing.Size(268, 41);
            this.txtcust1.TabIndex = 28;
            this.txtcust1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datenow
            // 
            this.datenow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datenow.BackColor = System.Drawing.Color.DodgerBlue;
            this.datenow.BorderRadius = 0;
            this.datenow.ForeColor = System.Drawing.Color.White;
            this.datenow.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datenow.FormatCustom = null;
            this.datenow.Location = new System.Drawing.Point(28, 113);
            this.datenow.Name = "datenow";
            this.datenow.Size = new System.Drawing.Size(278, 36);
            this.datenow.TabIndex = 22;
            this.datenow.Value = new System.DateTime(2022, 4, 12, 0, 15, 35, 351);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(246, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(231, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "اسم الزبون";
            // 
            // btnrefresh
            // 
            this.btnrefresh.AllowFocus = false;
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnrefresh.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnrefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Appearance.Options.UseBackColor = true;
            this.btnrefresh.Appearance.Options.UseFont = true;
            this.btnrefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.ImageOptions.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(9, 174);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(39, 46);
            this.btnrefresh.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 20);
            this.panel2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(0, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(20, 20);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
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
            // btn_colaps
            // 
            this.btn_colaps.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_colaps.ImageOptions.Image")));
            this.btn_colaps.Location = new System.Drawing.Point(0, 255);
            this.btn_colaps.Name = "btn_colaps";
            this.btn_colaps.Size = new System.Drawing.Size(20, 20);
            this.btn_colaps.TabIndex = 2;
            this.btn_colaps.Click += new System.EventHandler(this.btn_colaps_Click);
            // 
            // pnl_down
            // 
            this.pnl_down.Controls.Add(this.tablePanel3);
            this.pnl_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_down.Location = new System.Drawing.Point(0, 526);
            this.pnl_down.Name = "pnl_down";
            this.pnl_down.Size = new System.Drawing.Size(800, 55);
            this.pnl_down.TabIndex = 0;
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 7.34F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 61.66F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 53.6F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 54.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 7.49F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.96F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 111.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 13.1F)});
            this.tablePanel3.Controls.Add(this.btnPrint);
            this.tablePanel3.Controls.Add(this.label8);
            this.tablePanel3.Controls.Add(this.txtsum);
            this.tablePanel3.Controls.Add(this.btn_save);
            this.tablePanel3.Controls.Add(this.simpleButton1);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 0);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(800, 55);
            this.tablePanel3.TabIndex = 29;
            // 
            // btnPrint
            // 
            this.btnPrint.AllowFocus = false;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseBackColor = true;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.tablePanel3.SetColumn(this.btnPrint, 3);
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(411, 4);
            this.btnPrint.Name = "btnPrint";
            this.tablePanel3.SetRow(this.btnPrint, 0);
            this.btnPrint.Size = new System.Drawing.Size(114, 46);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel3.SetColumn(this.label8, 5);
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(281, 8);
            this.label8.Name = "label8";
            this.tablePanel3.SetRow(this.label8, 0);
            this.label8.Size = new System.Drawing.Size(107, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "المجموع";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsum
            // 
            this.txtsum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsum.BorderColorFocused = System.Drawing.Color.Red;
            this.txtsum.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txtsum.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtsum.BorderThickness = 3;
            this.tablePanel3.SetColumn(this.txtsum, 6);
            this.txtsum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsum.Enabled = false;
            this.txtsum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsum.isPassword = false;
            this.txtsum.Location = new System.Drawing.Point(34, 4);
            this.txtsum.Margin = new System.Windows.Forms.Padding(4);
            this.txtsum.Name = "txtsum";
            this.tablePanel3.SetRow(this.txtsum, 0);
            this.txtsum.Size = new System.Drawing.Size(240, 47);
            this.txtsum.TabIndex = 26;
            this.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_save
            // 
            this.btn_save.AllowFocus = false;
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseBackColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.tablePanel3.SetColumn(this.btn_save, 1);
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(650, 4);
            this.btn_save.Name = "btn_save";
            this.tablePanel3.SetRow(this.btn_save, 0);
            this.btn_save.Size = new System.Drawing.Size(131, 46);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.tablePanel3.SetColumn(this.simpleButton1, 2);
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(531, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel3.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(113, 46);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "إلغاء";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "الرقم التسلسلي";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // _NAME
            // 
            this._NAME.HeaderText = "اسم المنتج";
            this._NAME.Name = "_NAME";
            this._NAME.ReadOnly = true;
            // 
            // CAT
            // 
            this.CAT.HeaderText = "الصنف";
            this.CAT.Name = "CAT";
            this.CAT.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "سعر المبيع";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "ALL QUANTITY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Visible = false;
            // 
            // QANTITY
            // 
            this.QANTITY.HeaderText = "الكمية";
            this.QANTITY.Name = "QANTITY";
            this.QANTITY.ReadOnly = true;
            // 
            // DIS
            // 
            this.DIS.HeaderText = "الخصم";
            this.DIS.Name = "DIS";
            this.DIS.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "المجموع";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frm_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.pnl_sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Sale";
            this.ShowInTaskbar = false;
            this.Text = "frm_Sale";
            this.Resize += new System.EventHandler(this.frm_Sale_Resize);
            this.pnl_sale.ResumeLayout(false);
            this.pnlP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datashowdet1)).EndInit();
            this.pnl_c_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_down.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnl_sale;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datashowdet1;
        private System.Windows.Forms.Panel pnl_c_top;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnrefresh;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtqty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsaleprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdisc;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtaqty;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker datenow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_colaps;
        private System.Windows.Forms.Panel pnl_down;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsum;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtcust1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlP;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnADD;
        public System.Windows.Forms.ComboBox cmbprod;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn QANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}