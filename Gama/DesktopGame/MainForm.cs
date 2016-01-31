using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var myBrush = new SolidBrush(Color.Red);
            var formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, this.Width, this.Height));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void DrawBoard(int countHor, int sizeVer, int margin)
        {
            
        }
    }
}
