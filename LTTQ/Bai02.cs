using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LTTQ
{
    public partial class Bai02 : Form
    {
        Random rand = new Random();
        public Bai02()
        {
            InitializeComponent();
        }
        private void Bai02_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
            {
                int x = rand.Next(this.ClientSize.Width - 100);
                int y = rand.Next(this.ClientSize.Height - 30);
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                using (Brush brush = new SolidBrush(color)) 
                    g.DrawString("Paint Event", this.Font, brush, x, y);
            }
        }
    }
}
