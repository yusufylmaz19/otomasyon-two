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
using DevExpress.Charts;
using DevExpress.XtraCharts;

namespace SarkuteriOtomasyonu
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec PRCMUSTERIHAREKET", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void giderler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLGIDERLER ", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        public string ad;
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            lblkullanicii.Text = ad;
            musterihareket();
            giderler();

            SqlCommand komut = new SqlCommand(" select sum(tutar) from TBLFATURALAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbltutar.Text = dr[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand(" select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EXTRA) from TBLGIDERLER ORDER BY ID ASC ", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblodeme.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand(" select MAASLAR from TBLGIDERLER ORDER BY ID DESC ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblpmaas.Text = dr2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();


            SqlCommand komut3 = new SqlCommand(" select COUNT(*) from TBLMUSTERILER ", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblmsayi.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();
 
            SqlCommand komut7 = new SqlCommand(" select COUNT(*) from TBLPERSONELLER ", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblpsayi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut8 = new SqlCommand(" select SUM(ADET) from TBLURUNLER ", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblssayi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();
        }


         
        int sayac = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                groupControl10.Text = "Elektrik Faturaları";
                chartControl1.Series["Aylar"].Points.Clear();



                SqlCommand komut9 = new SqlCommand(" select top 4 AY, ELEKTRIK from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 5 && sayac <= 10)
            {
                groupControl10.Text = "Su Faturaları";
                chartControl1.Series["Aylar"].Points.Clear();

                SqlCommand komut10 = new SqlCommand(" select top 4 AY, SU from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new SeriesPoint(dr10[0], dr10[1]));

                }
                bgl.baglanti().Close();
            }

            if (sayac > 10 && sayac <= 15)
            {
                groupControl10.Text = "Doğalgaz Faturaları";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand(" select top 4 AY, DOGALGAZ from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac > 15 && sayac <= 20)
            {
                groupControl10.Text = "Extra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand(" select top 4 AY, EXTRA from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac == 20)
            {
                sayac = 0;
            }
        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "Elektrik Faturaları";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut9 = new SqlCommand(" select top 4 AY, ELEKTRIK from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl11.Text = "Su Faturaları";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut9 = new SqlCommand(" select top 4 AY, SU from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl11.Text = "Doğalgaz Faturaları";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut9 = new SqlCommand(" select top 4 AY, DOGALGAZ from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl11.Text = "Extra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut9 = new SqlCommand(" select top 4 AY, EXTRA from TBLGIDERLER order by ID desc ", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 == 20)
            {
                sayac2 = 0;
            }
        }
    }
}
