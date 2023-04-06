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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 c = new Form5();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form24 z = new Form24();
            z.Close();
        }
    }
}
