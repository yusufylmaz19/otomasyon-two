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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLNOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtid.Text = "";
            Txtbaslik.Text = "";
            Rchdetay.Text = "";
            Txtolusturan.Text = "";
            Txthitap.Text = "";

        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into TBLNOTLAR " +
                   "(TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", DateTime.Now.ToShortDateString());
                komut.Parameters.AddWithValue("@P2", DateTime.Now.ToShortTimeString());
                komut.Parameters.AddWithValue("@P3", Txtbaslik.Text);
                komut.Parameters.AddWithValue("@P4", Rchdetay.Text);
                komut.Parameters.AddWithValue("@P5", Txtolusturan.Text);
                komut.Parameters.AddWithValue("@P6", Txthitap.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("delete from TBLNOTLAR WHERE ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update TBLNOTLAR SET " +
               "TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 WHERE ID=@P7 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", DateTime.Now.ToShortDateString());
            komut.Parameters.AddWithValue("@P2", DateTime.Now.ToShortTimeString());
            komut.Parameters.AddWithValue("@P3", Txtbaslik.Text);
            komut.Parameters.AddWithValue("@P4", Rchdetay.Text);
            komut.Parameters.AddWithValue("@P5", Txtolusturan.Text);
            komut.Parameters.AddWithValue("@P6", Txthitap.Text);
            komut.Parameters.AddWithValue("@P7", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
            }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr[0].ToString();
                Txtbaslik.Text = dr[3].ToString();
                Rchdetay.Text = dr[4].ToString();
                Txtolusturan.Text = dr[5].ToString();
                Txthitap.Text = dr[6].ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay frm = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frm.not = dr[6].ToString();
            }
            frm.Show();
        }
    }
}
