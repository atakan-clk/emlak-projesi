using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace emlak_projesi
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Siteler;Integrated Security=True");
        public void verilerigetir(String veri)
        {
            SqlDataAdapter da = new SqlDataAdapter(veri, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            verilerigetir("select*from tbl_Aidatlar where AdıSoyadı = 'Mert Öz'");
        }

        private void gÜVENLİÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void fİTNESSÜYEOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Hide();
        }
    }
}
