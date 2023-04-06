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
    public partial class Form19 : Form
    {
        public Form19()
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
            Form19 u = new Form19();
            u.Close();
        }
    }
}
