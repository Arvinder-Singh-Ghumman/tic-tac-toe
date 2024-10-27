using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace tic_tac_2
{
    public partial class tictactoe : UserControl
    {
        bool player1 = true;
        Button[,] button = new Button[3, 3];

        // tictac UserControl
        public tictactoe()
        {
            InitializeComponent();

            button[0, 0] = b1;
            button[0, 1] = b2;
            button[0, 2] = b3;
            button[1, 0] = b4;
            button[1, 1] = b5;
            button[1, 2] = b6;
            button[2, 0] = b7;
            button[2, 1] = b8;
            button[2, 2] = b9;

            w1.Text = "0";
            w2.Text = "0";
        }

        //sub board win
        private void SubBoard_WinOccurred(object sender, subBoard.WinEventArgs e, Button b)
        {
            this.Controls.Remove((subBoard)sender);
            b.Text = e.IsPlayerX ? "X" : "O";
            b.Enabled = false;

            // Main board check
            if (this.checkWin())
            {
                if (b.Text == "X")
                {
                    MessageBox.Show($"Winner is Player 1  - X \nPlayer 1 - X  wins {w1.Text}\nPlayer 2- O wins {w2.Text}");
                }
                else
                {
                    MessageBox.Show($"Winner is Player 2 - O.\nPlayer 1 - X  wins {w1.Text}\nPlayer 2- O wins {w2.Text}");
                }

                //restart
                DialogResult result = MessageBox.Show("Do you want to play again?", "Restart Game", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    resetBoard();
                }
                else
                {
                    this.FindForm().Close();
                }
            }
            // Check for draw
            else if (b1.Enabled == false && b2.Enabled == false && b3.Enabled == false && b4.Enabled == false && b5.Enabled == false && b6.Enabled == false && b7.Enabled == false && b8.Enabled == false && b9.Enabled == false)
            {
                MessageBox.Show("It's a draw!", "No Winner");
                resetBoard();
            }
        }

        //labels
        public Label t
        {
            get { return turn; }
            set { turn = value; }
        }
        public Label winn1
        {
            get { return w1; }
            set { w1 = value; }
        }
        public Label winn2
        {
            get { return w2; }
            set { w2 = value; }
        }

        // check for win
        private bool checkWin()
        {
            // Check rows for a win.
            for (int i = 0; i < 3; i++)
            {
                if (button[i, 0].Text == button[i, 1].Text && button[i, 1].Text == button[i, 2].Text && button[i, 0].Text != "" && button[i, 0].Enabled == false)
                {
                    return true;
                }
            }

            // Check columns for a win.
            for (int i = 0; i < 3; i++)
            {
                if (button[0, i].Text == button[1, i].Text && button[1, i].Text == button[2, i].Text && button[0, i].Text != "" && button[0, i].Enabled == false)
                {
                    return true;
                }
            }

            // Check diagonals for a win (top-left to bottom-right).
            if (button[0, 0].Text == button[1, 1].Text && button[1, 1].Text == button[2, 2].Text && button[0, 0].Text != "" && button[0, 0].Enabled == false)
            {
                return true;
            }

            // Check diagonals for a win (top-right to bottom-left).
            if (button[0, 2].Text == button[1, 1].Text && button[1, 1].Text == button[2, 0].Text && button[0, 2].Text != "" && button[0, 2].Enabled == false)
            {
                return true;
            }

            return false; // No win 
        }

        // reset main board
        private void resetBoard()
        {
            List<Control> controlsToRemove = new List<Control>();

            // Iterate through all controls and identify sub-boards
            foreach (Control control in this.Controls)
            {
                if (control is subBoard)
                {
                    controlsToRemove.Add(control); // Add to a list to remove later
                }
            }

            // Remove all identified sub-boards
            foreach (Control subBoard in controlsToRemove)
            {
                this.Controls.Remove(subBoard);
                subBoard.Dispose();
            }

            // Loop through the 3x3 button grid and reset each button.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    button[i, j].Text = "";
                    button[i, j].Enabled = true;
                    button[i, j].BringToFront();
                    button[i, j].Visible = true;

                }

            }

            // Reset turn and ui
            player1 = true;
            turn.Text = "Turn Player 1 - X ";
            winn1.Text = "";
            winn2.Text = "";

        }

        // sub board addition
        private void b2_Click(object sender, EventArgs e)
        {
            turn.Text = "Turn Player 1 - X ";

            Button b = (Button)sender;

            // Create a new sub-board control and calculate its position relative to the main board.
            subBoard subBoard = new subBoard(this);
            Point buttonScreenLocation = b.PointToScreen(Point.Empty);
            Point parentClientLocation = this.PointToClient(buttonScreenLocation);
            subBoard.Location = parentClientLocation;
            subBoard.Size = b.Size;

            this.Controls.Add(subBoard);
            subBoard.BringToFront();

            // Attach the win event from the sub-board to the handler in this class.
            subBoard.WinOccurred += (s, e) => SubBoard_WinOccurred(s, e, b);

            b.Enabled = false;
        }

        //reset button
        private void button1_Click(object sender, EventArgs e)
        {
            resetBoard();
        }

        // exit button
        private void button2_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
        private void Form2_CloseForm1(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
