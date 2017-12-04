using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    class Board
    {
        //constants with the linear parameters of game objects
        const int pegStart = 120;
        const int pegGap = 180;
        const int deckHeight = 315;
        const int diskHeight = 24;

        public Disk[,] board; //condition says TWO dimentional array            
        ArrayList movements;
        Disk[] disks; //Array of disks

        private const int NUM_DISKS = 4;
        private const int NUM_PEGS = 3;

        public Board()
        {
            board = new Disk[NUM_PEGS, NUM_DISKS];
            movements = new ArrayList();

            //Array of disk objects
            disks = new Disk[NUM_DISKS];
            disks[0] = null;
            disks[1] = null;
            disks[2] = null;
            disks[3] = null;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  

            board[0, 3] = new Disk();
            board[0, 2] = new Disk();
            board[0, 1] = new Disk();
            board[0, 0] = new Disk();

            //Creating arraylist of movement 
            movements = new ArrayList();
        }

        //Alterntative constructor
        public Board(Disk d1, Disk d2, Disk d3, Disk d4)
        {
            //Storing into disks array
            disks = new Disk[NUM_DISKS];
            disks[0] = d1;
            disks[1] = d2;
            disks[2] = d3;
            disks[3] = d4;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  
            board[0, 3] = d1;
            board[0, 2] = d2;
            board[0, 1] = d3;
            board[0, 0] = d4;

            //Arraylist of movement.
            movements = new ArrayList();
        }


        public void reset()
        {
            for (int iD = 0; iD < NUM_DISKS; iD++)
            {   
                //Update disks array
                disks[iD].setPegNum(1);
                disks[iD].setLevel(NUM_DISKS - iD);
                //Remove all elements from board array
                for (int iP = 0; iP < NUM_PEGS; iP++)
                {
                    board[iP, iD] = null;
                }
            }


            //Reallocate elements 
            board[0, 3] = disks[0]; //Peg 1/Level4 
            board[0, 2] = disks[1]; //Peg 1/Level3 
            board[0, 1] = disks[2]; //Peg 1/Level2
            board[0, 0] = disks[3]; //Peg 1/Level1 

            //Remove all elements from movement arraylist
            movements.Clear();

            //Redraw game field
            Display(0, 1, 4);
            Display(1, 1, 3);
            Display(2, 1, 2);
            Display(3, 1, 1);
        }

        /// <summary>
        /// Check if disk is on top and can be moved
        /// @param active disk
        /// </summary>
        /// <param name="aDisk"></param>
        public bool canStartMove(Disk aDisk)
        {
            if ((aDisk.getLevel() == NUM_DISKS) || 
                (aDisk.getLevel() < NUM_DISKS && board[aDisk.getPegNum() - 1, aDisk.getLevel()] == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if disk is moving on top of bigger disk or on bottom
        /// @param active disk
        /// @param target peg
        /// </summary>
        /// <param name="aDisk"></param>
        /// <param name="aPeg"></param>
        public bool canDrop(Disk aDisk, int aPeg)
        {
            int aLevel = newLevInPeg(aPeg);
            if (aLevel > 1 && aDisk.getDiameter() > board[aPeg - 1, aLevel - 2].getDiameter()) //check if active disk is smaller or peg is empty
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Get old coordinates of disk, set new coordinates, stores moves
        /// @param active disk
        /// @param target level
        /// </summary>
        /// <param name="aDisk"></param>
        /// <param name="newLevel"></param>
        public void move(Disk aDisk, int newLevel)
        {
            //Find moved disk index
            int ind = -1;
            for (int i = 0; i < NUM_DISKS; i++)
            {
                if (disks[i] == aDisk)
                {
                    ind = i;
                    break;
                }
            }

            int oldPeg = getPegInd(ind);
            int oldLevel = getLevel(ind);
            int newPeg = aDisk.getPegNum();

            disks[ind].setLevel(newLevel);
            disks[ind].setPegNum(newPeg);
            board[newPeg - 1, newLevel - 1] = disks[ind];
            board[oldPeg - 1, oldLevel - 1] = null;

            //Create DiskMove object with latest turn 
            DiskMove diskMove = new DiskMove(ind, newPeg - 1);
            movements.Add(diskMove);

            Display(ind, newPeg, newLevel);
        }

        /// <summary>
        /// Return the string that contains all moves
        /// </summary>
        public string allMovesAsString()
        {
            {
                String moves = "";
                foreach (DiskMove diskMove in movements)
                {
                    moves += diskMove.AsText() + "\r\n";
                }
                return moves;
            }
        }


        /// <summary>
        /// Redraw form with current disk position.
        /// </summary>
        public void Display(int ind, int newPeg, int newLevel)
        {
            Label aLabel = disks[ind].getLabel();
            aLabel.Left = pegStart + ((newPeg - 1) * pegGap) - (disks[ind].getDiameter() / 2);
            aLabel.Top = deckHeight - (newLevel * diskHeight);
        }

        /// <summary>
        /// Find a disk by label name
        /// @param name of disk
        /// @return disk with such name
        /// </summary>
        /// <param name="aLabel"></param>
        public Disk FindDisk(Label aLabel)
        {
            int ind = -1;
            for (int i = 1; i <= NUM_DISKS; i++)
            {
                if (aLabel.Name == "lblDisk" + i.ToString())
                {
                    ind = i - 1;
                    break;
                }                    
            }
            return disks[ind];
        }

        /// <summary>
        /// Find a lowest free level for moved disk
        /// @param peg where disk was moved
        /// @return lowest free level on peg
        /// </summary>
        /// <param name="pegNum"></param>
        /// <returns></returns>
        public int newLevInPeg(int pegNum)
        {
            int newLevel = NUM_DISKS;
            for (int i = 0; i < NUM_DISKS; i++)
            {
                if (board[pegNum - 1, i] == null)
                {
                    newLevel = i + 1;
                    break;
                }
            }
            return newLevel;
        }

        /// <summary>
        /// Find peg index for selected disk
        /// @param disk index
        /// @return peg index
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public int getPegInd(int ind)
        {
            int pegInd = -1;
            for (int i = 0; i < NUM_PEGS; i++)
            {
                for (int j = 0; j < NUM_DISKS; j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j] == disks[ind])
                        {
                            pegInd = i + 1;
                            break;
                        }
                    }
                }
                if (pegInd != -1) break;
            }

            return pegInd;
        }

        /// <summary>
        /// Find level for selected disk
        /// @param disk index
        /// @return disk level
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public int getLevel(int ind)
        {
            int level = -1;
            for (int i = 0; i < NUM_PEGS; i++)
            {
                for (int j = 0; j < NUM_DISKS; j++)
                {
                    if (board[i, j] != null)
                    {
                        if (board[i, j] == disks[ind])
                        {
                            level = j + 1;
                            break;
                        }
                    }
                }
                if (level != -1) break;
            }

            return level;
        }
   }
}
