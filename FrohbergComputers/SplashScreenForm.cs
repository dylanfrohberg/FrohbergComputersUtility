using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FrohbergComputers
{
    public partial class SplashScreenForm : Form
    {
        private System.Windows.Forms.Timer timer;

        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblLoading = new Label();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("AniMe Matrix - MB_EN", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoading.Location = new Point(487, 393);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(494, 25);
            lblLoading.TabIndex = 0;
            lblLoading.Text = "Loading System Information...";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.icons8_rotating_parts_hazard_100;
            pictureBox1.Image = Properties.Resources.icons8_rotating_parts_hazard_100;
            pictureBox1.InitialImage = Properties.Resources.icons8_rotating_parts_hazard_100;
            pictureBox1.Location = new Point(685, 294);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 96);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // SplashScreenForm
            // 
            ClientSize = new Size(1468, 822);
            Controls.Add(pictureBox1);
            Controls.Add(lblLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblLoading;
        private PictureBox pictureBox1;
    }
}
