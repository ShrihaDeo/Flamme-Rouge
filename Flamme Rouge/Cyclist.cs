using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Flamme_Rouge
{
    /// <summary>
    /// class for the cyclist
    /// </summary>
    public class Cyclist
    {
        public int _x;
        private int _y;
        public SolidBrush brush;
        public int squareWidth;
        bool firstPlay;
        bool isTopRow;
        int PlayerS;

        /// <summary>
        /// constructor that initialises the values of the cyclist
        /// </summary>
        /// <param name="isSprinteur"></param>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="pictureBoxWidth"></param>
        public Cyclist(bool isSprinteur, int startX, int startY, int pictureBoxWidth, Color c)
        {
            brush = new SolidBrush(c);
            
            if (startY == 0)
            {
                isTopRow = true;
            }
            XPos = startX * (pictureBoxWidth / 30);
            firstPlay = true;
            PlayerS = 0;
        }
        /// <summary>
        /// draws the cyclist at the correct position
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pictureBox1"></param>
        public void DrawCyclist(Graphics g, PictureBox pictureBox1)
        {
            int barHeight = 120; // Height of the green bar
            int barY = (pictureBox1.Height - barHeight) / 2; // Position the bar in the middle vertically.
            squareWidth = pictureBox1.Width / 30;
            YPos = barY + 17;
            if (firstPlay)
            {
                XPos += squareWidth / 4;
                firstPlay = false;
            }
            if (!isTopRow)
            {
                YPos += squareWidth;
            }
            YPos += squareWidth / 4 + 5;
            int endX = (squareWidth / 4) * 2;
            int endY = (squareWidth / 4) * 2;
            g.FillEllipse(brush, XPos, YPos, endX, endY);

        }
        /// <summary>
        /// gets and sets the position of the cyclist Xvalue
        /// </summary>
        public int XPos
        {
            get { return _x; }
            set { _x = value; }
        }
        /// <summary>
        /// gets and sets the position of the cyclist Yvalue
        /// </summary>
        public int YPos
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// moves the cyclist according to the mountain values
        /// </summary>
        /// <param name="x"></param>
        public void MoveObject(int x)
        {
            if (_x > 200 && _x < 450) //values of the positions where the mountains ascend
            {
                if (x > 5)
                {
                    x = 5;
                }

            }
            else if (_x > 460 && _x <= 600)//values of the positions where mountains descend
            {
                if (x < 5)
                {
                    x = 5;
                }

            }
            _x += x * squareWidth;
        }


        /// <summary>
        /// saves the contents of the cyclist in a CSV format
        /// </summary>
        /// <returns>the csv format information of the cyclist</returns>
        public string ToCSVString ()
        {
            return _x.ToString() + "," + _y.ToString() + "," + brush.Color.ToString(); 
        }
    }
}
