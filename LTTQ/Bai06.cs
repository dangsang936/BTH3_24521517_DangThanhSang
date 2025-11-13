using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LTTQ
{

    public partial class Bai06 : Form
    {
        // Biến lưu giá trị số hạng thứ nhất
        Double temp_num = 0;

        // Biến lưu phép toán vừa chọn (+, -, *, /)
        String sign = "";

        // Cờ kiểm tra xem người dùng vừa ấn nút phép toán hay chưa
        bool is_sign = false;

        // Biến cho chức năng nhớ (Memory)
        Double memoryValue = 0;
        public Bai06()
        {
            InitializeComponent();
        }

        // Các button số
        private void number_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (is_sign))
                textBox1.Clear();

            is_sign = false;
            var button = sender as Button;
            if (button == null) return;

            // Kiểm tra để không nhập quá 1 dấu chấm
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        // Các button dấu phép toán
        private void sign_click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;
            if (temp_num != 0)
            {
                button_Equal.PerformClick(); 
                sign = button.Text;
                is_sign = true;
            }
            else
            {
                sign = button.Text;
                    
                temp_num = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                is_sign = true;
            }
        }

        //button căn bậc 2 sqrt
        private void button4_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = Math.Sqrt(val).ToString();
        }
        

        //button kết quả =
        private void button11_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case "+":
                    textBox1.Text = (temp_num + Double.Parse(textBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    textBox1.Text = (temp_num - Double.Parse(textBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "*":
                    textBox1.Text = (temp_num * Double.Parse(textBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox1.Text, CultureInfo.InvariantCulture) != 0)
                        textBox1.Text = (temp_num / Double.Parse(textBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    else
                        textBox1.Text = "Error";
                    break;
                default:
                    break;
            }
            // Cập nhật lại temp_num để tính tiếp nếu cần
            if (textBox1.Text != "Error")
                temp_num = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            sign = "";
        }

        // button xóa C
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            temp_num = 0;
            sign = "";
        }

        // button CE
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        // button backspace
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        // button %
        private void button8_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = (val / 100).ToString();
        }

        // button nghịch đảo 1/x
        private void button5_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (val != 0)
                textBox1.Text = (1.0 / val).ToString();
            else
                textBox1.Text = "Error";
        }

        // button đổi dấu +/-
        private void button19_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = (val * -1).ToString();
        }

        //button MC xóa giá trị memory
        private void button27_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
        }

        //button MR lấy ra giá trị memory
        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = memoryValue.ToString();
        }

        //button MS để lưu giá trị vào memory
        private void button25_Click(object sender, EventArgs e)
        {
            memoryValue = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
        }

        //button M+ tăng giá trị memory thêm
        private void button24_Click(object sender, EventArgs e)
        {
            memoryValue += Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
        }

        
    }
}
