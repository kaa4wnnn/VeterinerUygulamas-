using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VeterinerUygulama.Ui;

namespace VeterinerUygulama.Controls
{
    public class ModernCheckBox : CheckBox
    {
        float hover;
        readonly Timer animTimer;

        public ModernCheckBox()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.StandardClick, true);
            UpdateStyles();

            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;

            BackColor = Color.Transparent;
            ForeColor = UiTheme.Text;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cursor = Cursors.Hand;
            AutoSize = false;
            TextAlign = ContentAlignment.MiddleLeft;
            Padding = new Padding(0, 6, 0, 6);
            MinimumSize = new Size(0, 36);
            Height = 36;

            animTimer = new Timer { Interval = 16 };
            animTimer.Tick += AnimTimer_Tick;
            MouseEnter += (s, e) => animTimer.Start();
            MouseLeave += (s, e) => animTimer.Start();
        }

        void AnimTimer_Tick(object sender, EventArgs e)
        {
            float target = ClientRectangle.Contains(PointToClient(MousePosition)) ? 1f : 0f;
            if (hover < target) hover = Math.Min(hover + 0.12f, target);
            else if (hover > target) hover = Math.Max(hover - 0.12f, target);
            Invalidate();
            if (Math.Abs(hover - target) < 0.01f)
            {
                hover = target;
                if (target == 0f) animTimer.Stop();
            }
        }

        protected override void OnClick(EventArgs e)
        {
            Checked = !Checked;
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color arka = Parent != null ? Parent.BackColor : UiTheme.Surface;
            e.Graphics.Clear(arka);

            int kutu = 18;
            int boxTop = (Height - kutu) / 2;
            if (boxTop < 0) boxTop = 0;

            Rectangle box = new Rectangle(2, boxTop, kutu, kutu);
            Color border = Blend(UiTheme.Border, UiTheme.Accent, hover);
            Color fill = Checked ? UiTheme.Accent : UiTheme.InputBg;

            using (GraphicsPath path = new GraphicsPath())
            {
                int r = 5;
                int d = r * 2;
                path.AddArc(box.X, box.Y, d, d, 180, 90);
                path.AddArc(box.Right - d, box.Y, d, d, 270, 90);
                path.AddArc(box.Right - d, box.Bottom - d, d, d, 0, 90);
                path.AddArc(box.X, box.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(fill))
                using (Pen pen = new Pen(border))
                {
                    e.Graphics.FillPath(brush, path);
                    e.Graphics.DrawPath(pen, path);
                }
            }

            if (Checked)
            {
                using (Pen tick = new Pen(Color.White, 2f))
                {
                    e.Graphics.DrawLine(tick, box.X + 4, box.Y + 9, box.X + 7, box.Y + 12);
                    e.Graphics.DrawLine(tick, box.X + 7, box.Y + 12, box.Right - 4, box.Y + 5);
                }
            }

            Rectangle yaziAlani = new Rectangle(box.Right + 10, 0, Width - box.Right - 12, Height);
            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                yaziAlani,
                ForeColor,
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine |
                TextFormatFlags.EndEllipsis);
        }

        static Color Blend(Color a, Color b, float t)
        {
            t = Math.Max(0f, Math.Min(1f, t));
            return Color.FromArgb(
                (int)(a.R + (b.R - a.R) * t),
                (int)(a.G + (b.G - a.G) * t),
                (int)(a.B + (b.B - a.B) * t));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                animTimer?.Dispose();
            base.Dispose(disposing);
        }
    }
}
