using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace emlak_projesi
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Daireler dr = new Daireler();
            dr.oda = "3+1";
            dr.metre = "90m2";
            dr.fiyat = "950.000";
            dr.blok = "A.Blok";
            label1.Text = dr.oda;
            label2.Text = dr.metre;
            label3.Text = dr.fiyat;
            label4.Text = dr.blok;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();

        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
