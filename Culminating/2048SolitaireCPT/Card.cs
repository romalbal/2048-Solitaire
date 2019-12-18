using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2048SolitaireCPT
{
    class Card
    {

        
        //Fields
        double mValue;  //value of the card
        string mCardmName;  //card name (in resource file) for the card to draw it

        //Constructors
        
        //create a new card
        public Card(double Value, string CardName)
        {
            this.mValue = Value;
            this.mCardmName = CardName;
        }

        //Properties 

        //create a property to get access and set the card value
        public double Value
        {
            get { return mValue; }
            set { mValue = Value; }
        }

        //create a property to get and set the name of the card.
        public string CardName
        {
            get { return mCardmName; }
            set { mCardmName = CardName; }
        }
        
        //draw the card, by accesing the resource file
        public void DrawCard(Graphics g, int x, int y)
        {
            //this draws the card on the surface g at
            Bitmap card = (Bitmap)Graphic.ResourceManager.GetObject(this.mCardmName);
            g.DrawImage(card, x, y);
        }
    }
}
