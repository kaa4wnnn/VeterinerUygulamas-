using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VeterinerUygulama.Ui;

namespace VeterinerUygulama.Controls
{
    public class ThemePanel : Panel
    {
        public string HeaderText { get; set; }
        public int CornerRadius { get; set; } = 10;
        public bool ShowHeader { get; set; } = true;

        public ThemePanel()
        {
            BackColor = UiTheme.Surface;
            ForeColor = UiTheme.TextMuted;
            Font = UiTheme.FontCaption();
            Padding = new Padding(14, 48, 14, 14);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = RoundedRect(bounds, CornerRadius))
            using (Pen border = new Pen(UiTheme.Border))
            using (SolidBrush fill = new SolidBrush(UiTheme.Surface))
            {
                e.Graphics.FillPath(fill, path);
                e.Graphics.DrawPath(border, path);
            }

            if (ShowHeader && !string.IsNullOrEmpty(HeaderText))
            {
                using (SolidBrush accent = new SolidBrush(UiTheme.Accent))
                {
                    e.Graphics.FillRectangle(accent, 14, 16, 3, 16);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    HeaderText.ToUpperInvariant(),
                    Font,
                    new Rectangle(26, 12, Width - 40, 24),
                    UiTheme.TextMuted,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            }
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
    }
}
