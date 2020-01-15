using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperPaint
{
    public partial class FrmColors : Form
    {
        public FrmColors()
        {
            InitializeComponent();
        }

        List<Color> chromatic = new List<Color>();

        public static double Map(double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }

        private double distAngle(int thisX, int thisY)
        {
            return Math.Atan(Math.Abs(thisX) / Math.Abs(thisY)) * (180 / Math.PI);
            /*if (thisX < 250)
            {
                if (thisY < 250)
                {
                    return 180 + 90 + (Math.Atan(Math.Abs(250.0 - thisY) / Math.Abs(250 - thisX)) * (180 / Math.PI));
                }
                else
                {
                    return 180 + (Math.Atan(Math.Abs(250.0 - thisX) / Math.Abs(250 - thisY)) * (180 / Math.PI));
                }
            }
            else if (thisX > 250)
            {
                if (thisY < 250)
                {
                    return (Math.Atan(Math.Abs(250.0 - thisX) / Math.Abs(250 - thisY)) * (180 / Math.PI));
                }
                else
                {
                    return 90 + (Math.Atan(Math.Abs(250.0 - thisY) / Math.Abs(250 - thisX)) * (180 / Math.PI));
                }
            }

            if (thisY < 250)
            {
                return 0;
            }
            else
            {
                return 180;
            }*/
        }

        /*private int getR(int thisX, int thisY)
        {
            int angle = distAngle(thisX, thisY);
            if (angle )
            {

            }
        }*/

        private void FrmColors_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 500*500; i++)
            {
                chromatic.Add(Color.White);
            }

            int radius = 500 / 2;

            for (int i = 0; i < chromatic.Count; i++)
            {
                int thisX = i % 500;
                int thisY = i / 500;
                if (Math.Sqrt(Math.Pow(Math.Abs(250 - thisX), 2) + Math.Pow(Math.Abs(250 - thisY), 2)) < radius)
                {
                    int r, g, b;

                    r = (int)Math.Abs(Map(distAngle(thisX, thisY), 0, 360, 255, 0));
                    g = 0;
                    //g = (int)Math.Abs(Map((distAngle(thisX, thisY) - 120) % 360, -120, 240, -255, 255)); ;
                    //g = (int)Map(distAngle(thisX, thisY), 120, 300, 255, 0);
                    //b = (int)Math.Abs(Map(distAngle(thisX, thisY) + 60, 60, 420, -255, 255)); ;
                    b = 0;

                    chromatic[i] = Color.FromArgb(r, g, b);
                }
            }

            picDrawing.Refresh();

            //picPickColor.
        }

        private void picPickColor_Paint(object sender, PaintEventArgs e)
        {
            foreach(Color eachColor in chromatic)
            {

            }
            //e.Graphics.DrawRectangle
        }

        private void picDrawing_Paint(object sender, PaintEventArgs e)
        {
            int radius = 500 / 2;

            for (int i = 0; i < chromatic.Count; i++)
            {
                int thisX = i % 500;
                int thisY = i / 500;
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(chromatic[i])), new Rectangle(thisX, thisY, 1, 1));
            }
        }

        private void picShowColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picLightColor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
