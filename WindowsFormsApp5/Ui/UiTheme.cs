using System.Drawing;

namespace VeterinerUygulama.Ui
{
    internal static class UiTheme
    {
        public static readonly Color Bg = Color.FromArgb(14, 14, 18);
        public static readonly Color Surface = Color.FromArgb(22, 22, 30);
        public static readonly Color SurfaceRaised = Color.FromArgb(28, 28, 38);
        public static readonly Color Border = Color.FromArgb(48, 48, 64);
        public static readonly Color BorderHover = Color.FromArgb(72, 72, 96);

        public static readonly Color Text = Color.FromArgb(232, 232, 240);
        public static readonly Color TextMuted = Color.FromArgb(136, 136, 168);

        public static readonly Color Accent = Color.FromArgb(124, 92, 255);
        public static readonly Color AccentGlow = Color.FromArgb(160, 130, 255);
        public static readonly Color Cyan = Color.FromArgb(0, 212, 170);
        public static readonly Color Danger = Color.FromArgb(232, 93, 106);
        public static readonly Color DangerHover = Color.FromArgb(255, 120, 132);

        public static readonly Color InputBg = Color.FromArgb(24, 24, 34);
        public static readonly Color GridHeader = Color.FromArgb(32, 32, 44);
        public static readonly Color GridRowAlt = Color.FromArgb(20, 20, 28);
        public static readonly Color GridSelection = Color.FromArgb(48, 40, 88);

        public static Font FontUi(float size = 9.75f)
        {
            return new Font("Segoe UI", size, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static Font FontTitle(float size = 15f)
        {
            return new Font("Segoe UI Semibold", size, FontStyle.Bold, GraphicsUnit.Point);
        }

        public static Font FontCaption(float size = 8.25f)
        {
            return new Font("Segoe UI", size, FontStyle.Regular, GraphicsUnit.Point);
        }
    }
}
