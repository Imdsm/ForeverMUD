using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUDWinForms.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FixBackgroundColor();

            LogWindow = new LogWindow();
            LogWindow.MdiParent = this;
            LogWindow.Show();

            //this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void FixBackgroundColor()
        {
            foreach (Control ctl in this.Controls)
            {
                try { ((MdiClient)ctl).BackColor = this.BackColor; }
                catch (InvalidCastException) { }
            }
        }

        public Form LogWindow { get; private set; }
    }
}
