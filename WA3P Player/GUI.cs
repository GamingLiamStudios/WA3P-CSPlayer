﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WA3PGUI {
    class GUI : Form {
        public GUI(string[] files) {
            InitializeComponent();
        }
        private void Render(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.DrawString("TEST", new Font("Verdana", 20), new SolidBrush(Color.White), 110, 75);
        }
        public static void Main(string[] args) {
            Application.Run(new GUI(args));
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // GUI
            // 
            this.BackColor = SystemColors.ControlDarkDark;
            this.ClientSize = new Size(300, 200);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = "GUI";
            this.Text = "WA3P Player 0.0.2";
            this.Paint += new PaintEventHandler(Render);
            this.ResumeLayout(false);
        }
    }
}