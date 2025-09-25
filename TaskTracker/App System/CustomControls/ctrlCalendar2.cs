using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker.Calendar
{
    public partial class ctrlCalendar2 : UserControl
    {
        public ctrlCalendar2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.White;

            hoverTimer.Interval = 15;
            hoverTimer.Tick += HoverTimer_Tick;

            fadeTimer.Interval = 15;
            fadeTimer.Tick += FadeTimer_Tick;
        }

        public int MonthAndYearTextSize { get; set; } = 16;
        public int DaysNameSize { get; set; } = 12;
        public int WeekDaysDesignHigh { set;  get; } = 80;

        public int TopMargin { set; get; } = 135;

        public enum WeekdaysNamesFormat
        {
            Long = 0,
            Short = 1,
            MoreShort = 2
        }

        public WeekdaysNamesFormat WeekdaysFormatOption { get; set; } = WeekdaysNamesFormat.Short;

        string[] GetWeekdays(WeekdaysNamesFormat format)
        {
            switch (format)
            {
                case WeekdaysNamesFormat.Short:
                    return new[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

                case WeekdaysNamesFormat.Long:
                    return new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

                case WeekdaysNamesFormat.MoreShort:
                    return new[] { "S", "M", "T", "W", "T", "F", "S" };

                default:
                    return new[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }; // Fallback
            }
        }

        public DateTime DisplayMonth { get; set; } = DateTime.Today;

        private Rectangle prevBtnRect, nextBtnRect;
        private bool prevHover = false, nextHover = false;
        private float prevHoverLevel = 0f, nextHoverLevel = 0f;

        private Timer hoverTimer = new Timer();

        // ===== Fade Animation Variables =====
        private Timer fadeTimer = new Timer();
        private float fadeProgress = 1f; // 1 = fully visible, 0 = fully transparent
        private DateTime targetMonth;
        private bool fadingOut = false;
        private Bitmap bufferImage; // for snapshot

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (fadeProgress < 1f)
            {
                // Draw snapshot fading out
                if (bufferImage != null)
                {
                    ColorMatrix cm = new ColorMatrix();
                    cm.Matrix33 = fadeProgress; // set alpha
                    ImageAttributes ia = new ImageAttributes();
                    ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    e.Graphics.DrawImage(bufferImage, this.ClientRectangle, 0, 0, bufferImage.Width, bufferImage.Height, GraphicsUnit.Pixel, ia);
                }
                return;
            }

            DrawCalendar(e.Graphics, DisplayMonth);
        }

        private void DrawCalendar(Graphics g, DateTime month)
        {
            var rect = this.ClientRectangle;
            g.Clear(BackColor);

            // ===== Month Name =====
            using (Font monthFont = new Font(this.Font.FontFamily, MonthAndYearTextSize, FontStyle.Bold))
            {
                string monthName = month.ToString("MMMM yyyy");
                SizeF textSize = g.MeasureString(monthName, monthFont);
                g.DrawString(monthName, monthFont, Brushes.Black, (rect.Width - textSize.Width) / 2, 10);
            }

            // ===== Navigation Buttons =====
            prevBtnRect = new Rectangle(10, 10, 40, 30);
            nextBtnRect = new Rectangle(rect.Width - 50, 10, 40, 30);           

            DrawButton(g, prevBtnRect, "◀", prevHoverLevel);
            DrawButton(g, nextBtnRect, "▶", nextHoverLevel);

            

            // ===== Days of Week =====
            int topMargin = TopMargin; // space for month title
            int cellWidth = rect.Width / 7;
            int cellHeight = (rect.Height - topMargin - 20) / 6;

            /*int cellWidth = rect.Width / 7;
            int cellHeight = (rect.Height - 60) / 7;*/

            using (Font boldFont = new Font(this.Font.FontFamily, DaysNameSize, FontStyle.Bold))
            {
                string[] days = GetWeekdays(WeekdaysFormatOption);
                for (int i = 0; i < 7; i++)
                    g.DrawString(days[i], boldFont, Brushes.Black, i * cellWidth + 5, WeekDaysDesignHigh);
            }

            // ===== Dates =====
            DateTime firstDay = new DateTime(month.Year, month.Month, 1);
            int startDay = (int)firstDay.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(month.Year, month.Month);

            using (Font dateFont = new Font(this.Font.FontFamily, 10))
            {
                int x = startDay, y = 1;
                for (int day = 1; day <= daysInMonth; day++)
                {
                    Rectangle cellRect = new Rectangle(x * cellWidth, y * cellHeight + 70, cellWidth, cellHeight);

                    // Highlight today
                    if (month.Year == DateTime.Today.Year && month.Month == DateTime.Today.Month && day == DateTime.Today.Day)
                    {
                        using (Brush todayBrush = new SolidBrush(Color.LightBlue))
                            FillRoundedRectangle(g, todayBrush, cellRect, 6);
                    }

                    g.DrawRectangle(Pens.Gray, cellRect);
                    g.DrawString(day.ToString(), dateFont, Brushes.Black, cellRect.X + 5, cellRect.Y + 5);

                    x++;
                    if (x > 6) { x = 0; y++; }
                }
            }
        }

        private void DrawButton(Graphics g, Rectangle rect, string text, float hoverAmount)
        {
            /*Color normal = Color.White;
            Color hover = Color.DodgerBlue;

            int r = (int)(normal.R + (hover.R - normal.R) * hoverAmount);
            int gC = (int)(normal.G + (hover.G - normal.G) * hoverAmount);
            int b = (int)(normal.B + (hover.B - normal.B) * hoverAmount);

            using (Brush bgBrush = new SolidBrush(Color.FromArgb(r, gC, b)))
                FillRoundedRectangle(g, bgBrush, rect, 5);

            g.DrawRectangle(Pens.Black, rect);

            Color textColor = hoverAmount > 0.5f ? Color.White : Color.Black;
            using (Brush textBrush = new SolidBrush(textColor))
                g.DrawString(text, this.Font, textBrush, rect.X + 10, rect.Y + 5);*/

            Color normal = Color.White;
            Color hover = Color.DodgerBlue;

            using (Brush bgBrush = new SolidBrush(Color.White))
                FillRoundedRectangle(g, bgBrush, rect, 5);

            g.DrawRectangle(Pens.Black, rect);

            Color textColor = hoverAmount > 0.5f ? Color.Blue : Color.Black;

            using (Font customFont = new Font("Segoe UI", 16, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(textColor))
                g.DrawString(text, customFont, textBrush, rect.X + 10, rect.Y + 2);
        }

        private void FillRoundedRectangle(Graphics g, Brush brush, Rectangle rect, int radius)
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                g.FillPath(brush, path);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (prevBtnRect.Contains(e.Location))
                StartMonthFade(DisplayMonth.AddMonths(-1));
            else if (nextBtnRect.Contains(e.Location))
                StartMonthFade(DisplayMonth.AddMonths(1));
        }

        private void StartMonthFade(DateTime newMonth)
        {
            // Take snapshot of current view
            bufferImage = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bufferImage))
                DrawCalendar(g, DisplayMonth);

            targetMonth = newMonth;
            fadingOut = true;
            fadeProgress = 1f;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadingOut)
            {
                fadeProgress -= 0.1f;
                if (fadeProgress <= 0f)
                {
                    fadeProgress = 0f;
                    fadingOut = false;
                    DisplayMonth = targetMonth;
                }
            }
            else
            {
                fadeProgress += 0.1f;
                if (fadeProgress >= 1f)
                {
                    fadeProgress = 1f;
                    fadeTimer.Stop();
                }
            }
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            bool oldPrevHover = prevHover;
            bool oldNextHover = nextHover;

            prevHover = prevBtnRect.Contains(e.Location);
            nextHover = nextBtnRect.Contains(e.Location);

            this.Cursor = (prevHover || nextHover) ? Cursors.Hand : Cursors.Default;

            if (oldPrevHover != prevHover || oldNextHover != nextHover)
                hoverTimer.Start();
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            bool needUpdate = false;

            if (prevHover && prevHoverLevel < 1f) { prevHoverLevel += 0.1f; needUpdate = true; }
            else if (!prevHover && prevHoverLevel > 0f) { prevHoverLevel -= 0.1f; needUpdate = true; }

            if (nextHover && nextHoverLevel < 1f) { nextHoverLevel += 0.1f; needUpdate = true; }
            else if (!nextHover && nextHoverLevel > 0f) { nextHoverLevel -= 0.1f; needUpdate = true; }

            if (needUpdate) Invalidate();
            else hoverTimer.Stop();
        }
    }


}
