using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace emlak_projesi
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

            Daireler dr = new Daireler();
            dr.oda = "4+1";
            dr.metre = "110m2";
            dr.fiyat = "1.000.000";
            dr.blok = "C.Blok";
            label1.Text = dr.oda;
            label2.Text = dr.metre;
            label3.Text = dr.fiyat;
            label4.Text = dr.blok;
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm9= new Form9();
            frm9.Show();
            this.Hide();
        }
    }
}