using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{/// <summary>
/// class for the squares in the game track
/// </summary>
    public class Square
    { 
        public Square()
        {
        }

        /// <summary>
        /// draws the squares and arranges them together to make a track
        /// </summary>
        /// <param name="g">the graphics object passed</param>
        /// <param name="pictureBox1">the picturebox passed</param>
        public void DrawSquare(Graphics g, PictureBox pic)
        {
            SolidBrush brush = new SolidBrush(Color.AliceBlue);
            int bH = pic.Height; // Height of the green bar
            int bY = bH / 5; // Position the bar in the middle vertically.
            int bN = 0;
            int x = 0;
            int y = bY + 17;
            int sWidth = pic.Width / 30;
            Pen pen = new Pen(Color.DarkBlue, (float)0.1);
            //For each row to draw
            for (int row = 0; row < 2; row++)
            {
                //For each column to draw
                for (int c = 0; c < 30; c++)
                {
                    pen.Width = (float)0.1;
                    
                    //mountain colors
                    if (bN >= 10 && bN <= 14)
                    {
                        brush.Color = Color.LightGray;
                    }
                    //slope colors
                    else if (bN >= 15 && bN <= 19)
                    {
                        brush.Color = Color.LightSalmon;
                    }
                    //regular track colors
                    else
                    {
                        brush.Color = Color.LightSkyBlue;
                    }
                    //fills a square
                    g.FillRectangle(brush, x, y, sWidth, sWidth);

                    // Draws a square
                    pen.Color = Color.White;
                    g.DrawRectangle(pen, x, y, sWidth, sWidth);
                    
                    // Divides the race track to 6 equal sections 
                    if (c % 6 == 0 && c > 0)
                    {
                        pen.Width = 4;
                        int lineX = c * sWidth;
                        g.DrawLine(pen, lineX, bY-20, lineX, bY + bH);
                    }

                    bN++;
                    // Moves x position 
                    x += sWidth;
                }
                bN = 0;
                // Moves position y down 
                y += sWidth;
                x = 0;
            }
        }
    }
}
