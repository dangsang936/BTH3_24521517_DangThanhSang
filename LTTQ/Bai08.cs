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
    public partial class Bai08 : Form
    {
        public int accountNumber = 3;
        public Bai08()
        {
            InitializeComponent();
        }

        //button thêm/sửa
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox3.TextLength == 0 || textBox5.TextLength == 0 || textBox4.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (!char.IsDigit(textBox1.Text[i]))
                {
                    MessageBox.Show("Số tài khoản chỉ được có số.");
                    return;
                }
            }
            for (int i = 0; i < textBox3.TextLength; i++)
            {
                if (!char.IsDigit(textBox3.Text[i]))
                {
                    MessageBox.Show("Số tiền chỉ được có số.");
                    return;
                }
            }
            string searchValue = textBox1.Text.Trim();

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.Trim() == searchValue )
                {
                    item.SubItems[2].Text = textBox5.Text;
                    item.SubItems[3].Text = textBox4.Text;
                    textBox2.Text = (long.Parse(textBox2.Text) + long.Parse(textBox3.Text) - long.Parse(item.SubItems[4].Text)).ToString();
                    item.SubItems[4].Text = textBox3.Text;
                    MessageBox.Show("Cập nhật thành công.");
                    return;
                }    
            }

            listView1.Items.Add(new ListViewItem(new string[] { $"{accountNumber++}", textBox1.Text, textBox5.Text, textBox4.Text, textBox3.Text }));
            textBox2.Text = (long.Parse(textBox2.Text) + long.Parse(textBox3.Text)).ToString();
            MessageBox.Show("Thêm mới thành công.");
        }

        //button xóa
        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems.Count > 1 && item.SubItems[1].Text.Trim() == searchValue)
                {
                    textBox2.Text = (long.Parse(textBox2.Text) - long.Parse(item.SubItems[4].Text)).ToString();
                    listView1.Items.Remove(item); 
                    textBox1.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    MessageBox.Show("Xóa thành công.");
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số tài khoản.");
        }

        //button thoát
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[1].Text;
                textBox5.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[3].Text;
                textBox3.Text = item.SubItems[4].Text;
            }
        }
    }
}
