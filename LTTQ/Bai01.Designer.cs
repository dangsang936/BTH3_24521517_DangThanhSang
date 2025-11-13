namespace LTTQ
{
    partial class Bai01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 20;
            this.ListBox1.Location = new System.Drawing.Point(29, 25);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(707, 404);
            this.ListBox1.TabIndex = 0;
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBox1);
            this.Name = "Bai01";
            this.Text = "Bài 1";
            this.Activated += new System.EventHandler(this.Bai01_Activated);
            this.Deactivate += new System.EventHandler(this.Bai01_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai01_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bai01_FormClosed);
            this.Load += new System.EventHandler(this.Bai01_Load);
            this.Shown += new System.EventHandler(this.Bai01_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox1;
    }
}

