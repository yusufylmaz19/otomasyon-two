namespace SarkuteriOtomasyonu
{
    partial class FrmFis
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBLFISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSarkuteriDataSet4 = new SarkuteriOtomasyonu.DBSarkuteriDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBLFISTableAdapter = new SarkuteriOtomasyonu.DBSarkuteriDataSet4TableAdapters.TBLFISTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBLFISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // TBLFISBindingSource
            // 
            this.TBLFISBindingSource.DataMember = "TBLFIS";
            this.TBLFISBindingSource.DataSource = this.DBSarkuteriDataSet4;
            // 
            // DBSarkuteriDataSet4
            // 
            this.DBSarkuteriDataSet4.DataSetName = "DBSarkuteriDataSet4";
            this.DBSarkuteriDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBLFISBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SarkuteriOtomasyonu.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(668, 346);
            this.reportViewer1.TabIndex = 0;
            // 
            // TBLFISTableAdapter
            // 
            this.TBLFISTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(668, 346);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FrmFis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİŞ";
            this.Load += new System.EventHandler(this.FrmFiş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLFISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSarkuteriDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBLFISBindingSource;
        private DBSarkuteriDataSet4 DBSarkuteriDataSet4;
        private DBSarkuteriDataSet4TableAdapters.TBLFISTableAdapter TBLFISTableAdapter;
    }
}