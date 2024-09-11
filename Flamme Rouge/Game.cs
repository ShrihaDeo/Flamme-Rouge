using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    /// <summary>
    /// class for the track of the game
    /// </summary>
    public class GameTrack
    {
        public Square square;
        public int x;
        /// <summary>
        /// constructor that initialises the square in the track class
        /// </summary>
        public GameTrack()
        {
            square = new Square();
        }

        /// <summary>
        /// draws the track of the game
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pictureBox1"></param>
        public void DrawTrack(Graphics g, PictureBox pictureBox1)
        {
            SolidBrush brush = new SolidBrush(Color.MediumPurple);
            int barHeight = 120; 
            int barY = (pictureBox1.Height - barHeight) / 2; 
            g.FillRectangle(brush, 0, barY, pictureBox1.Width - 9, barHeight);
            x = barHeight;
            square.DrawSquare(g, pictureBox1);
        }

    }
}
