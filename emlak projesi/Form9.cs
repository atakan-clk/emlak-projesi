using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace emlak_projesi
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Daireler dr = new Daireler();
            dr.oda = "2+1";
            dr.metre = "70m2";
            dr.fiyat = "650.000";
            dr.blok = "B.Blok";
            label1.Text = dr.oda;
            label2.Text = dr.metre;
            label3.Text = dr.fiyat;
            label4.Text = dr.blok;
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
