using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Towers_of_Hanoi
{   /// <summary>
    /// This form lets the user play a game of HanoiTowers.
    /// 4 labels representing disks are shown on the first of three pegs. It is possible 
    /// to drag a disk from one Peg to another with mouse. The rules for a valid move are that
    /// a bigger disk cannot be dropped on top of a smaller one. The aim of the game
    /// is to move the stack of disks to another Peg one disk at a time.
    /// Moves made by Dragging are recorder as lines of text in a textBox
    /// It is possible to reset the disks to their original position,
    /// save your current game or load your last saved game from the [Game] menu.
    /// Help is availible by clicking [Help] menu
    /// It is also possible to replay the moves stored in the textbox
    /// from a timer - started by the [Animate] button
    /// </summary>
    public partial class MainForm : Form
    {
        private int targetPeg = 1;//used to communicate between DragDrop which identifies the peg being dropped on

        private int moveCount = 0; //count of moves made in a game

        private Disk[] disks = new Disk[4];//array of disks

        private Board board; //represents the board

        private Disk moveDisk;  //active disc we try to move


        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create Board object with Discs objects matching the "Disk" labels on the first Peg
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            disks[0] = new Disk(lblDisk1, lblDisk1.BackColor.ToArgb(), 4, 1);
            disks[1] = new Disk(lblDisk2, lblDisk2.BackColor.ToArgb(), 3, 1);
            disks[2] = new Disk(lblDisk3, lblDisk3.BackColor.ToArgb(), 2, 1);
            disks[3] = new Disk(lblDisk4, lblDisk4.BackColor.ToArgb(), 1, 1);
            board = new Board(disks[0], disks[1], disks[2], disks[3]);
        }

        /// <summary>
        ///Move a disk from its current position to chosen position
        ///on the new Peg and displays the turn
        /// </summary>
        private void DropOnPeg(int targetPeg)
        {
            moveDisk.setPegNum(targetPeg); 
            board.move(moveDisk, board.newLevInPeg(targetPeg));            

            moveCount++;
            lblMoves.Text = moveCount.ToString();

            txtMoves.Text = board.allMovesAsString();

            if (board.board[2, 3] != null || board.board[1, 3] != null)
            {
                if (moveCount < 15)
                    MessageBox.Show("It is unfair to hack savefile!", "Trick!");
                else if (moveCount == 15)
                    MessageBox.Show("You have successfully completed the game with the minimum number of moves", "You win!");
                else
                    MessageBox.Show("You have successfully completed the game, but not with the minimum number of moves", "You win!");
            }
        }

        /// <summary>
        ///Move disk to a new peg after DragDrop is completed
        /// </summary>
        private void lblDisk1_MouseDown(object sender, MouseEventArgs e)
        {
            Label alabel = (sender as Label);
            moveDisk = board.FindDisk(alabel); //finds disk we trying to move

            if (board.canStartMove(moveDisk)) //verificate the condition if disk is on top and can be moved
            {
                DragDropEffects result = alabel.DoDragDrop(moveDisk, DragDropEffects.All);
                if (result != DragDropEffects.None)
                {
                    DropOnPeg(targetPeg);
                }
            }
            else
            {
                MessageBox.Show("You can move only the top Disk on a peg! Please choose top disk to move.", "Error");
            }
        }

        /// <summary>
        ///When a drop happens store the information about which Peg was
        ///dropped on in the global variable targetPeg
        /// </summary>
        private void lblPeg1_DragDrop(object sender, DragEventArgs e)
        {
            Label alabel = (sender as Label);
            if (alabel == lblPeg1) targetPeg = 1;
            else if (alabel == lblPeg2) targetPeg = 2;
            else if (alabel == lblPeg3) targetPeg = 3;
            if (!board.canDrop(moveDisk, targetPeg))  //check if disk is bigger on target peg
            {
                MessageBox.Show("You can put only smaller disk on top of current disk.", "Error");
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Change the cursor to show dropping is allowed
        /// </summary>
        private void lblPeg1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// Exit the game, close form
        /// </summary>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Reset the game field
        /// </summary>
        private void mnuReset_Click(object sender, EventArgs e)
        {
            board.reset();
            moveCount = 0;
            lblMoves.Text = moveCount.ToString();
            txtMoves.Clear();
        }

        /// <summary>
        /// Save current game
        /// </summary>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("SavedGame.txt");
            sw.Write(txtMoves.Text); //Get text from textbox and write it into savefile
            sw.Close();
            MessageBox.Show("Your game was saved successfully", "Saved");
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            board.reset();
            txtMoves.Clear();
            moveCount = 0;
            try
            {
                StreamReader sr = new StreamReader("SavedGame.txt");
                string line;
                while ((line = sr.ReadLine()) != null) // Read lines from the file until the end of the file is reached.
                {
                    int ind = Convert.ToInt32(line.Substring(6, 1)); //get variables for disk index and peg from savefile
                    targetPeg = Convert.ToInt32(line.Substring(23, 1));

                    moveDisk = disks[ind-1];
                    DropOnPeg(targetPeg);
                }
                sr.Close();

                MessageBox.Show("Last saved game was loaded successfully", "Succsess");
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString(), "The process has failed");
            }
        }

        /// <summary>
        /// Animate stored moves when timer is turned on
        /// </summary>
        private void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string line = txtMoves.Lines[moveCount];
            int ind = Convert.ToInt32(line.Substring(6, 1)); //get variables for disk index and peg from textbox
            targetPeg = Convert.ToInt32(line.Substring(23, 1));

            moveDisk = disks[ind - 1];
            moveDisk.setPegNum(targetPeg);
            board.move(moveDisk, board.newLevInPeg(targetPeg));

            moveCount++;
            lblMoves.Text = moveCount.ToString();

            try
            {
                string test = txtMoves.Lines[moveCount + 1]; //check if next move is exist
                test = string.Empty;
            }

            catch
            {
                tmr.Enabled = false;                        //disable timer if next string does not exist
                MessageBox.Show("Animation has ended");
            }
        }

        /// <summary>
        /// Turn on the timer 
        /// </summary>
        private void btnAnimate_Click(object sender, EventArgs e)
        {

        if (tmr.Enabled == true)
            {
                MessageBox.Show("Wait until the current animation is completed", "Error");
            }

        else if (moveCount < 1)
            {
                MessageBox.Show("Nothing to animate", "Error");
            }
        
        else
            {
                board.reset();
                tmr.Enabled = true;
                moveCount = 0;
            }
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an ancient game Hanoi Towers.\r\n\r\nFour disks are " +
                "located on the first of three pegs. It is possible to drag a disk from one Peg to another with a mouse. " +
                "The rules for a valid move are that a bigger disk cannot be dropped on top of a smaller one. " +
                "The aim of the game is to move the stack of disks to another Peg one disk at a time.\r\n\r\n" +
                "Your moves will be recorder and displayed in a text box at the right side.\r\n\r\n" +
                "It is possible to reset the disks to their original position," +
                " save your current game or load your last saved game from the [Game] menu." +
                " It is also possible to replay the moves stored in the textbox" +
                " by clicking the [Animate] button", "Help");
        }
    }
}
