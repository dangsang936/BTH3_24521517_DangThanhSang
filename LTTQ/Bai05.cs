using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }
        // + button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _) || !int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào cả hai ô.");
                return;
            }
            int ans;
            ans = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = ans.ToString();
        }

        // button -
        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _) || !int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào cả hai ô.");
                return;
            }
            int ans;
            ans = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = ans.ToString();
        }

        // button X
        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _) || !int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào cả hai ô.");
                return;
            }
            int ans;
            ans = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox3.Text = ans.ToString();
        }

        // button '/'
        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out _) || !int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào cả hai ô.");
                return;
            }
            if (int.Parse(textBox2.Text) == 0)
            {
                MessageBox.Show("Không thể chia cho 0.");
                return;
            }
            double ans;
            ans = (double)int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            textBox3.Text = ans.ToString();
        }
    }
}
