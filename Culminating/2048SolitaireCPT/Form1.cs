using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Romal and Aashrit
//January 23, 2019
//2048 Solitaire
//A brand new card game version of the famous game 2048!
namespace _2048SolitaireCPT
{
    public partial class frmGame : Form
    {
        //create objects of class
        Hand Player1;
        Deck TheDeck;
        CardColumns Columns;
      
        //the position of the column arrow (x variabkle)
        int ColumnXValueChosen;
        
        //see if a new game is being played
        bool Game;
        int Counter = 0;
        
        public frmGame()
        {
            InitializeComponent();
            
        }
        //Code to move arrow left and right. Q = left and W = right
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && picColumnArrow.Left > 57)
            {
                picColumnArrow.Left -= 174;
            }
            if (e.KeyCode == Keys.W && picColumnArrow.Left < 579)
            {
                    picColumnArrow.Left += 174;
            }
            //code to make E = enter in our game
            if (Game == true)
            {
            if (e.KeyCode == Keys.E)
            {
                //Only run if user has not lost
               
                    if (Columns.Column1IndexValue < 9 || Columns.Column2IndexValue < 9 || Columns.Column3IndexValue < 9 || Columns.Column4IndexValue < 9)
                    {
                        //Gathers X location for later calculations
                        ColumnXValueChosen = picColumnArrow.Left;
                        Columns.AddColumnCard(CreateGraphics(), ColumnXValueChosen, Player1.MoveToColumn());
                        lblUserScore.Text = (Columns.Score).ToString();
                        //Methods are called from various classes
                        Columns.TempArray(ColumnXValueChosen);
                        Columns.ClearArray(ColumnXValueChosen);
                        Columns.SwapValuesArray(ColumnXValueChosen);
                        this.Refresh();
                        Columns.DrawEverything(CreateGraphics(), ColumnXValueChosen);
                        //Tracker checks if the user has won the game or not
                        if (Columns.Tracker == true)
                        {
                            Winner();
                        }
                        
                        Player1.NextCard();
                        Player1.AddCard(TheDeck.Deal());
                        Player1.DrawHand(CreateGraphics());
                    }

                }
               //Code to determine when to end the game (user lost)
            
                
                    if (Columns.Column1IndexValue == 9 || Columns.Column2IndexValue == 9 || Columns.Column3IndexValue == 9 || Columns.Column4IndexValue == 9)
                    {
                        EndGame();
                    }
                
                
            }
            //R = "New Game" key
            if (e.KeyCode == Keys.R)
            {
               
                NewGame();
                
            }
            
        }

        //Method if user is the winner
        public void Winner()
        {
            picColumnArrow.Visible = false;
            picHandArrow.Visible = false;
            lblStartGame.Visible = false;
            lblFinalScore.Text = "YOU WIN, Final Score:" + lblUserScore.Text;
            lblFinalScore.Visible = true;
            lblPlayAgain.Visible = true;
            btnDiscard.Enabled = false;
            Game = false;
        }
        //Method for if the game ends
        public void EndGame()
        {
            picColumnArrow.Visible = false;
            picHandArrow.Visible = false;
            lblStartGame.Visible = false;
            lblFinalScore.Text = "Final Score:" + lblUserScore.Text;
            lblFinalScore.Visible = true;
            lblPlayAgain.Visible = true;
            btnDiscard.Enabled = false;


            Game = false;
        }
        //Method for when new game is pressed
        public void NewGame()
        {
            picColumnArrow.Visible = true;
            picHandArrow.Visible = true;
            lblStartGame.Visible = false;
            lblPlayAgain.Visible = false;
            lblFinalScore.Visible = false;
           
            lblUserScore.Text = ""+ 000;
            Game = true;
            Player1 = new Hand();
            TheDeck = new Deck();
            Columns = new CardColumns();
            this.Refresh();
            Player1.DrawHand(CreateGraphics());
            btnDiscard.Enabled = true;
            
            Counter = 0;
            picStar1.Visible = true;
            picStar2.Visible = true;
            picStar3.Visible = true;
            
        }

        

        private void mnuFileNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        //Method for discarding card at hand for a different card. Only 3 discards are allowed
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Counter++;

            if (Counter == 1)
            {
                picStar1.Visible = false;
            }
            else if (Counter == 2)
            {
                picStar2.Visible = false;
            }
            else if (Counter == 3)
            {
                picStar3.Visible = false;
                btnDiscard.Enabled = false;
            }

            Player1.NextCard();
            Player1.AddCard(TheDeck.Deal());
            Player1.DrawHand(CreateGraphics());

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //Ends the game
            Application.Exit();
        }

        private void mnuFileRules_Click(object sender, EventArgs e)
        {
            //Rules to play
            MessageBox.Show("Rules: \n-Move the Arrow Left and Right (using Q - left - and W - right) Over The Column You Want To Place A Card In \n-Press 'E' to Place the Card from Your Hand to the Column \n-Place Same Cards On Top Of Each Other To Gain Score \nNOTE: Your Cards Cannot Exceed The Bottom Line!");
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }
    }
}
