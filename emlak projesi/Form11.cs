using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emlak_projesi
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Siteler;Integrated Security=True");
        public void verilerigetir(string veri)
        {
            SqlDataAdapter da = new SqlDataAdapter(veri, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilerigetir("select * from tbl_Spor");
        }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_Spor (AdSoyad,TcKimlik,OturduğuSite,BaslangıcTarih,BitişTarihi) Values(@ad,@tc,@site,@bas,@bit)", baglan);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("tc", textBox4.Text);
            komut.Parameters.AddWithValue("site", comboBox1.Text);
            komut.Parameters.AddWithValue("bas", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("bit", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            verilerigetir("select * from tbl_Spor");
            baglan.Close();
            textBox1.Clear();
            textBox4.Clear();

        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_Spor where AdSoyad=@ad or TcKimlik=@tc", baglan);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@tc", textBox2.Text);
            komut.ExecuteNonQuery();
            verilerigetir("select * from tbl_Spor");
            baglan.Close();
        }

        private void kayıtAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from tbl_Spor where AdSoyad like '%" + textBox3.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void kayıtGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sqlCommand = new SqlCommand("update tbl_Spor set AdSoyad='" + textBox1.Text + "',TcKimlik='" + textBox4.Text + "',OturduğuSite='" + comboBox1.Text + "',BaslangıcTarih='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',BitişTarihi='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'where AdSoyad= '" + a + "'", baglan);
            sqlCommand.ExecuteNonQuery();
            verilerigetir("select * from tbl_Spor");
            baglan.Close();

        }
        public string a;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string AdSoyad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string TcKimlik = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string OturduğuSite = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string BaslangıcTarih = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string BitişTarih = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            textBox1.Text = AdSoyad;
            textBox4.Text = TcKimlik;
            comboBox1.Text = OturduğuSite;
            dateTimePicker1.Text = BaslangıcTarih;
            dateTimePicker2.Text = BitişTarih;
            a = AdSoyad;

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
