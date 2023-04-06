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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 x = new Form2();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 m = new Form23();
            m.Close();

        }
    }
}
