using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    /// <summary>
    /// class for the 
    /// </summary>
    public class RouleurDeck 
    {
        public List<Cards> recycleList;
        private List<Cards> cardsList;
        private Random _rand;
        private int _nextCard;
        const string type = "Rouleur";
        List<int> rValue = new List<int> { 3, 4, 5, 6, 7 };

        //constructor that initialises the values of the rouleur deck
        public RouleurDeck()
        {
            recycleList = new List<Cards>();
            cardsList = new List<Cards>();
            ///Makes 3 copies of each card
            for (int j = 0; j < 3; j++)
            {
                ///Runs through 0 to 10 and only adds card to list if it is of sprinteur value numbers
                for (int i = 0; i < 10; i++)
                {
                    if (rValue.Contains(i))
                    {
                        cardsList.Add(new Cards(i, type));
                    }
                }
            }
            _rand = new Random();
            ShuffleDeck();
            _nextCard = 0;
        }

        /// <summary>
        /// recycles the cards in the deck
        /// </summary>
        /// <param name="c">the cards being recycled</param>
        public void RecycleCards(Cards c)
        {
            recycleList.Add(c);
            Console.WriteLine(c.Value.ToString());

            //checks if the cards list has less cards
            if (cardsList.Count < 4)
            {
                //adds cards to cardlist to recycle
                foreach (var card in recycleList)
                {
                    cardsList.Add(card);
                }
            }
        }
        /// <summary>
        /// shuffles the cards in the deck
        /// </summary>
        public void ShuffleDeck()
        {
            int i1 = 0;
            int i2 = 0;
            Cards temp;
            for (int i = 1; i <= 500; i++)
            {
                i1 = _rand.Next(cardsList.Count);
                i2 = _rand.Next(cardsList.Count);
                temp = cardsList[i1];
                cardsList[i1] = cardsList[i2];
                cardsList[i2] = temp;
            }
        }
        /// <summary>
        /// deals the cards 
        /// </summary>
        /// <returns>the index number after dealing the card</returns>
        public Cards DealCard()
        {
            //checks if the cards list has enough cards
            if (_nextCard < cardsList.Count)
            {
                Cards ind = cardsList[_nextCard];
                _nextCard++;
                return ind;
            }
            //resets to ensure that there is enough cards
            else
            {
                _nextCard = 0;
                Cards ind = cardsList[_nextCard];
                _nextCard++;
                return ind;
            }

        }
        

    }
}
