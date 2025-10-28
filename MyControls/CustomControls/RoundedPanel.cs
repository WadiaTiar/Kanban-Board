using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace KanbanBoard.CustomControls
{ 

    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 20; // default radius

        public RoundedPanel()
        {
            this.BackColor = Color.Gray;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // top-left
                path.AddArc(Width - CornerRadius - 1, 0, CornerRadius, CornerRadius, 270, 90); // top-right
                path.AddArc(Width - CornerRadius - 1, Height - CornerRadius - 1, CornerRadius, CornerRadius, 0, 90); // bottom-right
                path.AddArc(0, Height - CornerRadius - 1, CornerRadius, CornerRadius, 90, 90); // bottom-left
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
    }

}
