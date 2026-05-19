using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VeterinerUygulama.Ui;

namespace VeterinerUygulama.Controls
{
    public class InputFieldPanel : Panel
    {
        bool focused;

        public InputFieldPanel()
        {
            BackColor = UiTheme.InputBg;
            Padding = new Padding(10, 8, 10, 8);
            DoubleBuffered = true;
            SetStyle(ControlStyles.Selectable, false);
            TabStop = false;
        }

        public void SetFocused(bool value)
        {
            if (focused == value) return;
            focused = value;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Color border = focused ? UiTheme.Accent : UiTheme.Border;

            using (GraphicsPath path = new GraphicsPath())
            {
                int r = 6;
                int d = r * 2;
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                using (SolidBrush fill = new SolidBrush(UiTheme.InputBg))
                using (Pen pen = new Pen(border))
                {
                    e.Graphics.FillPath(fill, path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
