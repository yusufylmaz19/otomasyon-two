namespace SarkuteriOtomasyonu
{
    partial class FrmRaporlar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSarkuteriDataSet = new SarkuteriOtomasyonu.DBSarkuteriDataSet();
            this.TBLGIDERLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSarkuteriDataSet1 = new SarkuteriOtomasyonu.DBSarkuteriDataSet1();
            this.TBLURUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSarkuteriDataSet2 = new SarkuteriOtomasyonu.DBSarkuteriDataSet2();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBLMUSTERILERTableAdapter = new SarkuteriOtomasyonu.DBSarkuteriDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.TBLGIDERLERTableAdapter = new SarkuteriOtomasyonu.DBSarkuteriDataSet1TableAdapters.TBLGIDERLERTableAdapter();
            this.TBLURUNLERTableAdapter = new SarkuteriOtomasyonu.DBSarkuteriDataSet2TableAdapters.TBLURUNLERTableAdapter();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DBSarkuteriDataSet5 = new SarkuteriOtomasyonu.DBSarkuteriDataSet5();
            this.TBLFATURALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBLFATURALARTableAdapter = new SarkuteriOtomasyonu.DBSarkuteriDataSet5TableAdapters.TBLFATURALARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLGIDERLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLURUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLFATURALARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TBLMUSTERILERBindingSource
            // 
            this.TBLMUSTERILERBindingSource.DataMember = "TBLMUSTERILER";
            this.TBLMUSTERILERBindingSource.DataSource = this.DBSarkuteriDataSet;
            // 
            // DBSarkuteriDataSet
            // 
            this.DBSarkuteriDataSet.DataSetName = "DBSarkuteriDataSet";
            this.DBSarkuteriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBLGIDERLERBindingSource
            // 
            this.TBLGIDERLERBindingSource.DataMember = "TBLGIDERLER";
            this.TBLGIDERLERBindingSource.DataSource = this.DBSarkuteriDataSet1;
            // 
            // DBSarkuteriDataSet1
            // 
            this.DBSarkuteriDataSet1.DataSetName = "DBSarkuteriDataSet1";
            this.DBSarkuteriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBLURUNLERBindingSource
            // 
            this.TBLURUNLERBindingSource.DataMember = "TBLURUNLER";
            this.TBLURUNLERBindingSource.DataSource = this.DBSarkuteriDataSet2;
            // 
            // DBSarkuteriDataSet2
            // 
            this.DBSarkuteriDataSet2.DataSetName = "DBSarkuteriDataSet2";
            this.DBSarkuteriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1370, 561);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1364, 514);
            this.xtraTabPage1.Text = "Müşteriler";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBLMUSTERILERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SarkuteriOtomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1364, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1364, 514);
            this.xtraTabPage2.Text = "Giderler";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TBLGIDERLERBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SarkuteriOtomasyonu.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1364, 514);
            this.reportViewer2.TabIndex = 1;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer3);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1364, 514);
            this.xtraTabPage3.Text = "Ürünler";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TBLURUNLERBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "SarkuteriOtomasyonu.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1364, 514);
            this.reportViewer3.TabIndex = 1;
            // 
            // TBLMUSTERILERTableAdapter
            // 
            this.TBLMUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // TBLGIDERLERTableAdapter
            // 
            this.TBLGIDERLERTableAdapter.ClearBeforeFill = true;
            // 
            // TBLURUNLERTableAdapter
            // 
            this.TBLURUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer4);
            this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1364, 514);
            this.xtraTabPage4.Text = "Faturalar";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.TBLFATURALARBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "SarkuteriOtomasyonu.Report5.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1364, 514);
            this.reportViewer4.TabIndex = 2;
            // 
            // DBSarkuteriDataSet5
            // 
            this.DBSarkuteriDataSet5.DataSetName = "DBSarkuteriDataSet5";
            this.DBSarkuteriDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBLFATURALARBindingSource
            // 
            this.TBLFATURALARBindingSource.DataMember = "TBLFATURALAR";
            this.TBLFATURALARBindingSource.DataSource = this.DBSarkuteriDataSet5;
            // 
            // TBLFATURALARTableAdapter
            // 
            this.TBLFATURALARTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmRaporlar";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLGIDERLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLURUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLFATURALARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource TBLMUSTERILERBindingSource;
        private DBSarkuteriDataSet DBSarkuteriDataSet;
        private DBSarkuteriDataSetTableAdapters.TBLMUSTERILERTableAdapter TBLMUSTERILERTableAdapter;
        private System.Windows.Forms.BindingSource TBLGIDERLERBindingSource;
        private DBSarkuteriDataSet1 DBSarkuteriDataSet1;
        private DBSarkuteriDataSet1TableAdapters.TBLGIDERLERTableAdapter TBLGIDERLERTableAdapter;
        private System.Windows.Forms.BindingSource TBLURUNLERBindingSource;
        private DBSarkuteriDataSet2 DBSarkuteriDataSet2;
        private DBSarkuteriDataSet2TableAdapters.TBLURUNLERTableAdapter TBLURUNLERTableAdapter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource TBLFATURALARBindingSource;
        private DBSarkuteriDataSet5 DBSarkuteriDataSet5;
        private DBSarkuteriDataSet5TableAdapters.TBLFATURALARTableAdapter TBLFATURALARTableAdapter;
    }
}