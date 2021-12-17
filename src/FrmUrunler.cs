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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLURUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtMarka.Text = "";
            Txttur.Text = "";           
            NudAdet.Value = 0;
            TxtAlıs.Text = "";
            TxtSatıs.Text = "";
             
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
       
                SqlCommand komut = new SqlCommand("insert into tblurunler" +
              " (urunad,marka,tur,adet,alısfıyatı,satısfıyat) values" +
              " (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", Txttur.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(NudAdet.Text).ToString());
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtAlıs.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtSatıs.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi", " Bilgi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız","UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut1 = new SqlCommand("delete from tblurunler where ıd=@p1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtId.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün sistemden silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {

                SqlCommand komut2 = new SqlCommand("update tbl_urunler set" +
                    " urunad=@p1, marka=@p2, tur=@p3, adet=@p4, " +
                    "alısfıyatı=@p5, satısfıyat=@p6 where ıd=@p7", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtMarka.Text);
                komut2.Parameters.AddWithValue("@p3", Txttur.Text);
                komut2.Parameters.AddWithValue("@p4", int.Parse(NudAdet.Text).ToString());
                komut2.Parameters.AddWithValue("@p5", decimal.Parse(TxtAlıs.Text));
                komut2.Parameters.AddWithValue("@p6", decimal.Parse(TxtSatıs.Text));
                komut2.Parameters.AddWithValue("@p7", TxtId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün bilgileri güncellendi", " Bilgi",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                TxtId.Text = dr[0].ToString();
                TxtAd.Text = dr[1].ToString();
                TxtMarka.Text = dr[2].ToString();
                Txttur.Text = dr[3].ToString();
                NudAdet.Value = decimal.Parse(dr[4].ToString());
                TxtAlıs.Text = dr[5].ToString();
                TxtSatıs.Text = dr[6].ToString();
              
            }
        }
    }
}
