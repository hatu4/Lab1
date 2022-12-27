using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, p;
            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                c = float.Parse(textBox3.Text);
            }
            catch (Exception)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Некорректный ввод");
                return;
            }
            p = (Math.Max(a, Math.Max(b, c)) - Math.Min(a, Math.Max(b, c))) / 2;
            textBox4.Text = p.ToString();
        }
    }
}
