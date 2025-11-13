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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    using (var f = new Bai01())
                        f.ShowDialog();
                    break;
                case 1:
                    using (var f = new Bai02())
                        f.ShowDialog();
                    break;
                case 2:
                    using (var f = new Bai03())
                        f.ShowDialog();
                    break;
                case 3:
                    using (var f = new Bai04())
                        f.ShowDialog();
                    break;
                case 4:
                    using (var f = new Bai05())                      
                        f.ShowDialog();
                    break;
                case 5:
                    using (var f = new Bai06())
                        f.ShowDialog();
                    break;
                case 6:
                    using (var f = new Bai07())
                        f.ShowDialog();
                    break;
                case 7:
                    using (var f = new Bai08())
                        f.ShowDialog();
                    break;
                case 8:
                    using (var f = new Bai09())
                        f.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn bài thích hợp");
                    break;            
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Đã kết thúc!");
        }
    }
}
