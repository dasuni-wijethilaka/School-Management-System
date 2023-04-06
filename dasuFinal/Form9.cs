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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 b = new Form2();
            b.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 p = new Form9();
            p.Close();
        }
    }
}
