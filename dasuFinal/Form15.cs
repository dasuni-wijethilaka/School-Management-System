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
    public partial class Form15 : Form
    {
        public Form15()
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
            Form15 s = new Form15();
            s.Close();             
        }
    }
}
