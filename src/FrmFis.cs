using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SarkuteriOtomasyonu
{
    public partial class FrmFis : Form
    {
        public FrmFis()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        public string fis;
        private void FrmFiş_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DBSarkuteriDataSet4.TBLFIS' table. You can move, or remove it, as needed.
            this.TBLFISTableAdapter.Fill(this.DBSarkuteriDataSet4.TBLFIS);

            this.reportViewer1.RefreshReport();

            
        }

        
    }
}
