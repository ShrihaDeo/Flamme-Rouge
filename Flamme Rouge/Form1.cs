using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Flamme_Rouge
{/// <summary>
/// form code that contans all the necessary code for the game
/// </summary>
    public partial class Form1 : Form
    {
        //variables for track
        private GameTrack gametrack;
        private Square square;
        
        //variables for the cards
        private Cards ExhaustionCard;
        private List<Cards> cardList;
        private List<Cards> ExhaustionCardList1;
        private SprinterDeck SprinteurDeck1;
        private SprinterDeck SprinteurDeck2;
        private RouleurDeck RouleurDeck1;
        private RouleurDeck RouleurDeck2;

        //cyclist variables
        Cyclist SprinteurCyclist1;
        Cyclist RouleurCyclist1;
        Cyclist SprinteurCyclist2;
        Cyclist RouleurCyclist2;
        bool IS;
        int previouspos = 0;
        private List<Cyclist> cyclistList;

        public Form1()
        {
            //initialises all the variables and objects used in the game
            InitializeComponent();
            gametrack = new GameTrack();
            SprinteurDeck1 = new SprinterDeck();
            SprinteurDeck2 = new SprinterDeck();
            RouleurDeck1 = new RouleurDeck();
            RouleurDeck2 = new RouleurDeck();
            cardList = new List<Cards>();
            Graphics display = pictureBox1.CreateGraphics();
            SprinteurCyclist1 = new Cyclist(true, 4, 0, pictureBox1.Width, Color.CornflowerBlue);
            RouleurCyclist1 = new Cyclist(false, 3, 1, pictureBox1.Width, Color.Wheat);
            SprinteurCyclist2= new Cyclist(true, 4, 1, pictureBox1.Width, Color.MediumPurple);
            RouleurCyclist2 = new Cyclist(false, 3, 0, pictureBox1.Width, Color.LightGreen);
            ExhaustionCard = new Cards(2, "Exhaustion");
            cyclistList = new List<Cyclist>();
            cyclistList.Add(SprinteurCyclist1 );
            cyclistList.Add(SprinteurCyclist2);
            cyclistList.Add(RouleurCyclist1);
            cyclistList.Add(RouleurCyclist2);

        }
        Rectangle[] squarearray = new Rectangle[36];

        /// <summary>
        /// changes the color of the background of the buttons with cards
        /// </summary>
        /// <param name="color"></param>
        /// <param name="player"></param>
        private void ColorChange1(Color color, string player)
        {
            //checks if it is the first player
            if (player== "1")
            {
                button1.BackColor = color;
                button2.BackColor = color;
                button3.BackColor = color;
                button4.BackColor = color;
            }
            //checks if it is the second player
            else if(player == "2")
            {
                button6.BackColor = color;
                button7.BackColor = color;
                button8.BackColor = color;
                button9.BackColor = color;
            }
        }

        /// <summary>
        /// moves the cyclist according to the card that has been selected
        /// </summary>
        /// <param name="index">the number of the card</param>
        /// <param name="player">the type of player moving</param>
        private void SelectCard(int index, string player)
        {
            try
            {
                //checks if the first player is selected
                if (player == "1")
                {
                    int points = cardList[index].Sc;
                    cardList.RemoveAt(index);
                    
                    //checks if it is the sprinter
                    if (IS)
                    {
                        SprinteurCyclist1.MoveObject(points);
                        foreach (Cards card in cardList)
                        {
                            SprinteurDeck1.RecycleCards(card);
                        }
                    }
                    //checks if it is the rouler
                    else if (!IS)
                    {
                        RouleurCyclist1.MoveObject(points);
                        foreach (Cards card in cardList)
                        {
                            RouleurDeck1.RecycleCards(card);
                        }
                    }
                }
                //checks if the second player is selected
                else if (player == "2")
                {
                    int points = cardList[index].Sc;
                    cardList.RemoveAt(index);

                    //checks if it is the sprinter
                    if (IS)
                    {
                        SprinteurCyclist2.MoveObject(points);
                        foreach (Cards card in cardList)
                        {
                            SprinteurDeck2.RecycleCards(card);
                        }
                    }

                    //checks if it is the rouleur
                    else if (!IS)
                    {
                        RouleurCyclist2.MoveObject(points);
                        foreach (Cards card in cardList)
                        {
                            RouleurDeck2.RecycleCards(card);
                        }
                    }
                }
                //refreshes the picturebox
                pictureBox1.Invalidate();
                cardList.Clear();
                //checks if the players have won
                Haswon(pictureBox1);
            }
            catch
            {
                MessageBox.Show("Invalid Move");
            }
            
        }

        /// <summary>
        /// paints the contents of the game onto the picturebox provided
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            GameTrack gametrack1 = new GameTrack();
            gametrack1.DrawTrack(e.Graphics, pictureBox1);
            SprinteurCyclist1.DrawCyclist(e.Graphics, pictureBox1);
            RouleurCyclist1.DrawCyclist(e.Graphics, pictureBox1);
            SprinteurCyclist2.DrawCyclist(e.Graphics, pictureBox1);
            RouleurCyclist2.DrawCyclist(e.Graphics, pictureBox1);
        }

        /// <summary>
        /// tshuffles and deals the cards for the sprinter of the first player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayer1S_Click(object sender, EventArgs e)
        {
            //deals four cards to the deck
            for (int i = 0; i < 4; i++)
            {
                Cards c = SprinteurDeck1.DealCard();
                cardList.Add(c);
                Console.WriteLine(c.Sc);
            }
            
            Color buttonColor = Color.CornflowerBlue;
            ColorChange1(buttonColor, "1");
            IS = true;
            button1.Text = cardList[0].Sc.ToString();
            button2.Text = cardList[1].Sc.ToString();
            button3.Text = cardList[2].Sc.ToString();
            button4.Text = cardList[3].Sc.ToString();
        }

        /// <summary>
        /// shuffles and deals the cards for the rouleur of the first player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayer1R_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Cards c = RouleurDeck1.DealCard();
                cardList.Add(c);
                Console.WriteLine(c.Sc);
            }
           
            Color buttonColor = Color.Wheat;
            ColorChange1(buttonColor, "1");
            Console.WriteLine("");
            IS = false;
            button1.Text = cardList[0].Sc.ToString();
            button2.Text = cardList[1].Sc.ToString();
            button3.Text = cardList[2].Sc.ToString();
            button4.Text = cardList[3].Sc.ToString();
        }

        /// <summary>
        /// card for player 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            SelectCard(0, "1");
        }
        /// <summary>
        /// card for player 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            SelectCard(1, "1");
        }
        /// <summary>
        /// card for player 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            SelectCard(2, "1");
        }
        /// <summary>
        /// card for player 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            SelectCard(3, "1");
        }

        

        /// <summary>
        /// checks fif there is a cyclist is 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool CheckCyclist(Cyclist c)
        {
            int newX = c.XPos * c.squareWidth;
            if(newX != RouleurCyclist1.XPos && newX != SprinteurCyclist1.XPos && newX != SprinteurCyclist2.XPos && newX != RouleurCyclist2.XPos) { return true; } 
            else { return false; }
        }

        /// <summary>
        /// awards exhaustion cards to the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEx_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;

            //checks rouleur 1
            isEmpty = CheckCyclist(RouleurCyclist1);
            if (isEmpty)
            {
                RouleurDeck1.RecycleCards(ExhaustionCard);
                buttonEC1.Text = ExhaustionCard.Value.ToString();
            }
            //checks sprinter 1
            isEmpty = CheckCyclist(SprinteurCyclist1);
            if (isEmpty)
            {
                SprinteurDeck1.RecycleCards(ExhaustionCard);
                buttonEC1.Text = ExhaustionCard.Value.ToString();
            }

            //checks rouleur 2
            isEmpty = CheckCyclist(RouleurCyclist2);

            if (isEmpty)
            {
                 RouleurDeck2.RecycleCards(ExhaustionCard);
                 buttonEC2.Text = ExhaustionCard.Value.ToString();
            }
            //checks Sprinter 2
            isEmpty = CheckCyclist(SprinteurCyclist2);
            if (isEmpty)
            {
                    SprinteurDeck2.RecycleCards(ExhaustionCard);
                    buttonEC2.Text = ExhaustionCard.Value.ToString();
            }



            
        }

        /// <summary>
        /// checks if the position in front of the cyclist is empty
        /// </summary>
        public void Exhaust()
        {
            bool isEmpty = false;

            isEmpty = CheckCyclist(RouleurCyclist1);
            if (isEmpty)
            {
                RouleurDeck1.RecycleCards(ExhaustionCard);
            }
            isEmpty = CheckCyclist(SprinteurCyclist1);
            if (isEmpty)
            {
                SprinteurDeck1.RecycleCards(ExhaustionCard);
            }
            isEmpty = CheckCyclist(RouleurCyclist2);
            if (isEmpty)
            {
                RouleurDeck2.RecycleCards(ExhaustionCard);
            }
            isEmpty = CheckCyclist(SprinteurCyclist2);
            if (isEmpty)
            {
                SprinteurDeck2.RecycleCards(ExhaustionCard);
            }
        }

        /// <summary>
        /// checks if the match has been won or not
        /// </summary>
        /// <param name="p"></param>
        public void Haswon(PictureBox p)
        {
            //checks if the first player passes the finish line
           if (SprinteurCyclist1._x> p.Width || RouleurCyclist1._x> p.Width)
           {
              MessageBox.Show("Player 1 wins.");

                Application.Exit();

            }
           //checks if the second player passes the finish line
           else if (SprinteurCyclist2._x > p.Width || RouleurCyclist2._x > p.Width)
           {
                MessageBox.Show("Player 2 wins.");

                Application.Exit();

            }

        }


        /// <summary>
        /// shuffles and deals the cards for the sprinter of the second player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Cards c = SprinteurDeck2.DealCard();
                cardList.Add(c);
                Console.WriteLine(c.Sc);
            }
            
            Color buttonColor = Color.CornflowerBlue;
            ColorChange1(buttonColor, "2");
            Console.WriteLine("");
            IS = true;
            button6.Text = cardList[0].Sc.ToString();
            button7.Text = cardList[1].Sc.ToString();
            button8.Text = cardList[2].Sc.ToString();
            button9.Text = cardList[3].Sc.ToString();
        }


        /// <summary>
        /// shuffles and deals the cards for the rouleur of the second player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Cards c = RouleurDeck2.DealCard();
                cardList.Add(c);
                Console.WriteLine(c.Sc);
            }
            
            Color buttonColor = Color.Wheat;
            ColorChange1(buttonColor, "2");
            Console.WriteLine("");
            IS = false;
            button6.Text = cardList[0].Sc.ToString();
            button7.Text = cardList[1].Sc.ToString();
            button8.Text = cardList[2].Sc.ToString();
            button9.Text = cardList[3].Sc.ToString();
        }

        /// <summary>
        /// card for player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            SelectCard(0, "2");
        }
        /// <summary>
        /// card for player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {

            SelectCard(1, "2");
        }
        /// <summary>
        /// card for player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {

            SelectCard(2, "2");
        }
        /// <summary>
        /// card for player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {

            SelectCard(3, "2");
        }

        /// <summary>
        /// saves the contents of the game in a csv file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files|*.csv";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);

                    // Write list of directions
                    foreach (Cyclist c in cyclistList)
                    {
                        writer.WriteLine(c.ToCSVString());  
                    }
                    writer.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}