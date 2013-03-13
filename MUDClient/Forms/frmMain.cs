using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using MUDClient.Extensions;

namespace MUDClient.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            rtbMain.Disable(txtInput);
            rtbSide.Disable(txtInput);
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            WriteLineToMain("[ForeverMUD] Loading, please wait..");
            WriteLineToMain("Version 1.0.0.0", Color.Lime);
            WriteLineToMain("");
            WriteLineToMain("Testing side write..");

            WriteLineToSide("Health  100/100");
            WriteLineToSide("Mana    20/20");
            WriteLineToSide("Moves   500/500");
            WriteLineToSide("");
            WriteLineToSide("Gold:   1,250,356", Color.Gold);
        }

        #region Main Display
        public void WriteLineToMain(string s)
        {
            WriteToMain(s + "\n", Color.White);
        }

        public void WriteLineToMain(string s, Color color)
        {
            WriteToMain(s + "\n", color);
        }

        public void WriteToMain(string s)
        {
            WriteToMain(s, Color.White);
        }

        public void WriteToMain(string s, Color color)
        {            
            rtbMain.AppendText(s, color);
            rtbMain.ScrollToBottom();
        }

        public void ResetMain()
        {
            rtbMain.ResetText();
        }
        #endregion

        #region Side Display
        public void WriteLineToSide(string s)
        {
            WriteToSide(s + "\n", Color.White);
        }

        public void WriteLineToSide(string s, Color color)
        {
            WriteToSide(s + "\n", color);
        }

        public void WriteToSide(string s)
        {
            WriteToSide(s, Color.White);
        }

        public void WriteToSide(string s, Color color)
        {
            rtbSide.AppendText(s, color);
            rtbMain.ScrollToBottom();
        }

        public void ResetSide()
        {
            rtbSide.ResetText();
        }
        #endregion

        #region Form Input
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp) rtbMain.ScrollLineUp();
            else if (e.KeyCode == Keys.PageDown) rtbMain.ScrollLineDown();
            else if (e.KeyCode == Keys.Home) rtbMain.ScrollToTop();
            else if (e.KeyCode == Keys.End) rtbMain.ScrollToBottom();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessInput(txtInput.Text);
                txtInput.Text = "";
                e.Handled = true;
            }
        }        
        #endregion

        #region Input Processing
        private void ProcessInput(string s)
        {
            WriteLineToMain("");
            WriteLineToMain("> " + s, Color.Gray);

            if (s == "loop")
            {
                for (int i = 0; i < 20; i++)
                {
                    WriteLineToMain(string.Format("Looping {0} of {1}", i, 20));
                }
            }
        }
        #endregion        
    }
}
