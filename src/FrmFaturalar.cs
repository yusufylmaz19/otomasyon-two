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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi(); 

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select URUNADI,MIKTAR,FIYAT,TUTAR from TBLFIS", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txturunid.Text = "";
            txturunad.Text = "";
            txtmiktar.Text = "";
            txtfiyat.Text = "";
            txttutar.Text = "";
            label1.Text = "";
            
        }
         
 
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmFis frm = new FrmFis();          
            frm.Show();  
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(txtfiyat.Text);
            miktar = Convert.ToDouble(txtmiktar.Text);
            tutar = miktar * fiyat;
            txttutar.Text = tutar.ToString();

            try
            {

                SqlCommand komut = new SqlCommand("insert into TBLFATURALAR " +
                    "(URUNADI,MIKTAR,FIYAT,TUTAR,TARIH,SAAT) " +
                    "VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());

                komut.Parameters.AddWithValue("@P1", txturunad.Text);
                komut.Parameters.AddWithValue("@P2", txtmiktar.Text);
                komut.Parameters.AddWithValue("@P3", decimal.Parse(txtfiyat.Text));
                komut.Parameters.AddWithValue("@P4", decimal.Parse(txttutar.Text));
                komut.Parameters.AddWithValue("@P5", DateTime.Now.ToShortDateString());
                komut.Parameters.AddWithValue("@P6", DateTime.Now.ToShortTimeString());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();


                SqlCommand komut1 = new SqlCommand("insert into TBLFIS " +
                    "(URUNADI,MIKTAR,FIYAT,TUTAR) " +
                    "VALUES(@P1,@P2,@P3,@P4)", bgl.baglanti());

                komut1.Parameters.AddWithValue("@P1", txturunad.Text);
                komut1.Parameters.AddWithValue("@P2", txtmiktar.Text);
                komut1.Parameters.AddWithValue("@P3", decimal.Parse(txtfiyat.Text));
                komut1.Parameters.AddWithValue("@P4", decimal.Parse(txttutar.Text));
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();

                SqlCommand komut2 = new SqlCommand(" select sum(tutar) from TBLFIS", bgl.baglanti());
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    label1.Text = dr[0].ToString() + "TL";
                }
                bgl.baglanti().Close();


                SqlCommand komut3 = new SqlCommand("update TBLURUNLER SET " +
                       "ADET=ADET-@P1 WHERE ID=@P2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@P1", txtmiktar.Text);
                komut3.Parameters.AddWithValue("@P2", txturunid.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();

            
             }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            try { 
            
            SqlCommand komut3 = new SqlCommand("update TBLURUNLER SET " +
                  "ADET=ADET+@P1 WHERE ID=@P2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@P1", txtmiktar.Text);
            komut3.Parameters.AddWithValue("@P2", txturunid.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut = new SqlCommand("delete from TBLFATURALAR WHERE ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txturunid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand("delete from TBLFIS WHERE ID=@P1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@P1", txturunid.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();

            listele();
            temizle();
            MessageBox.Show("Fatura silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnbul_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("select URUNAD, SATISFIYAT FROM TBLURUNLER WHERE ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txturunid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txturunad.Text = dr[0].ToString();
                txtfiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            { 
                txturunad.Text = dr[0].ToString();
                txtmiktar.Text = dr[1].ToString();
                txtfiyat.Text = dr[2].ToString();
                txttutar.Text = dr[3].ToString();

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut1 = new SqlCommand("delete from TBLFIS  ", bgl.baglanti());
            komut1.Parameters.AddWithValue("@P1", txturunid.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();

            listele();
            temizle();
            MessageBox.Show("Fiş silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
