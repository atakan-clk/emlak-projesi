using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace emlak_projesi
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }


        private void Form14_Load(object sender, EventArgs e)
        {
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Aidatlar where AdıSoyadı = 'Ceren Dal'", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
