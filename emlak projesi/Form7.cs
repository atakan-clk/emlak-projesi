using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using emlak_projesi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emlak_projesi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqlbaglantisi bgl = new sqlbaglantisi();
            //SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Emlakk", bgl.baglanti());
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            dataGridView1.DataSource = db_islemcisi.aaa("tbl_Emlakk").Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlbaglantisi bgl = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("select *from tbl_Emlakk where ŞirketAdı like '%" + textBox1.Text + "%' or EmlakçınınAdı like '%" + textBox1.Text + "%'or EmlakçınınAdı like '%" + textBox1.Text + "%' or Adresi like '%" + textBox1.Text + "%' or Numarası like '%" + textBox1.Text + "%' or Tc_Kimlik like'" + textBox1.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut); 
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }
    }
}



























//sqlbaglantisi bgl = new sqlbaglantisi();
//SqlCommand komut = new SqlCommand("select *from tbl_Emlakk where ŞirketAdı like '%" + textBox1.Text + "%' or EmlakçınınAdı like '%" + textBox1.Text + "%'or EmlakçınınAdı like '%" + textBox1.Text + "%' or Adresi like '%" + textBox1.Text + "%' or Numarası like '%" + textBox1.Text + "%' or Tc_Kimlik like'" + textBox1.Text + "%'", bgl.baglanti());
//SqlDataAdapter da = new SqlDataAdapter(komut);
//DataSet ds = new DataSet();
//da.Fill(ds);
//dataGridView1.DataSource = ds.Tables[0];
//textBox1.Clear();