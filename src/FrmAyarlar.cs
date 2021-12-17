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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

          SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLADMIN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
      
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            txts.Text = "";
            txtk.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Kaydet")
            {
                SqlCommand komut = new SqlCommand("insert into TBLADMIN  values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtk.Text);
                komut.Parameters.AddWithValue("@p2", txts.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni admin sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (button1.Text == "Güncelle")
            {
                SqlCommand komut = new SqlCommand("update TBLADMIN set SIFRE=@p1 WHERE KULLANICIADI=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txts.Text);
                komut.Parameters.AddWithValue("@p2", txtk.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifre güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtk.Text = dr[0].ToString();
                txts.Text = dr[1].ToString();
            }
        }

        private void txtk_TextChanged(object sender, EventArgs e)
        {
            if (txtk.Text != "")
            {
                button1.Text = "Güncelle";
            }
            else
            {
                button1.Text = "Kaydet";
            }
        }
    }
}
