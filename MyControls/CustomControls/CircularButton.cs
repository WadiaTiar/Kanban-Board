using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.CustomControls
{
    public class CircularButton : Button
    {
        public Image ButtonImage { get; set; } = null;

        public CircularButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.SteelBlue;
            this.ForeColor = Color.White;
            this.Size = new Size(100, 100);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.Resize += (s, e) => MakeCircularRegion();
        }

        private void MakeCircularRegion()
        {
            int diameter = Math.Min(this.Width, this.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, diameter - 1, diameter - 1);
                this.Region = new Region(path);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // High-quality rendering
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            // Draw background
            using (Brush brush = new SolidBrush(this.BackColor))
                pevent.Graphics.FillEllipse(brush, ClientRectangle);

            // Optional: Draw border
            using (Pen pen = new Pen(Color.DarkGray, 1))
                pevent.Graphics.DrawEllipse(pen, 0, 0, Width - 1, Height - 1);

            // Draw image (centered)
            if (ButtonImage != null)
            {
                Size imgSize = new Size(32, 32);
                Point imgLocation = new Point((Width - imgSize.Width) / 2, (Height - imgSize.Height) / 2);
                pevent.Graphics.DrawImage(ButtonImage, new Rectangle(imgLocation, imgSize));
            }

            // Draw text (bottom centered)
            TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.Bottom);
        }
    }

}
