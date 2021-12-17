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
    public partial class FrmPersonller : Form
    {
        public FrmPersonller()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from TBLPERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTel1.Text = "";
            txttc.Text = "";
            RchAdres.Text = "";
            TxtGorev.Text = "";
        }
        private void FrmPersonller_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into TBLPERSONELLER" +
                       " (AD,SOYAD,TELEFON,TC,ADRES,GOREV)" +
                       " values (@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtAd.Text);
                komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@P3", MskTel1.Text);
                komut.Parameters.AddWithValue("@P4", txttc.Text);
                komut.Parameters.AddWithValue("@P5", RchAdres.Text);
                komut.Parameters.AddWithValue("@P6", TxtGorev.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel sisteme eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                SqlCommand komut = new SqlCommand("delete from TBLPERSONELLER where ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel sistemden silindi ", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand komut = new SqlCommand("update   TBLPERSONELLER set " +
                    "AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4 , ADRES=@P5, GOREV=@P6 WHERE ID=@P7", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtAd.Text);
                komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@P3", MskTel1.Text);
                komut.Parameters.AddWithValue("@P4", txttc.Text);
                komut.Parameters.AddWithValue("@P5", RchAdres.Text);
                komut.Parameters.AddWithValue("@P6", TxtGorev.Text);
                komut.Parameters.AddWithValue("@P7", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                TxtSoyad.Text = dr[2].ToString();
                MskTel1.Text = dr[3].ToString();
                txttc.Text = dr[4].ToString();
                RchAdres.Text = dr[5].ToString();
                TxtGorev.Text = dr[6].ToString();

            }
        }
    }
}
