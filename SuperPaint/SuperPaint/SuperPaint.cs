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

        private double getAngle(double thisX, double thisY)
        {
            if (thisX < 0)
            {
                return 90 + Math.Atan(thisY / thisX) * (180 / Math.PI);
            }
            else if(thisX > 0)
            {
                return 270 + Math.Atan(thisY / thisX) * (180 / Math.PI);
            }
            else if (thisY < 0)
            {
                return 180;
            }
            else
            {
                return 0;
            }


        }

        private int getColor(double angle)
        {
            if (angle < 60 || angle > 300)
            {
                return 255;
            }
            else if (angle < 120 || angle > 240)
            {
                return (int)Map(Math.Abs(angle - 180), 60, 120, 0, 255);
            }
            else
            {
                return 0;
            }
        }

        private void FrmColors_Load(object sender, EventArgs e)
        {
            PictureBox chromaticCircle = picDrawing;
            for(int i = 0; i < chromaticCircle.Width * chromaticCircle.Height; i++)
            {
                chromatic.Add(Color.White);
            }

            int radius = chromaticCircle.Width / 2 - 10;
            int midX = chromaticCircle.Width / 2;
            int midY = chromaticCircle.Height / 2;

            for (int i = 0; i < chromatic.Count; i++)
            {
                int thisX = i % chromaticCircle.Width;
                int thisY = i / chromaticCircle.Width;
                if (Math.Sqrt(Math.Pow(Math.Abs(midX - thisX), 2) + Math.Pow(Math.Abs(midY - thisY), 2)) < radius)
                {
                    int r, g, b;

                    b = getColor((getAngle(midX - thisX, midY - thisY) + 240) % 360);
                    g = getColor((getAngle(midX - thisX, midY - thisY) + 000) % 360);
                    r = getColor((getAngle(midX - thisX, midY - thisY) + 120) % 360);


                    chromatic[i] = Color.FromArgb(r, g, b);
                }
                else
                {
                    chromatic[i] = Color.Transparent;
                }
            }

            chromaticCircle.Refresh();

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

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            //picDrawing.Refresh();
        }

        private void picDrawing_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picDrawing_Click(object sender, EventArgs e)
        {
            Point me = ((MouseEventArgs)e).Location;
            lblHexaColor.Text = $"{me.X} {me.Y}";

            chromatic[me.Y * picDrawing.Width + me.X] = Color.White;

            picDrawing.Refresh();
        }

        private void picDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            //Point me = ((MouseEventArgs)e).Location;
            //lblHexaColor.Text = $"{me.X} {me.Y}";
        }

        private void picDrawing_MouseLeave(object sender, EventArgs e)
        {
            //lblHexaColor.Text = $"{Cursor.Position.X - picDrawing.Location.X} {Cursor.Position.Y - picDrawing.Location.Y}";
        }
    }
}
