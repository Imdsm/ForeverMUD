using System.Drawing;
using System.Windows.Forms;

namespace MUDClient.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        public static void Disable(this Control control, Control focusTarget)
        {
            control.TabStop = false;
            control.BackColor = control.BackColor;
            control.Cursor = Cursors.Arrow;
            control.Enter += delegate { focusTarget.Focus(); };
        }
    }
}
