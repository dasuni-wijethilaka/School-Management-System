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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 x = new Form2();
            x.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form33 c = new Form33();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form32 b = new Form32();
            b.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form31 d = new Form31();
            d.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }
    }
}
