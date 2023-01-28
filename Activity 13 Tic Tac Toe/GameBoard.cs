using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13_Tic_Tac_Toe
{
    internal class GameBoard
    {
        private char[,] boardArray = new char[3, 3];//array to keep track of current game
        private const int ROWS = 3;
        private const int COLS = 3;
        Form1 form1;

        //construct new game board 
        public GameBoard()
        {
            this.boardArray = new char[ROWS, COLS];
        }

        //add playerMark X or O to the board in the location parsed from argument Tag
        public void AddMark(PictureBox location, char playerMark)
        {
            string thisLocation = location.Tag.ToString();//get location from Tag
            int rowIndex = int.Parse(thisLocation[0].ToString());
            int colIndex = int.Parse(thisLocation[1].ToString());
            boardArray[rowIndex, colIndex] = playerMark;
        }

        //method to check for winner.
        //argument is 'X' or 'O' from last player who played
        public bool Winner(char playerMark, Form1 form1)
        {
            //this.form1 = form1;
            //search horizontal
            if (boardArray[0, 0].Equals(playerMark) && boardArray[0, 1].Equals(playerMark) && boardArray[0, 2].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "topRow");
                return true;
            }
            if (boardArray[1, 0].Equals(playerMark) && boardArray[1, 1].Equals(playerMark) && boardArray[1, 2].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "middleRow");
                return true;
            }
            if (boardArray[2, 0].Equals(playerMark) && boardArray[2, 1].Equals(playerMark) && boardArray[2, 2].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "bottomRow");
                return true;
            }

            //search vertiacal
            if (boardArray[0, 0].Equals(playerMark) && boardArray[1, 0].Equals(playerMark) && boardArray[2, 0].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "leftCol");
                return true;
            }
            if (boardArray[0, 1].Equals(playerMark) && boardArray[1, 1].Equals(playerMark) && boardArray[2, 1].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "middleCol");
                return true;
            }
            if (boardArray[0, 2].Equals(playerMark) && boardArray[1, 2].Equals(playerMark) && boardArray[2, 2].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "rightCol");
                return true;
            }

            //search diagonal
            if (boardArray[0, 0].Equals(playerMark) && boardArray[1, 1].Equals(playerMark) && boardArray[2, 2].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "downDiag");
                return true;
            }
            if (boardArray[2, 0].Equals(playerMark) && boardArray[1, 1].Equals(playerMark) && boardArray[0, 2].Equals(playerMark))
            {
                form1.SetWinner(playerMark, "upDiag");
                return true;
            }

            return false;//no winner
        }

        //method to check for draw, needs to be used when the game board
        //(array has no nulls) is full. If no winner, then it is a draw.
        //currently not using this method
        public bool Draw()
        {
            foreach (char c in boardArray)
            {
                if (c.Equals(null)) return false;//still more moves available
            }
            return true;
        }

        //Clear array for new game
        public void NewGame()
        {
            Array.Clear(boardArray, 0, boardArray.Length);
        }

        override public string ToString()
        {
            string thisString = "";
            for(int i = 0; i < ROWS; ++i)
            {
                for(int j = 0; j < COLS; ++j)
                {
                    if (j == 0) thisString += "\n{";
                    
                    thisString += boardArray[i, j];

                    if (j == COLS - 1) thisString += "}";
                    else thisString += ",";
                }
            }
            return thisString;
        }
    }
}
