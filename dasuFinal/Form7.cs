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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 x = new Form2();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form34 k = new Form34();
            k.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form35 w = new Form35();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form36 r = new Form36();
            r.Show();
        }
    }
}
