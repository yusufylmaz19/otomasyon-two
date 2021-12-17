using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarkuteriOtomasyonu
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DBSarkuteriDataSet5.TBLFATURALAR' table. You can move, or remove it, as needed.
            this.TBLFATURALARTableAdapter.Fill(this.DBSarkuteriDataSet5.TBLFATURALAR);
            // TODO: This line of code loads data into the 'DBSarkuteriDataSet2.TBLURUNLER' table. You can move, or remove it, as needed.
            this.TBLURUNLERTableAdapter.Fill(this.DBSarkuteriDataSet2.TBLURUNLER);
            // TODO: This line of code loads data into the 'DBSarkuteriDataSet1.TBLGIDERLER' table. You can move, or remove it, as needed.
            this.TBLGIDERLERTableAdapter.Fill(this.DBSarkuteriDataSet1.TBLGIDERLER);
            // TODO: This line of code loads data into the 'DBSarkuteriDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.TBLMUSTERILERTableAdapter.Fill(this.DBSarkuteriDataSet.TBLMUSTERILER);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
