using System;
using System.Threading;
using System.Windows.Forms;

namespace LTTQ
{
    public partial class Bai01 : Form
    {
        int counter = 2;
        public Bai01()
        {
            InitializeComponent();            
        }
        private void LogEvent(string eventName)
        {          
            ListBox1.Items.Add(eventName);
            ListBox1.TopIndex = ListBox1.Items.Count - 1;
        }
        private void Bai01_Load(object sender, System.EventArgs e)
        {
            MessageBox.Show("Chào mừng đến Bai01...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LogEvent("Sự kiện 1: Load (Trước khi chạy form)");
        }

        private void Bai01_Shown(object sender, System.EventArgs e)
        {
            LogEvent($"Sự kiện {counter++}: Shown (Sau khi form được load)");
        }

        private void Bai01_Activated(object sender, EventArgs e)
        {
            LogEvent($"Sự kiện {counter++}: Activated (Khi form được kích hoạt)");
        }

        private void Bai01_Deactivate(object sender, EventArgs e)
        {
            LogEvent($"Sự kiện {counter ++}: Deactivate (Khi form bị mất tiêu điểm)");
        }

        private void Bai01_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent($"Sự kiện {counter++}: FormClosing (Khi form đang đóng)");
        }

        private void Bai01_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogEvent($"Sự kiện {counter++}: FormClosed (Sau khi form đã đóng)");
            MessageBox.Show("Tạm biệt! Hẹn gặp lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
