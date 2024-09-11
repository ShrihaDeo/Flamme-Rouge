using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flamme_Rouge
{/// <summary>
/// the class for the sprinter deck of cards
/// </summary>
    public class SprinterDeck 
    {
        //variables used in the class

        public List<Cards> recycleList;
        private List<Cards> cardsList;
        private Random _rand;
        private int _nextCard;
        const string type = "Sprinteur";
        List<int> sValues = new List<int> { 2, 3, 4, 5, 9 };

        /// <summary>
        /// constructor that initialises the values of the sprinter deck of cards
        /// </summary>
        public SprinterDeck() 
        {
            recycleList = new List<Cards>();
            cardsList = new List<Cards>();
            for (int j = 0; j < 1; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (sValues.Contains(i))
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
        /// <param name="c"></param>
        public void RecycleCards(Cards c)
        {
            recycleList.Add(c);
            Console.WriteLine(c.Value.ToString());

            //adds the cards in the recycle list to the deck
            if (cardsList.Count < 4)
            {
                foreach (Cards card in recycleList)
                {
                    cardsList.Add(card);
                }
            }
        }


        /// <summary>
        /// shuffles all the cards that are added to the deck
        /// </summary>
        public void ShuffleDeck()
        {
            int index1 = 0;
            int index2 = 0;
            Cards temp;
            for (int i = 1; i <= 500; i++)
            {
                index1 = _rand.Next(cardsList.Count);
                index2 = _rand.Next(cardsList.Count);
                temp = cardsList[index1];
                cardsList[index1] = cardsList[index2];
                cardsList[index2] = temp;
            }
        }

        /// <summary>
        /// deals the cards in the list
        /// </summary>
        /// <returns></returns>
        public Cards DealCard()
        {
            //checks if the cards are available
            if (_nextCard < cardsList.Count)
            {
                Cards indexcard = cardsList[_nextCard];
                _nextCard++;
                return indexcard;
            }
            else
            {
                _nextCard= 0;
                Cards indexcard = cardsList[_nextCard];
                _nextCard++;
                return indexcard; 
            }
        }
            

        
    }
}
