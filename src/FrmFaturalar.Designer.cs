namespace SarkuteriOtomasyonu
{
    partial class FrmFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnbul = new DevExpress.XtraEditors.SimpleButton();
            this.txturunad = new DevExpress.XtraEditors.TextEdit();
            this.txtmiktar = new DevExpress.XtraEditors.TextEdit();
            this.txtfiyat = new DevExpress.XtraEditors.TextEdit();
            this.txttutar = new DevExpress.XtraEditors.TextEdit();
            this.txturunid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(436, 561);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.simpleButton2);
            this.groupControl5.Controls.Add(this.label2);
            this.groupControl5.Controls.Add(this.label1);
            this.groupControl5.Controls.Add(this.simpleButton1);
            this.groupControl5.Controls.Add(this.BtnTemizle);
            this.groupControl5.Controls.Add(this.BtnSil);
            this.groupControl5.Controls.Add(this.btnbul);
            this.groupControl5.Controls.Add(this.txturunad);
            this.groupControl5.Controls.Add(this.txtmiktar);
            this.groupControl5.Controls.Add(this.txtfiyat);
            this.groupControl5.Controls.Add(this.txttutar);
            this.groupControl5.Controls.Add(this.txturunid);
            this.groupControl5.Controls.Add(this.labelControl4);
            this.groupControl5.Controls.Add(this.BtnKaydet);
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.labelControl8);
            this.groupControl5.Controls.Add(this.labelControl11);
            this.groupControl5.Controls.Add(this.labelControl9);
            this.groupControl5.Location = new System.Drawing.Point(444, 2);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(307, 549);
            this.groupControl5.TabIndex = 11;
            this.groupControl5.Text = "groupControl5";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(103, 391);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(151, 35);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "LİSTEYİ TEMİZLE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.Location = new System.Drawing.Point(37, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "TOPLAM TUTAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label1.Location = new System.Drawing.Point(201, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "00 TL";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(103, 350);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 35);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "FİŞ YAZDIR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(103, 309);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(151, 35);
            this.BtnTemizle.TabIndex = 7;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click_1);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(103, 268);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(151, 35);
            this.BtnSil.TabIndex = 6;
            this.BtnSil.Text = "İDAE";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // btnbul
            // 
            this.btnbul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbul.ImageOptions.Image")));
            this.btnbul.Location = new System.Drawing.Point(204, 23);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(59, 21);
            this.btnbul.TabIndex = 20;
            this.btnbul.Text = "BUL";
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(112, 50);
            this.txturunad.Name = "txturunad";
            this.txturunad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txturunad.Properties.Appearance.Options.UseFont = true;
            this.txturunad.Size = new System.Drawing.Size(151, 24);
            this.txturunad.TabIndex = 2;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(112, 80);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtmiktar.Properties.Appearance.Options.UseFont = true;
            this.txtmiktar.Size = new System.Drawing.Size(151, 24);
            this.txtmiktar.TabIndex = 11;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(112, 111);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtfiyat.Properties.Appearance.Options.UseFont = true;
            this.txtfiyat.Size = new System.Drawing.Size(151, 24);
            this.txtfiyat.TabIndex = 3;
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(112, 141);
            this.txttutar.Name = "txttutar";
            this.txttutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txttutar.Properties.Appearance.Options.UseFont = true;
            this.txttutar.Size = new System.Drawing.Size(151, 24);
            this.txttutar.TabIndex = 4;
            // 
            // txturunid
            // 
            this.txturunid.Location = new System.Drawing.Point(112, 20);
            this.txturunid.Name = "txturunid";
            this.txturunid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txturunid.Properties.Appearance.Options.UseFont = true;
            this.txturunid.Size = new System.Drawing.Size(86, 24);
            this.txturunid.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(53, 144);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 18);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "TUTAR:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(103, 227);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(151, 35);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click_1);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(40, 23);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "ÜRÜN ID:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(34, 53);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "ÜRÜN AD:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(44, 83);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(59, 18);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "MİKTAR:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(60, 114);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(43, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "FİYAT:";
            // 
            // FrmFaturalar
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.BtnTemizle;
            this.ClientSize = new System.Drawing.Size(754, 561);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturalar";
            this.Text = "FİŞLER";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton btnbul;
        private DevExpress.XtraEditors.TextEdit txturunad;
        private DevExpress.XtraEditors.TextEdit txtmiktar;
        private DevExpress.XtraEditors.TextEdit txtfiyat;
        private DevExpress.XtraEditors.TextEdit txttutar;
        private DevExpress.XtraEditors.TextEdit txturunid;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}