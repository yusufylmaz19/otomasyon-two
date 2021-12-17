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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs  e)
        {
            SqlCommand komut = new SqlCommand("select * from TBLADMIN where KULLANICIADI=@P1 and SIFRE=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textEdit1.Text);
            komut.Parameters.AddWithValue("@P2", textEdit2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaEkran fra = new FrmAnaEkran();
                fra.kullanici = textEdit1.Text;
                fra.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumAquamarine;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.IndianRed;
        }
    }
}
