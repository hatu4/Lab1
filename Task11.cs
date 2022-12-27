using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task11 : Form
    {
        public Task11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = 0, y = 0, z = 0;
            res_textBox.Text = "";
            try
            {
                x = float.Parse(textBox_x.Text);
                y = float.Parse(textBox_y.Text);
                z = float.Parse(textBox_z.Text);
            }
            catch (Exception)
            {
                textBox_x.Text = "";
                textBox_y.Text = "";
                textBox_z.Text = "";
                MessageBox.Show("Некорректный ввод.");
                return;
            }
            if ((x + y > z) && (x + z > y) && (y + z > x))
            {
                res_textBox.Text = "Треугольник существует.";
            }
            else
            {
                res_textBox.Text = "Треугольник не существует.";
            }
        }
    }
}
