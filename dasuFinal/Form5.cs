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
    public partial class Form5 : Form
    {
        public Form5()
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
            Form5 c = new Form5();
            c.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form24 t = new Form24();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 q = new Form23();
            q.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form25 s = new Form25();
            s.Show();
        }
    }
}
