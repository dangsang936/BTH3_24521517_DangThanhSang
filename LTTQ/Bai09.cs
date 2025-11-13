using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTTQ
{
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 
                || textBox2.TextLength == 0 
                || comboBox1.SelectedIndex < 0 
                || (radioButton1.Checked == false 
                & radioButton2.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (!char.IsDigit(textBox1.Text[i]))
                {
                    MessageBox.Show("mã sinh viên chỉ được có số.");
                    return;
                }
            }

            int searchValue = Convert.ToInt32( textBox1.Text.Trim());
            foreach (ListViewItem it in listView1.Items)
            {
                if (Convert.ToInt32( it.SubItems[1].Text.Trim()) == searchValue)
                {
                    it.SubItems[2].Text = textBox2.Text;
                    it.SubItems[3].Text = comboBox1.Text;
                    it.SubItems[4].Text = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                    it.SubItems[5].Text = listBox2.Items.Count.ToString();
                    button4_Click(sender, e);
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công.");
                    return;
                }
            }
            ListViewItem item =new ListViewItem(new string[6]); 
            item.SubItems[1].Text = textBox1.Text;
            item.SubItems[2].Text = textBox2.Text;
            item.SubItems[3].Text = comboBox1.Text;
            item.SubItems[4].Text = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            item.SubItems[5].Text = listBox2.Items.Count.ToString();
            listView1.Items.Add(item);
            button4_Click(sender, e);
            MessageBox.Show("Thêm sinh viên thành công.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            { 
            ListViewItem item = listView1.SelectedItems[0];
            
                textBox1.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[2].Text;
                comboBox1.Text = item.SubItems[3].Text;
                if (item.SubItems[4].Text == radioButton1.Text)
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Add("Cơ sở dữ liệu");
            listBox1.Items.Add("Cơ sở DL NC");
            listBox1.Items.Add("PTTK Hệ thống thông tin");
        }
    }
}
