using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlak_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "a" && textBox2.Text == "1")
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else if (textBox1.Text=="mert" && textBox2.Text == "1")
            {
                Form12 frm12 = new Form12();
                frm12.Show();
                this.Hide();
            }
            else if (textBox1.Text =="ceren"&& textBox2.Text == "1")
            {
                Form14 form14 = new Form14();   
                form14.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARISIZ");
            }


        }
    }
}
