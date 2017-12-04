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
        Disk[,] board; //condition says TWO dimentional array            
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
            for (int iP = 0; iP < NUM_PEGS; iP++)
            {
                //Remove all elements from board array
                for (int iD = 0; iD < NUM_DISKS; iD++)
                {
                    board[iP, iD] = null;

                    //Update disks array
                    disks[iD].setPegNum(0);
                    disks[iD].setLevel(NUM_DISKS - 1 - iD);
                }
            }

            //Reallocate elements 
            board[0, 3] = disks[0]; //Peg 1/Level4 
            board[0, 2] = disks[1]; //Peg 1/Level3 
            board[0, 1] = disks[2]; //Peg 1/Level2
            board[0, 0] = disks[3]; //Peg 1/Level1 

            //Remove all elements from movement arraylist
            movements.Clear();
        }


        public bool canStartMove(Disk aDisk)
        {
                return true;

        }


        public bool canDrop(Disk aDisk, int aPeg)
        {

            return true;
        }


        public void move(Disk aDisk, int newLevel)
        {

        }


        public string allMovesAsString()
        {
            return "dummy";  // Dummy return to avoid syntax error - must be changed
        }


        public void Display()
        {
  
        }


        public Disk FindDisk(Label aLabel)
        {
            Disk dummy = null;
            return dummy;  // Dummy return to avoid syntax error - must be changed
        }


        public int newLevInPeg(int pegNum)
        {
            return 1;    // Dummy return to avoid syntax error - must be changed
        }

 
        public String getText(int cnt)
        {
            return "1";    // Dummy return to avoid syntax error - must be changed
        }


        public void backToSelected(int ind)
        {

        }


        public int getPegInd(int ind)
        {
             return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public int getLevel(int ind)
        {
            return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public void unDo()
        {

        }


        public void loadData(ArrayList dm)
        {

        }
   }
}
