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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Siteler;Integrated Security=True");
        private void veriler()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Sitebilgileri", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ZAMBAK Sitesi")
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "GÜL Sitesi")
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "MENEKŞE Sitesi")
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "PAPATYA Sitesi")
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Yellow;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Sitebilgileri(id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" + textBox8.Text + "','" + comboBox1.Text.ToString() + "','" + comboBox3.Text.ToString() + "' ,'" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriler();
            textBox1.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }



        private void button8_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand(" Update Sitebilgileri set id = '" + textBox8.Text + "' ,site='" + comboBox1.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox4.Text.ToString() + "',no='" + textBox7.Text.ToString() + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',notlar='" + textBox6.Text.ToString() + "',satkira='" + comboBox2.Text.ToString() + "' where id =" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void görüntüleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Sitebilgileri(id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" + textBox8.Text + "','" + comboBox1.Text.ToString() + "','" + comboBox3.Text.ToString() + "' ,'" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriler();
            textBox1.Clear();
            textBox2.Clear();
            textBox8.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
        }
        int id = 0;
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from Sitebilgileri where id = (" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriler();
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox8.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void güncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand(" Update Sitebilgileri set id = '" + textBox8.Text + "' ,site='" + comboBox1.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox4.Text.ToString() + "',no='" + textBox7.Text.ToString() + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',notlar='" + textBox6.Text.ToString() + "',satkira='" + comboBox2.Text.ToString() + "' where id =" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriler();
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kişiBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Sitebilgileri where id like '%" + textBox3.Text + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();

        }

        private void müşteriPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satılıkDairelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void emlakBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void sporSalonuKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

        private void güvenliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
            this.Hide();
        }
    }
}
