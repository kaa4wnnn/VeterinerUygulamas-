using System.Drawing;
using System.Windows.Forms;
using VeterinerUygulama.Ui;

namespace VeterinerUygulama.Controls
{
    public class ModernTextBox : TextBox
    {
        public ModernTextBox()
        {
            BorderStyle = BorderStyle.None;
            BackColor = UiTheme.InputBg;
            ForeColor = UiTheme.Text;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        }
    }
}
