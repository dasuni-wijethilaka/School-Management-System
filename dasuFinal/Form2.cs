using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dasuFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 b = new Form4();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 c = new Form5();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 d = new Form6();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 x = new Form2();
            x.Close();

        }
    }
}
