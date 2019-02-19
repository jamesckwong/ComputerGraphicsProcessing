using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace Test
{
    public partial class Flicker : Form
    {
        Rectangle rect;
        int x = 0;
        int y = 200;

        public Flicker()
        {
            //InitializeComponent();
            // Position the form
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            // Size the form
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 400;
            this.Height = 400;
            // Create the small rectangle objects using client (form) coordinates
 
            rect = new Rectangle(x, y, 50, 50);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Create a black pen and white and a red brush
            Pen blackPen = new Pen(Color.Black);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush whiteBrush = new SolidBrush(Color.White);
            // Define a font for writing
            Font myFont = new System.Drawing.Font("Helvetica", 9);
/*
            while(x<150 && y < 300 )
            {
                
                // Define and fill large rectangle background 
                g.FillRectangle(whiteBrush, 0, 0, 400, 400);
                // Redefine the position of the small rectangle
                rect.Location = new Point(x, y);
                // Draw small rectangle in new position 
                g.DrawRectangle(blackPen, rect);
                // Display message always in same position
                g.DrawString("Moving rectangle", myFont, redBrush, 150, 150);
                x++;
                y++;
                Thread.Sleep(10);
                


            }
  */
            while (true)
            {
                // Define and fill large rectangle background 
                g.FillRectangle(whiteBrush, 0, 0, 400, 400);
                // Redefine the position of the small rectangle
                rect.Location = new Point(x, y);
                // Draw small rectangle in new position 
                g.DrawRectangle(blackPen, rect);
                // Display message always in same position
                g.DrawString("Moving rectangle", myFont, redBrush, 150, 150);
                x++;
                y++;
                Thread.Sleep(10);


                if (x > 150)
                {
                    x++;
                    y--;
                }
                else if (x < 150)
                {
                    x++;
                    y--;
                }
                else if (x > 300)
                {
                    x++;
                    y--;
                }
                else if (x > 150)
                {
                    x++;
                    y--;
                }
              
                 
            
            }

                
                
           
            }
         
        }
    }







