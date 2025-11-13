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
    public partial class Bai07 : Form
    {
        public int [] seatSelected= new int[15];
        int index = -1;
        public Bai07()
        {
            InitializeComponent();
        }

        private void Allbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Blue;
                seatSelected[++index] = Convert.ToInt32(button.Text);
            }
            else if (button.BackColor == Color.Blue)
            {
                button.BackColor = Color.White;
                for (int i = 0; i <= index; i++)
                    if(Convert.ToInt32(button.Text) == seatSelected[i])
                    {
                        seatSelected[--index] = 0;
                        break;
                    }    
            }
            else
                MessageBox.Show("Ghế đã được chọn.");
        }
        //button tính tiền
        private void button17_Click(object sender, EventArgs e)
        {
            int ans = 0;
            while (index >= 0)
            {
                if (seatSelected[index] <= 5)
                    ans += 5000;
                else if (seatSelected[index] > 5 && seatSelected[index] <= 10)
                    ans += 6500;
                else if (seatSelected[index] > 10 && seatSelected[index] <= 15)
                    ans += 8000;
                switch (seatSelected[index])
                { 
                    case 1:
                    button1.BackColor = Color.Yellow;
                    break;
                case 2:
                    button2.BackColor = Color.Yellow;
                    break;
                case 3:
                    button3.BackColor = Color.Yellow;
                    break;
                case 4:
                    button4.BackColor = Color.Yellow;
                    break;
                case 5:
                    button5.BackColor = Color.Yellow;
                    break;
                case 6:
                    button6.BackColor = Color.Yellow;
                    break;
                case 7:
                    button7.BackColor = Color.Yellow;
                    break;
                case 8:
                    button8.BackColor = Color.Yellow;
                    break;
                case 9:
                    button9.BackColor = Color.Yellow;
                    break;
                case 10:
                    button10.BackColor = Color.Yellow;
                    break;
                case 11:
                    button11.BackColor = Color.Yellow;
                    break;
                case 12:
                    button12.BackColor = Color.Yellow;
                    break;
                case 13:
                    button13.BackColor = Color.Yellow;
                    break;
                case 14:
                    button14.BackColor = Color.Yellow;
                    break;
                case 15:
                    button15.BackColor = Color.Yellow;
                    break;
                }
                seatSelected[index--] = 0;
            }
            textBox1.Text = ans.ToString();
            
        }

        //button hủy chọn
        private void button19_Click(object sender, EventArgs e)
        {
            while(index>=0)
            {
                switch (seatSelected[index])
                {
                    case 1:
                        button1.BackColor = Color.White;
                        break;
                    case 2:
                        button2.BackColor = Color.White;
                        break;
                    case 3:
                        button3.BackColor = Color.White;
                        break;
                    case 4:
                        button4.BackColor = Color.White;
                        break;
                    case 5:
                        button5.BackColor = Color.White;
                        break;
                    case 6:
                        button6.BackColor = Color.White;
                        break;
                    case 7:
                        button7.BackColor = Color.White;
                        break;
                    case 8:
                        button8.BackColor = Color.White;
                        break;
                    case 9:
                        button9.BackColor = Color.White;
                        break;
                    case 10:
                        button10.BackColor = Color.White;
                        break;
                    case 11:
                        button11.BackColor = Color.White;
                        break;
                    case 12:
                        button12.BackColor = Color.White;
                        break;
                    case 13:
                        button13.BackColor = Color.White;
                        break;
                    case 14:
                        button14.BackColor = Color.White;
                        break;
                    case 15:
                        button15.BackColor = Color.White;
                        break;
                }
                seatSelected[index--] = 0;
            }
            textBox1.Text = "0";
        }

        //button thoát
        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
