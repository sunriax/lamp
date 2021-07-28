using RaGae.App.Lamp.Domain.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms
{
    public partial class UserControlLevel : UserControl
    {
        public UserControlLevel(Led led)
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;

            labelLevel.Text = led.Level.ToString();
            labelAlpha.Text += led.A;
            pictureBox.BackColor = Color.FromArgb(led.R, led.G, led.B);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen p = new Pen(Brushes.Gray, 3);

            dev.DrawLine(p,
                new Point
                {
                    X = 0,
                    Y = 0
                },
                new Point
                {
                    X = pictureBox.Width,
                    Y = 0
                });

            dev.DrawLine(p,
                new Point
                {
                    X = 0,
                    Y = 0
                },
                new Point
                {
                    X = 0,
                    Y = pictureBox.Height
                });

            p.Color = Color.LightGray;

            dev.DrawLine(p,
                new Point
                {
                    X = pictureBox.Width - (int)p.Width + 2,
                    Y = 0
                },
                new Point
                {
                    X = pictureBox.Width - (int)p.Width + 2,
                    Y = pictureBox.Height
                });

            dev.DrawLine(p,
                new Point
                {
                    X = 0,
                    Y = pictureBox.Height - (int)p.Width + 2
                },
                new Point
                {
                    X = pictureBox.Width,
                    Y = pictureBox.Height - (int)p.Width + 2
                });
        }

        private void UserControlLevel_Resize(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }
    }
}
