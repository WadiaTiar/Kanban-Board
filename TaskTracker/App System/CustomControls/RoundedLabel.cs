using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TaskTracker.CustomControls
{
    public class RoundedLabel : Label
    {
        public int CornerRadius { get; set; }
        public ContentAlignment TextAlignCustom { get; set; }

        public RoundedLabel()
        {
            this.DoubleBuffered = true;
            this.CornerRadius = 10;
            this.BackColor = Color.LightGray;
            this.ForeColor = Color.Black;
            this.Text = "Rounded Label";
            //this.TextAlign = ContentAlignment.MiddleCenter;
            this.AutoSize = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define curved path
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, CornerRadius))
            {
                // Set control region to match the curved shape
                this.Region = new Region(path);

                using (Brush brush = new SolidBrush(this.BackColor))
                    e.Graphics.FillPath(brush, path);

                using (Brush textBrush = new SolidBrush(this.ForeColor))
                {
                    StringFormat sf = new StringFormat
                    {
                        //Alignment = StringAlignment.Center,
                        //LineAlignment = StringAlignment.Center
                    };
                    //e.Graphics.DrawString(this.Text, this.Font, textBrush, this.ClientRectangle, sf);
                }
            }

            TextFormatFlags flags = TextFormatFlags.Default;

            switch (TextAlignCustom)
            {
                case ContentAlignment.TopLeft: flags = TextFormatFlags.Top | TextFormatFlags.Left; break;
                case ContentAlignment.TopCenter: flags = TextFormatFlags.Top | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.TopRight: flags = TextFormatFlags.Top | TextFormatFlags.Right; break;
                case ContentAlignment.MiddleLeft: flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left; break;
                case ContentAlignment.MiddleCenter: flags = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.MiddleRight: flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Right; break;
                case ContentAlignment.BottomLeft: flags = TextFormatFlags.Bottom | TextFormatFlags.Left; break;
                case ContentAlignment.BottomCenter: flags = TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.BottomRight: flags = TextFormatFlags.Bottom | TextFormatFlags.Right; break;
            }


            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, flags);
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
