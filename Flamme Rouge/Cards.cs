using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flamme_Rouge
{
    /// <summary>
    /// class for the cards used in the game
    /// </summary>
    public class Cards
    {
        private int _numb;
        private string _type;
        
        /// <summary>
        /// constructor that initialises the values to the cards class
        /// </summary>
        /// <param name="number"></param>
        /// <param name="type"></param>
        public Cards(int number, string type)
        {
            _numb = number;_type = type;
        }

        /// <summary>
        /// gets and sets the value of the number
        /// </summary>
        public int Value
        {
            get { return _numb; }
            set { _numb = value; }
        }
        /// <summary>
        /// gets and sets the value of the type of card
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// gets the points used to move characters in the game
        /// </summary>
        public int Sc
        {
            get
            {
                return _numb;
            }
        }
    }
}