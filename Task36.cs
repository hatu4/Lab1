using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task36 : Form
    {
        public Task36()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            try
            {
                n = int.Parse(textBox_n.Text);
            }
            catch (Exception)
            {
                textBox_n.Text = "";
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
                    if (i < j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = rnd.Next(3);
                    }
                    else if (i == j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                    else if (i > j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 2 - (int)dataGridView1.Rows[j].Cells[i].Value;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int res_count = 0;
            int n = dataGridView1.RowCount;
            for (int i = 0; i < n; i++)
            {
                int win_count = 0;
                int lose_count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "2")
                    {
                        win_count += 1;
                    }
                    if (i != j)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "0" && (i != j))
                        {
                            lose_count += 1;
                        }
                    }
                }
                if (win_count > lose_count)
                {
                    res_count++;
                }
                if (lose_count == 0)
                {
                    textBox2.Text += (i + 1).ToString() + " ";
                }
            }
            textBox1.Text = res_count.ToString();
        }
    }
}
