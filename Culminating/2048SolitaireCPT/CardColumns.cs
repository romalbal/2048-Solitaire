using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2048SolitaireCPT
{
    class CardColumns
    {
        //private fields
        
        //create individual arrays for each column
        private Card[] mColumn1;
        private Card[] mColumn2;
        private Card[] mColumn3;
        private Card[] mColumn4;
        //score of the user
        public double Score = 0;
        
        //keep track if the user wins the game
        public bool Tracker = false;

        //create temp arrays for each column
        Card[] TempColumn1;
        Card[] TempColumn2;
        Card[] TempColumn3;
        Card[] TempColumn4;

        //counters for each column
        int i1 = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        int Y1 = 141;
        int Y2 = 141;
        int Y3 = 141;
        int Y4 = 141;


        //constructor
        
        //initialize the 4 column arrays
        public CardColumns()
        {
            mColumn1 = new Card[9];
            mColumn2 = new Card[9];
            mColumn3 = new Card[9];
            mColumn4 = new Card[9];
        }

        
        //properties

        //get the number of cards in each array - through the counter variables
        public int Column1IndexValue
        {
            get { return i1; }
        }

        public int Column2IndexValue
        {
            get { return i2; }
        }
        
        public int Column3IndexValue
        {
            get { return i3; }
        }
        
        public int Column4IndexValue
        {
            get { return i4; }
        }

        //methods

        //clear each column depending on which column card is placed in, so it can be drawn later
        public void ClearArray(int ArrowX)
        {
            if (ArrowX == 57)
            {
                mColumn1 = new Card[9];
            }

            if (ArrowX == 231)
            {
                mColumn2 = new Card[9];
            }

            if (ArrowX == 405)
            {
                mColumn3 = new Card[9];
            }

            if (ArrowX == 579)
            {
                mColumn4 = new Card[9];
            }
        }

        //method to add card from hand to column
        public void AddColumnCard(Graphics g, int ArrowX, Card HandCard)
        {
            //Y1, Y2, Y3, Y4 = y location of cards in each column 

            //check if in first column
            if (ArrowX == 57 && i1 < 9)
            {
                
                Y1 = 141 + (i1 * 45);
                
                this.mColumn1[i1] = HandCard; 
                
                if (i1 > 0)
                {
                    //check if the card and the one above are the same - shrinks column, and creates new card
                    while (i1 > 0 && mColumn1[i1].Value == mColumn1[i1 - 1].Value)
                    {
                        double NewValue = (mColumn1[i1].Value) * 2;

                        //check if user has created a 2048 card - won the game
                        if (NewValue == 2048)
                        {
                            Tracker = true;
                        }

                        //increase score by NewValue
                        Score += NewValue;

                        //create new card once two cards match
                        Card NewCard = new Card(NewValue, "_" + NewValue.ToString());

                        mColumn1[i1 - 1] = NewCard;
                        mColumn1[i1] = null;
                        Y1 -= 45;
                        i1--; 
                    }
                }
                i1++;
            }

            //proccesses above apply to those below as well, but for different columns

            //check if in second column
            else if (ArrowX == 231 && i2 < 9)
            {
                Y2 = 141 + (i2 * 45);

                this.mColumn2[i2] = HandCard;

                if (i2 > 0)
                {
                    while (i2 > 0 && mColumn2[i2].Value == mColumn2[i2 - 1].Value)
                    {
                        double NewValue = (mColumn2[i2].Value) * 2;

                        if (NewValue == 2048)
                        {
                            Tracker = true;
                        }

                        Score += NewValue;
                        Card NewCard = new Card(NewValue, "_" + NewValue.ToString());
                        mColumn2[i2 - 1] = NewCard;
                        mColumn2[i2] = null;
                        Y2 -= 45;
                        i2--;
                    }
                } 
                i2++;    
                
            }

            //check if in third column
            else if (ArrowX == 405 && i3 < 9)
            {
                Y3 = 141 + (i3 * 45);

                this.mColumn3[i3] = HandCard;

                if (i3 > 0)
                {
                    while (i3 > 0 && mColumn3[i3].Value == mColumn3[i3 - 1].Value)
                    {
                        double NewValue = (mColumn3[i3].Value) * 2;

                        if (NewValue == 2048)
                        {
                            Tracker = true;
                        }

                        Score += NewValue;
                        Card NewCard = new Card(NewValue, "_" + NewValue.ToString());
                        mColumn3[i3 - 1] = NewCard;
                        mColumn3[i3] = null;
                        Y3 -= 45;
                        i3--;
                    }
                }     
                i3++;     
            }

            //check if in fourth column
            else if (ArrowX == 579 && i4 < 9)
            {
                Y4 = 141 + (i4 * 45);

                this.mColumn4[i4] = HandCard;

                if (i4 > 0)
                {
                    while (i4 > 0 && mColumn4[i4].Value == mColumn4[i4 - 1].Value)
                    {
                        double NewValue = (mColumn4[i4].Value) * 2;

                        if (NewValue == 2048)
                        {
                            Tracker = true;
                        }

                        Score += NewValue;
                        Card NewCard = new Card(NewValue, "_" + NewValue.ToString());
                        mColumn4[i4 - 1] = NewCard;
                        mColumn4[i4] = null;
                        Y4 -= 45;
                        i4--;
                    }
                }
                i4++;   
            }   
        }

        //draw all the cards on the screen
        public void DrawEverything(Graphics g, int ArrowX)
        {
            //y position variables
            int y1 = 141;
            int y2 = 141;
            int y3 = 141;
            int y4 = 141;

                for (int i = 0; i < i1; i++)
                {
                    
                    mColumn1[i].DrawCard(g, 57 - 20, y1);
                    y1 += 45;
                }
            
                for (int i = 0; i < i2; i++)
                {
                    mColumn2[i].DrawCard(g, 231 - 20, y2);
                    y2 += 45;
                }
            
                for (int i = 0; i < i3; i++)
                {
                    mColumn3[i].DrawCard(g, 405 - 20, y3);
                    y3 += 45;
                }
            
                for (int i = 0; i < i4; i++)
                {
                    mColumn4[i].DrawCard(g, 579 - 20, y4);
                    y4 += 45;
                }
            
        }

        //create temp arrays for each column array - used to properly draw the cards on screen after refreshing
        public void TempArray(int ArrowX)
        {
            TempColumn1 = new Card[9];
            TempColumn2 = new Card[9];
            TempColumn3 = new Card[9];
            TempColumn4 = new Card[9];

            if (ArrowX == 57)
            {
                for (int i = 0; i < i1; i++)
                {
                    TempColumn1[i] = mColumn1[i];
                }
            }
            
            if (ArrowX == 231)
            {
                for (int i = 0; i < i2; i++)
                {
                    
                    TempColumn2[i] = mColumn2[i];
                }
            }
            
            if (ArrowX == 405)
            {
                for (int i = 0; i < i3; i++)
                {
                    
                    TempColumn3[i] = mColumn3[i];
                }
            }
            
            if (ArrowX == 579)
            {
                for (int i = 0; i < i4; i++)
                {
                    
                    TempColumn4[i] = mColumn4[i];
                }
            }
        }

        //bring values from temp arrays back into original
        public void SwapValuesArray(int ArrowX)
        {
            if (ArrowX == 57)
            {
                for (int i = 0; i < i1; i++)
                {
                    mColumn1[i] = TempColumn1[i];
                }
            }

            if (ArrowX == 231)
            {
            for (int i = 0; i < i2; i++)
            {
                mColumn2[i] = TempColumn2[i];
            }
            }

            if (ArrowX == 405)
            {
                for (int i = 0; i < i3; i++)
                {
                    mColumn3[i] = TempColumn3[i];
                }
            }

            if (ArrowX == 579)
            {
                for (int i = 0; i < i4; i++)
                {
                    mColumn4[i] = TempColumn4[i];
                }
            }
        }
      
    }
}
