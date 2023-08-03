using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace emlak_projesi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Siteler;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
    public static class db_islemcisi
    {
        public static  DataSet aaa(string tableName)
        {
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tableName, bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}   
