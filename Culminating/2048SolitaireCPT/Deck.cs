using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048SolitaireCPT
{
    class Deck
    {

        //Fields
        private Card[] mDeck;
        

        //Constructors
        public Deck()
        {
            //create all possible cards (2, 4, 8, 16, 32, 64) that the user can have in hand
            mDeck = new Card[6];
            
            int LowestValue = 2;
            int PowerVariable = 1;

            //set values to each card in deck
            for (int i = 0; i < mDeck.Length; i++)
            {
                double CardValueCalculation = Math.Pow(LowestValue, PowerVariable);
                mDeck[i] = new Card(CardValueCalculation, "_" + CardValueCalculation.ToString());
                PowerVariable++;
            }

            
        }

        //Methods
        
        //select a card from the deck to put into hand
        public Card Deal()
        {
            Random PickCard = new Random();
            int ChosenCardIndex = PickCard.Next(0, 5);

            Card card = mDeck[ChosenCardIndex];
           
            return card;
        }


    }
}
