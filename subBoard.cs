using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_2
{
    // sub-board in the game.
    public partial class subBoard : UserControl
    {
        bool player1 = true;
        Button[,] button = new Button[3, 3];

        private tictactoe ti;

        //var
        static int win1 = 0;
        static int win2 = 0;

        // Event that is triggered when a player wins the sub-board.
        public event EventHandler<WinEventArgs> WinOccurred;

        // Properties to track whether Player X or Player O won.
        public bool winx { get; private set; } // Player X win - (private for encapsulation)
        public bool wino { get; private set; } // Player O win - (private for encapsulation)
        public event EventHandler CloseF;
        
        public subBoard(tictactoe t)
        {
            InitializeComponent();

            button[0, 0] = bu1;
            button[0, 1] = bu2;
            button[0, 2] = bu3;
            button[1, 0] = bu4;
            button[1, 1] = bu5;
            button[1, 2] = bu6;
            button[2, 0] = bu7;
            button[2, 1] = bu8;
            button[2, 2] = bu9;

            // Assign the main tictac form to the 'ti' variable.
            ti = t;
        }

        protected virtual void OnWinOccurred(WinEventArgs e)
        {
            WinOccurred?.Invoke(this, e);
        }

        public bool checkWin()
        {
            // Check for a win in rows.
            for (int i = 0; i < 3; i++)
            {
                if (button[i, 0].Text == button[i, 1].Text && button[i, 1].Text == button[i, 2].Text && button[i, 0].Text != "" && button[i, 0].Enabled == false)
                {
                    return true; 
                }
            }

            // Check for a win in columns.
            for (int i = 0; i < 3; i++)
            {
                if (button[0, i].Text == button[1, i].Text && button[1, i].Text == button[2, i].Text && button[0, i].Text != "" && button[0, i].Enabled == false)
                {
                    return true;
                }
            }

            // Check for a win in diagonals
            if (button[0, 0].Text == button[1, 1].Text && button[1, 1].Text == button[2, 2].Text && button[0, 0].Text != "" && button[0, 0].Enabled == false)
            {
                return true;
            }

            // Check for a win in diagonals
            if (button[0, 2].Text == button[1, 1].Text && button[1, 1].Text == button[2, 0].Text && button[0, 2].Text != "" && button[0, 2].Enabled == false)
            {
                return true; 
            }

            return false;
        }

        //reset sub-board
        private void resetBoard()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    button[i, j].Text = "";  
                    button[i, j].Enabled = true; 
                }
            player1 = true;
            ti.t.Text = "Turn Player 1- X";
        }

        // Button click event handler for the sub-board.
        private void bu1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;  

            if (player1 == true)
            {
                player1 = false;  
                b.Text = "X";  
                ti.t.Text = "Turn Player 2(O)";  
            }
            else
            {
                player1 = true;  
                b.Text = "O";  
                ti.t.Text = "Turn Player 1(X)";  
            }

            b.Enabled = false;  

            // Check if a player has won after the move.
            if (checkWin())
            {
                if (player1 == false)
                {
                    // X won.
                    winx = true;
                    win1++;  
                    ti.winn1.Text = $"{win1}";  
                    OnWinOccurred(new WinEventArgs(true));  
                }
                else
                {
                    // O won.
                    wino = true;
                    win2++;  
                    ti.winn2.Text = $"{win2}";  
                    OnWinOccurred(new WinEventArgs(false));  
                }
            }
            // Check for draw.
            else if (bu1.Enabled == false && bu2.Enabled == false && bu3.Enabled == false && bu4.Enabled == false && bu5.Enabled == false && bu6.Enabled == false && bu7.Enabled == false && bu8.Enabled == false && bu9.Enabled == false)
            {
                //draw
                MessageBox.Show("It's a draw!", "No Winner");
                resetBoard();  // Reset board
            }
        }

        // Win event
        public class WinEventArgs : EventArgs
        {
            public bool IsPlayerX { get; }

            public WinEventArgs(bool isPlayerX)
            {
                IsPlayerX = isPlayerX;  
            }
            
        }
        private void btnTriggerCloseForm1_Click(object sender, EventArgs e)
        {
            // Trigger the event
            CloseF?.Invoke(this, EventArgs.Empty);
        }
    }
}
