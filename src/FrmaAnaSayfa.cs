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
using System.Xml;

namespace SarkuteriOtomasyonu
{
    public partial class FrmaAnaSayfa : Form
    {
        public FrmaAnaSayfa()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void azalan()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select urunad,SUM(ADET) AS 'ADET' from TBLURUNLER " +
                "GROUP BY URUNAD having SUM(Adet)<20 ORDER BY SUM(ADET)", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        int islem=0;
        double sayi1 = 0, sayi2 = 0;
        void sıfırla()
        {
            TextBox1.Text = "0";
        }
        
        private void FrmaAnaSayfa_Load(object sender, EventArgs e)
        {
            azalan();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            TextBox1.Text = "0";

        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }            
                TextBox1.Text += ".";           
        }

        private void simpleButton0_Click(object sender, EventArgs e)
        {
                TextBox1.Text += "0";      
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
                TextBox1.Text += "1";           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }     
                TextBox1.Text += "2";          
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }         
                TextBox1.Text += "3";  
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }         
                TextBox1.Text += "4";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }       
                TextBox1.Text += "5";
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
                TextBox1.Text += "6";         
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }    
                TextBox1.Text += "7";
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }   
                TextBox1.Text += "8";
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "";
            }
            TextBox1.Text += "9";
        }

        private void SimpleButton11_Click(object sender, EventArgs e)
        {
            islem = 1;
            sayi1 = double.Parse(TextBox1.Text);
            sıfırla();
        }

        private void SimpleButton12_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = double.Parse(TextBox1.Text);
            sıfırla();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {

            islem = 3;
            sayi1 = double.Parse(TextBox1.Text);
            sıfırla();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {

            islem = 4;
            sayi1 = double.Parse(TextBox1.Text);
            sıfırla();
        }

        private void simpleButton15_Click_1(object sender, EventArgs e)
        {   
            sayi2 = double.Parse(TextBox1.Text);
            TextBox1.Text = hesapla().ToString("#,#.00");
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            string veri = TextBox1.Text;
            TextBox1.Text = "";
            for (int i = 0; i < veri.Length - 1; i++)
            {
                TextBox1.Text += veri[i].ToString();
            }
        }

        private void FrmaAnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumPad0)
            {
                simpleButton0.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                simpleButton1.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad2)
            {
                simpleButton2.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad3)
            {
                simpleButton3.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad4)
            {
                simpleButton4.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad5)
            {
                simpleButton5.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad6)
            {
                simpleButton6.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad7)
            {
                simpleButton7.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad8)
            {
                simpleButton8.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad9)
            {
                simpleButton9.PerformClick();
            }

            if (e.KeyCode == Keys.Decimal)
            {
                simpleButton10.PerformClick();
            }

            if (e.KeyCode == Keys.Divide)
            {
                simpleButton11.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                simpleButton12.PerformClick();
            }

            if (e.KeyCode == Keys.Subtract)
            {
                simpleButton13.PerformClick();
            }

            if (e.KeyCode == Keys.Add)
            {
                simpleButton14.PerformClick();
            }

            if (e.KeyCode == Keys.Delete)
            {
                simpleButton16.PerformClick();
            }

            if (e.KeyCode == Keys.C)
            {
                simpleButton17.PerformClick();
            }
        }

      

        double hesapla()
        {
             double sonuc = 0;
            if (islem == 1)
            {
                sonuc= sayi1 / sayi2;
            }

            else if (islem == 2)
            {
                sonuc = sayi1 * sayi2;
            }

            else if (islem == 3)
            {
                sonuc= sayi1 - sayi2;
            }

            else if (islem == 4)
            {
                sonuc= sayi1 + sayi2;
            }
            else
            {
                sonuc = 0;
            }
                return sonuc;
            

        }

        
    }
}
