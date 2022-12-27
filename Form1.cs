using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Task6();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Task11();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Task31();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Task36();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Task61();
            f.Show();
        }
    }
}
