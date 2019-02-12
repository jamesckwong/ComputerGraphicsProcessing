using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace CGPproject
{
    public partial class XORDrawing : Form
    {
        Rectangle aRect;
        Rectangle anEllipse;
        Rectangle moving;
        int x = 0, y = 0;
        Graphics g;

        public XORDrawing()
        {
            //InitializeComponent();
            // set up the rectangle objects using client (form) coordinates
            aRect = new Rectangle(100, 100, 200, 200);
            anEllipse = new Rectangle(150, 150, 200, 100);
            moving = new Rectangle(x, y, 10, 10);

            // size and position the frame
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            // Create a red brush
            Brush redBrush = new SolidBrush(Color.Red);
            // Fill rectangle 
            g.FillRectangle(redBrush, aRect);
            // Create a green brush
            Brush greenBrush = new SolidBrush(Color.Green);
            // Fill ellipse 
            g.FillEllipse(greenBrush, anEllipse);

            while ( x < 500)
            {
                moving.Location = this.PointToScreen(new Point(x, y));
                ControlPaint.FillReversibleRectangle(moving, Color.Red);
                Thread.Sleep(10);
                ControlPaint.FillReversibleRectangle(moving, Color.Red);
                x++;
                y++;


            }
        }
    }
       

    public class XORDemo
    {
        public static void Main()
        {
            Application.Run(new XORDrawing());
        }
    }
}
