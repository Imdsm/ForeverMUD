using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MUDClient.Extensions
{
    public static class RichTextBoxExtensions
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private const int WM_VSCROLL = 0x115;

        private const int SB_LINEUP = 0;
        private const int SB_LINEDOWN = 1;
        private const int SB_PAGEUP = 2;
        private const int SB_PAGEDOWN = 3;
        private const int SB_TOP = 6;
        private const int SB_BOTTOM = 7;

        public static void ScrollLineUp(this RichTextBox box)
        {
            SendMessage(box.Handle, WM_VSCROLL, (IntPtr)SB_LINEUP, IntPtr.Zero);
        }

        public static void ScrollLineDown(this RichTextBox box)
        {
            SendMessage(box.Handle, WM_VSCROLL, (IntPtr)SB_LINEDOWN, IntPtr.Zero);
        }

        public static void ScrollToTop(this RichTextBox box)
        {
            SendMessage(box.Handle, WM_VSCROLL, (IntPtr)SB_TOP, IntPtr.Zero);
        }

        public static void ScrollToBottom(this RichTextBox box)
        {
            SendMessage(box.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
        }
        
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
