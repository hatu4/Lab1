using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task31 : Form
    {
        public Task31()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            textBox2.Text = "";
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Некорректный ввод.");
                return;
            }
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rnd.Next(1000);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SymmCheck() == true)
            {
                textBox2.Text = "Матрица симметрична";
            }
            else { textBox2.Text = "Матрица не симметрична"; }
        }
        private bool SymmCheck()
        {
            int n = dataGridView1.RowCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    try
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) !=
                        Convert.ToDouble(dataGridView1.Rows[j].Cells[i].Value))
                        {
                            return false;
                        }
                    }
                    catch (FormatException)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() != dataGridView1.Rows[j].Cells[i].Value.ToString())
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
