using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsInput;

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
            PrimaryScreenXValue.Text = XCoordinatesToRatio(Int32.Parse(Cursor.Position.X.ToString())).ToString();
            PrimaryScreenYValue.Text = YCoordinatesToRatio(Int32.Parse(Cursor.Position.Y.ToString())).ToString();
        }
        private void CoordTimer_Tick(object sender, EventArgs e)
        {
            xValue.Invoke(new labelChanger(UpdateCoords));
        }
        public static void moveMouseToCoords(int inputX, int inputY, InputSimulator input)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            ushort newX = 0;
            ushort newY = 0;
            if (inputX > screenWidth || inputY > screenWidth || inputX < 0 || inputY < 0)
            {
                throw new Exception("Invalid input, method only works on the primary display");
            }
            newX = (ushort)(((double)inputX) * (((double)ushort.MaxValue) / ((double)(screenWidth - 1))));
            newY = (ushort)(((double)inputY) * (((double)ushort.MaxValue) / ((double)(screenHeight - 1))));

            input.Mouse.MoveMouseTo(newX, newY);

        }
        public static ushort XCoordinatesToRatio(int inputX ) {
            int minX= SystemInformation.VirtualScreen.X; //the leftmost coord possible for x

            int inputXModified = inputX;// + minX;
                inputXModified += -1*minX;

            int screenWidth = SystemInformation.VirtualScreen.Width;
            /*
            int screenWidth2 = Screen.PrimaryScreen.Bounds.Width;
            int test = SystemInformation.VirtualScreen.X;
            int test2 = SystemInformation.VirtualScreen.Y;
            */
            ushort newX = 0;
            if (inputX > minX+screenWidth ||  inputX < minX )
            {
                return 0;
                throw new Exception("Invalid input, method only works on the primary display");
            }
            newX = (ushort)(((double)inputXModified) * (((double)ushort.MaxValue) / ((double)(screenWidth-1 ))));
            return newX;
        }
        public static ushort YCoordinatesToRatio(int inputY ) { 
            int minY= SystemInformation.VirtualScreen.Y;
            int inputYModified = inputY;
                inputYModified += -1*minY;
            int screenHeight = SystemInformation.VirtualScreen.Height;
            ushort newY = 0;
            if ( inputY > minY+screenHeight||  inputY < minY)
            {
                return 0;
                throw new Exception("Invalid input, method only works on the primary display");
            }
            newY = (ushort)(((double)inputYModified) * (((double)ushort.MaxValue) / ((double)(screenHeight - 1))));
            return newY;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
