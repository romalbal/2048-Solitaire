using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2048SolitaireCPT
{
    class Hand
    {

        //Fields
        private Card[] mHand;
        

        //Constructor
        //create the hand
        public Hand()
        {
            mHand = new Card[2];
            mHand[0] = new Card(2, "_2");
            mHand[1] = new Card(2, "_2");
        }




        //Methods
        //access the card in hand, which has to be moved to column
        public Card MoveToColumn()
        {
            return mHand[1];
        }
        
        //add a new card into hand
        public void AddCard(Card card)
        {
            this.mHand[0] = card;
        }

        public void DrawHand(Graphics g)
        {
            
            int X = 274;
            int Y = 622;

            mHand[0].DrawCard(g, X, Y);
            mHand[1].DrawCard(g, X + Graphic._2.Width + 10, Y);  
        }

        //bring the second card into the first position of hand
        public void NextCard()
        {
            this.mHand[1] = this.mHand[0];
        }


        

    }
}
