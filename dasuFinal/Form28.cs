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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 d = new Form6();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form28 k = new Form28();
            k.Close();
        }
    }
}
