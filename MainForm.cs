using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorLocation
{
    public partial class MainForm : Form
    {
        Timer CoordTimer = new Timer();
        public delegate void labelChanger();
        public MainForm()
        {
            InitializeComponent();

            CoordTimer.Tick += CoordTimer_Tick;
            //60fps would be 16.677~ fast enough for me.
            CoordTimer.Interval = 20;
            CoordTimer.Start();
        }
        public void UpdateCoords()
        {
            yValue.Text = Cursor.Position.Y.ToString();
            xValue.Text = Cursor.Position.X.ToString();
        }
        private void CoordTimer_Tick(object sender, EventArgs e)
        {
            xValue.Invoke(new labelChanger(UpdateCoords));
        }
    }
}
