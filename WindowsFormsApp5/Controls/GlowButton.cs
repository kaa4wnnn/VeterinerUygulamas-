using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VeterinerUygulama.Ui;

namespace VeterinerUygulama.Controls
{
    public class GlowButton : Button
    {
        float hover;
        float hoverTarget;
        readonly Timer animTimer;

        public Color BaseColor { get; set; } = UiTheme.Accent;
        public Color HoverColor { get; set; } = UiTheme.AccentGlow;
        public int CornerRadius { get; set; } = 8;

        public GlowButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.Transparent;
            ForeColor = UiTheme.Text;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(72, 34);
            Cursor = Cursors.Hand;
            TabStop = true;

            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);

            animTimer = new Timer { Interval = 16 };
            animTimer.Tick += AnimTimer_Tick;

            MouseEnter += (s, e) => { hoverTarget = 1f; animTimer.Start(); };
            MouseLeave += (s, e) => { hoverTarget = 0f; animTimer.Start(); };
            MouseDown += (s, e) => Invalidate();
            MouseUp += (s, e) => Invalidate();
        }

        void AnimTimer_Tick(object sender, EventArgs e)
        {
            float step = 0.14f;
            if (hover < hoverTarget)
                hover = Math.Min(hover + step, hoverTarget);
            else if (hover > hoverTarget)
                hover = Math.Max(hover - step, hoverTarget);

            Invalidate();

            if (Math.Abs(hover - hoverTarget) < 0.01f)
            {
                hover = hoverTarget;
                if (hoverTarget == 0f)
                    animTimer.Stop();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Color fill = Lerp(BaseColor, HoverColor, hover);
            Color border = Lerp(UiTheme.Border, UiTheme.BorderHover, hover);

            if (ClientRectangle.Contains(PointToClient(MousePosition)) && MouseButtons == MouseButtons.Left)
                fill = ControlPaint.Dark(fill, 0.04f);

            using (GraphicsPath path = RoundedRect(rect, CornerRadius))
            using (SolidBrush brush = new SolidBrush(fill))
            using (Pen pen = new Pen(border))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }

            if (hover > 0.05f)
            {
                using (GraphicsPath glow = RoundedRect(rect, CornerRadius))
                using (Pen glowPen = new Pen(Color.FromArgb((int)(40 * hover), HoverColor), 2f))
                {
                    e.Graphics.DrawPath(glowPen, glow);
                }
            }

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                rect,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine);
        }

        static Color Lerp(Color a, Color b, float t)
        {
            t = Math.Max(0f, Math.Min(1f, t));
            return Color.FromArgb(
                (int)(a.R + (b.R - a.R) * t),
                (int)(a.G + (b.G - a.G) * t),
                (int)(a.B + (b.B - a.B) * t));
        }

        static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int r = Math.Max(0, Math.Min(radius, Math.Min(bounds.Width, bounds.Height) / 2));
            GraphicsPath path = new GraphicsPath();
            int d = r * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                animTimer?.Dispose();
            base.Dispose(disposing);
        }
    }
}
