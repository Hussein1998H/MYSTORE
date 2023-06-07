
namespace MYSTORE.UI_FORM
{
    partial class frm_setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_setting));
            this.pnl_setting = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRest = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.prg_pnl = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pic_logo = new DevExpress.XtraEditors.PictureEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_description = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_setting.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_setting
            // 
            this.pnl_setting.Controls.Add(this.panel2);
            this.pnl_setting.Controls.Add(this.panel1);
            this.pnl_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_setting.Location = new System.Drawing.Point(0, 0);
            this.pnl_setting.Name = "pnl_setting";
            this.pnl_setting.Size = new System.Drawing.Size(800, 581);
            this.pnl_setting.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl2);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 481);
            this.panel2.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.btnRest);
            this.groupControl2.Controls.Add(this.btnadd);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(0, 346);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(800, 135);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "النسخ الاحتياطي";
            // 
            // btnRest
            // 
            this.btnRest.AllowFocus = false;
            this.btnRest.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRest.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Appearance.Options.UseBackColor = true;
            this.btnRest.Appearance.Options.UseFont = true;
            this.btnRest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRest.ImageOptions.Image")));
            this.btnRest.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRest.Location = new System.Drawing.Point(37, 83);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(256, 46);
            this.btnRest.TabIndex = 21;
            this.btnRest.Text = "إستعادة النسخة الإحتياطية";
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnadd
            // 
            this.btnadd.AllowFocus = false;
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Appearance.Options.UseBackColor = true;
            this.btnadd.Appearance.Options.UseFont = true;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnadd.Location = new System.Drawing.Point(459, 83);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(256, 46);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "أخذ نسخة إحتياطية";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(281, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "ملاحظة: يجب تشغيل البرنامج كمسؤول";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.panel3);
            this.groupControl1.Controls.Add(this.pic_logo);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_description);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtname);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(800, 481);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "عام";
            // 
            // prg_pnl
            // 
            this.prg_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prg_pnl.Appearance.BackColor = System.Drawing.Color.White;
            this.prg_pnl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prg_pnl.Appearance.Options.UseBackColor = true;
            this.prg_pnl.Appearance.Options.UseFont = true;
            this.prg_pnl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prg_pnl.AppearanceCaption.Options.UseFont = true;
            this.prg_pnl.Location = new System.Drawing.Point(469, 6);
            this.prg_pnl.Name = "prg_pnl";
            this.prg_pnl.Size = new System.Drawing.Size(246, 66);
            this.prg_pnl.TabIndex = 22;
            this.prg_pnl.Visible = false;
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_logo.Location = new System.Drawing.Point(162, 146);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_logo.Size = new System.Drawing.Size(267, 206);
            this.pic_logo.TabIndex = 21;
            this.pic_logo.EditValueChanged += new System.EventHandler(this.pic_logo_EditValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(583, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "صورة الشركة";
            // 
            // txt_description
            // 
            this.txt_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_description.BackColor = System.Drawing.Color.White;
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_description.HintForeColor = System.Drawing.Color.Empty;
            this.txt_description.HintText = "";
            this.txt_description.isPassword = false;
            this.txt_description.LineFocusedColor = System.Drawing.Color.Lime;
            this.txt_description.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txt_description.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txt_description.LineThickness = 3;
            this.txt_description.Location = new System.Drawing.Point(59, 89);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(511, 50);
            this.txt_description.TabIndex = 18;
            this.txt_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(626, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "الوصف";
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtname.Location = new System.Drawing.Point(59, 31);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(511, 50);
            this.txtname.TabIndex = 16;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(607, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "اسم الشركة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prg_pnl);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowFocus = false;
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton2.Location = new System.Drawing.Point(24, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(256, 46);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "حفظ الإعدادات";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 121);
            this.panel3.TabIndex = 22;
            // 
            // frm_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.pnl_setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_setting";
            this.ShowInTaskbar = false;
            this.Text = "frm_setting";
            this.Load += new System.EventHandler(this.frm_setting_Load);
            this.pnl_setting.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_setting;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnRest;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        public DevExpress.XtraEditors.PictureEdit pic_logo;
        private DevExpress.XtraWaitForm.ProgressPanel prg_pnl;
        private System.Windows.Forms.Panel panel3;
    }
}