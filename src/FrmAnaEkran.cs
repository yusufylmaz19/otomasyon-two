using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarkuteriOtomasyonu
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }


        public string kullanici;
        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {

            if (fr12 == null || fr12.IsDisposed)
            {

                fr12 = new FrmaAnaSayfa();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }

        FrmUrunler fr;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        FrmMusterıler fr1;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new FrmMusterıler();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }

        FrmPersonller fr2;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new FrmPersonller();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        FrmGiderler fr3;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new FrmGiderler();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        FrmKasa fr4;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new FrmKasa();
                fr4.ad = kullanici;
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        FrmStoklar fr5;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new FrmStoklar();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        FrmHareketler fr6;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new FrmHareketler();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        FrmFaturalar fr7;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new FrmFaturalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        FrmRehber fr8;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new FrmRehber();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        FrmRaporlar fr9;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new FrmRaporlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        FrmAyarlar fr10;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new FrmAyarlar();
               
                fr10.Show();
            }
        }
        
        FrmNotlar fr11;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11==null || fr11.IsDisposed)
            {

                fr11 = new FrmNotlar();
                fr11.MdiParent = this;
                fr11.Show();
            }

        }

        FrmaAnaSayfa fr12;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr12 == null || fr12.IsDisposed)
            {

                fr12 = new FrmaAnaSayfa();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
    }
}
