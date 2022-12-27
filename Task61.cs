using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task61 : Form
    {
        int[] arr;
        public Task61()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            res_textBox1.Text = "";
            res_textBox2.Text = "";
            try
            {
                n = int.Parse(textBox_n.Text);
            }
            catch(Exception)
            {
                textBox_n.Text = "";
                MessageBox.Show("Некорректный ввод.");
                return;
            }
            arr = new int[n];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                int elem = int.Parse(textBox2.Text);
                arr[n] = elem;
                ArrShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод или размерность массива не определена.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                return;
            }
            int pos_sum = 0;
            int neg_sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    neg_sum += Math.Abs(arr[i]);
                }
                else
                {
                    pos_sum += arr[i];
                }
            }
            res_textBox2.Text = Math.Abs(pos_sum - neg_sum).ToString();
        }
        private void ArrShow()
        {
            res_textBox1.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res_textBox1.Text += arr[i].ToString() + " ";
            }
        }
    }
}
