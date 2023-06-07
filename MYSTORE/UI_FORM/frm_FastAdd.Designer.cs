
namespace MYSTORE.UI_FORM
{
    partial class frm_FastAdd
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
            this.txtcat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsaleprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnetprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dateprod = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcat
            // 
            this.txtcat.BackColor = System.Drawing.Color.White;
            this.txtcat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcat.HintForeColor = System.Drawing.Color.Empty;
            this.txtcat.HintText = "";
            this.txtcat.isPassword = false;
            this.txtcat.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtcat.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtcat.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtcat.LineThickness = 3;
            this.txtcat.Location = new System.Drawing.Point(13, 37);
            this.txtcat.Margin = new System.Windows.Forms.Padding(4);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(275, 41);
            this.txtcat.TabIndex = 6;
            this.txtcat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcat_KeyDown);
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
            this.txtname.Location = new System.Drawing.Point(330, 37);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(275, 41);
            this.txtname.TabIndex = 7;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // txtsaleprice
            // 
            this.txtsaleprice.BackColor = System.Drawing.Color.White;
            this.txtsaleprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsaleprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaleprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsaleprice.HintForeColor = System.Drawing.Color.Empty;
            this.txtsaleprice.HintText = "";
            this.txtsaleprice.isPassword = false;
            this.txtsaleprice.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtsaleprice.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtsaleprice.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtsaleprice.LineThickness = 3;
            this.txtsaleprice.Location = new System.Drawing.Point(13, 161);
            this.txtsaleprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtsaleprice.Name = "txtsaleprice";
            this.txtsaleprice.Size = new System.Drawing.Size(275, 41);
            this.txtsaleprice.TabIndex = 8;
            this.txtsaleprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsaleprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsaleprice_KeyDown);
            // 
            // txtnetprice
            // 
            this.txtnetprice.BackColor = System.Drawing.Color.White;
            this.txtnetprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnetprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnetprice.HintForeColor = System.Drawing.Color.Empty;
            this.txtnetprice.HintText = "";
            this.txtnetprice.isPassword = false;
            this.txtnetprice.LineFocusedColor = System.Drawing.Color.Lime;
            this.txtnetprice.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtnetprice.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtnetprice.LineThickness = 3;
            this.txtnetprice.Location = new System.Drawing.Point(330, 161);
            this.txtnetprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtnetprice.Name = "txtnetprice";
            this.txtnetprice.Size = new System.Drawing.Size(275, 41);
            this.txtnetprice.TabIndex = 9;
            this.txtnetprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnetprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnetprice_KeyDown);
            // 
            // dateprod
            // 
            this.dateprod.BackColor = System.Drawing.Color.DodgerBlue;
            this.dateprod.BorderRadius = 0;
            this.dateprod.ForeColor = System.Drawing.Color.White;
            this.dateprod.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateprod.FormatCustom = null;
            this.dateprod.Location = new System.Drawing.Point(323, 284);
            this.dateprod.Name = "dateprod";
            this.dateprod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateprod.Size = new System.Drawing.Size(283, 36);
            this.dateprod.TabIndex = 10;
            this.dateprod.Value = new System.DateTime(2022, 4, 12, 0, 15, 35, 351);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(551, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "التاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(205, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "سعر المبيع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(231, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(520, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "سعر الشراء";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(524, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "اسم المنتج";
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnADD.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(23, 284);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(100, 53);
            this.btnADD.TabIndex = 32;
            this.btnADD.Text = "إضافة";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // frm_FastAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 374);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsaleprice);
            this.Controls.Add(this.txtnetprice);
            this.Controls.Add(this.dateprod);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_FastAdd";
            this.Text = "الإضافة السريعة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsaleprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnetprice;
        private Bunifu.Framework.UI.BunifuDatepicker dateprod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADD;
    }
}