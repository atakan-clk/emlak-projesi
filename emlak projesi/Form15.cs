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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Siteler;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("insert into tbl_Spor(AdSoyad,TcKimlik,OturduğuSite,BaslangıcTarih,BitişTarihi) Values(@ad,@tc,@site,@bas,@bit)", baglan);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@tc", textBox3.Text);
            komut.Parameters.AddWithValue("@site", textBox2.Text);
            komut.Parameters.AddWithValue("@bas", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@bit", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            MessageBox.Show("ÜYE KAYDINIZ OLUŞUTURULDU");
            baglan.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ücret;
            DateTime cıkıs = Convert.ToDateTime(dateTimePicker2.Text);
            DateTime giriş = Convert.ToDateTime(dateTimePicker1.Text);
            TimeSpan sonuc = cıkıs - giriş;
            label7.Text = sonuc.TotalDays.ToString();
            ücret = Convert.ToInt32(label7.Text) * 50;
            label8.Text = ücret.ToString();

        }

        private void gÜVENLİÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void fitnessÜyeOLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
                frm12.Show();
            this.Hide();
        }
    }

}