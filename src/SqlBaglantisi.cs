using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SarkuteriOtomasyonu
{
    class SqlBaglantisi
    {
        public  SqlConnection baglanti()
        {
            baglantiyolu bgl = new baglantiyolu();
            SqlConnection baglan = new SqlConnection(bgl.adres);
            baglan.Open();
            return baglan;
        }
    }
}
