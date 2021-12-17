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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLGIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            TxtId.Text = "";
            CbeAy.Text = "";
            CbeYil.Text = "";
            TxtElekt.Text = "";
            TxtSu.Text = "";
            TxtDgaz.Text = "";
            TxtInt.Text = "";
            TxtMaas.Text = "";
            TxtExtra.Text = "";
            RchNot.Text = "";
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("insert into TBLGIDERLER" +
                " (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EXTRA,NOTLAR)" +
                " values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", CbeAy.Text);
            komut.Parameters.AddWithValue("@P2", CbeYil.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtElekt.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(TxtDgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtInt.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtMaas.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(TxtExtra.Text));
            komut.Parameters.AddWithValue("@P9", RchNot.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider tablosuna veri kaydedildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlCommand komut = new SqlCommand("delete from TBLGIDERLER WHERE ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("gider tablosundan veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlCommand komut = new SqlCommand("delete from TBLGIDERLER WHERE ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("gider tablosundan veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CbeAy.Text = dr[1].ToString();
                CbeYil.Text = dr[2].ToString();
                TxtElekt.Text = dr[3].ToString();
                TxtSu.Text = dr[4].ToString();
                TxtDgaz.Text = dr[5].ToString();
                TxtInt.Text = dr[6].ToString();
                TxtMaas.Text = dr[7].ToString();
                TxtExtra.Text = dr[8].ToString();
                RchNot.Text = dr[9].ToString();
            }
        }
    }
}
