﻿using System;
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
            AbsoluteXValue.Text = XCoordinatesToRatio(Cursor.Position.X).ToString();
            AbsoluteYValue.Text = YCoordinatesToRatio(Cursor.Position.Y).ToString();
        }
        private void CoordTimer_Tick(object sender, EventArgs e)
        {
            xValue.Invoke(new labelChanger(UpdateCoords));
        }
        public static ushort XCoordinatesToRatio(int inputX ) {
            int minX= SystemInformation.VirtualScreen.X; //the leftmost coord possible for x

            int inputXModified = inputX;
                inputXModified += -1*minX;

            int screenWidth = SystemInformation.VirtualScreen.Width;
            ushort newX = 0;
            if (inputX > minX+screenWidth ||  inputX < minX )
            {
                return 0;
                throw new Exception("Invalid input");
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
                throw new Exception("Invalid input");
            }
            newY = (ushort)(((double)inputYModified) * (((double)ushort.MaxValue) / ((double)(screenHeight - 1))));
            return newY;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
