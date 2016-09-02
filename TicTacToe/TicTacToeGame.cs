using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeGame : Form
    {

        private List<Button> gameStack;
        private List<Button> playerMoves;
        private List<Button> computerMoves;
        public TicTacToeGame()
        { 
            gameStack = new List<Button>();
            playerMoves = new List<Button>();
            computerMoves = new List<Button>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameStack.Add(pos_1_1);
            gameStack.Add(pos_1_2);
            gameStack.Add(pos_1_3);
            gameStack.Add(pos_2_1);
            gameStack.Add(pos_2_2);
            gameStack.Add(pos_2_3);
            gameStack.Add(pos_3_1);
            gameStack.Add(pos_3_2);
            gameStack.Add(pos_3_3);
        }
        //Set's Clicked button to Marked and initiates a Computer's Random Move
        private void move(Button pos)
        {
            if(pos.Text == "")
            {
                pos.Text = "X";
                gameStack.Remove(pos);
                playerMoves.Add(pos);
                if (victoryCheck(playerMoves))
                {
                    lblDisplay.Text = "YOU WIN";
                }else if (tieCheck(gameStack))
                {
                    lblDisplay.Text = "TIE";
                } else
                {
                    ComputerMove();
                }
            }
        }
        //initaties random computer selection of board
        private void ComputerMove()
        {
            if (gameStack.Count != 0)
            {
                Random rnd = new Random();
                int rndIndex = rnd.Next(0, gameStack.Count);
                gameStack[rndIndex].Text = "O";
                computerMoves.Add(gameStack[rndIndex]);
                gameStack.RemoveAt(rndIndex);
                if (victoryCheck(computerMoves))
                {
                    lblDisplay.Text = "YOU LOSE";
                }
            }

        }
        private void pos_1_1_Click(object sender, EventArgs e)
        {
            move(pos_1_1);
        }

        private void pos_2_2_Click(object sender, EventArgs e)
        {
            move(pos_2_2);
        }
        
        private void pos_2_3_Click(object sender, EventArgs e)
        {
            move(pos_2_3);
        }

        private void pos_3_1_Click(object sender, EventArgs e)
        {
            move(pos_3_1);
        }

        private void pos_1_2_Click(object sender, EventArgs e)
        {
            move(pos_1_2);
        }
        

        private void pos_1_3_Click(object sender, EventArgs e)
        {
            move(pos_1_3);
        }

        private void pos_2_1_Click(object sender, EventArgs e)
        {
            move(pos_2_1);
        }

        private void pos_3_2_Click(object sender, EventArgs e)
        {
            move(pos_3_2);
        }

        private void pos_3_3_Click(object sender, EventArgs e)
        {
            move(pos_3_3);
        }
        // Check's move array to determine if player or computer has horizontal win
        private bool horVictoryCheck(List<Button> moves)
        {
            if(moves.Contains(pos_1_1) && moves.Contains(pos_1_2) && moves.Contains(pos_1_3))
            {
                return true;
            }
            else if(moves.Contains(pos_2_1) && moves.Contains(pos_2_2) && moves.Contains(pos_2_3))
            {
                return true;
            }
            else if(moves.Contains(pos_3_1) && moves.Contains(pos_3_2) && moves.Contains(pos_3_3))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private bool verVictoryCheck(List<Button> moves)
        {
            if(moves.Contains(pos_1_1) && moves.Contains(pos_2_1) && moves.Contains(pos_3_1))
            {
                return true;
            }
            else if(moves.Contains(pos_1_2) && moves.Contains(pos_2_2) && moves.Contains(pos_3_2))
            {
                return true;
            }
            else if(moves.Contains(pos_1_3) && moves.Contains(pos_2_3) && moves.Contains(pos_3_3))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private bool diagVictoryCheck(List<Button> moves)
        {
            if(moves.Contains(pos_1_1) && moves.Contains(pos_2_2) && moves.Contains(pos_3_3))
            {
                return true;
            }
            else if(moves.Contains(pos_1_3) && moves.Contains(pos_2_2) && moves.Contains(pos_3_1))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private bool tieCheck(List<Button> stack)
        {
            if (stack.Count == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        private bool victoryCheck(List<Button> stack)
        {
            if(horVictoryCheck(stack) || verVictoryCheck(stack) || diagVictoryCheck(stack))
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            pos_1_1.Text = "";
            pos_1_2.Text = "";
            pos_1_3.Text = "";
            pos_2_1.Text = "";
            pos_2_2.Text = "";
            pos_2_3.Text = "";
            pos_3_1.Text = "";
            pos_3_2.Text = "";
            pos_3_3.Text = "";
            playerMoves.RemoveRange(0, playerMoves.Count);
            computerMoves.RemoveRange(0, computerMoves.Count);
            gameStack.RemoveRange(0, gameStack.Count);
            Form1_Load(sender, e);

        }
    }
}
