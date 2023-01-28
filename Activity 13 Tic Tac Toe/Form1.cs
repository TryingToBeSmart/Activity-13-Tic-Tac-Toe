using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool x = true;//true = x's turn false o's turn
        private GameBoard gameBoard = new GameBoard();//object to keep track of game board matrix
        private static bool play = true;//play while true

        //mapping for picture objects
        //used when comparing 
        //https://stackoverflow.com/questions/28001800/change-picturebox-image-onclick
        private Bitmap blank = Properties.Resources.blank;
        private Bitmap O = Properties.Resources.O;
        private Bitmap O_winner = Properties.Resources.O_winner;
        private Bitmap X = Properties.Resources.X;
        private Bitmap X_winner = Properties.Resources.X_winner;


        //clear all spaces - set them all to black
        public void ClearAll()
        {
            //set pictures to black
            topLeftPictureBox.BackgroundImage = blank;
            topMiddlePictureBox.BackgroundImage = blank;
            topRightPictureBox.BackgroundImage = blank;
            middleLeftPictureBox.BackgroundImage = blank;
            middleMiddlePictureBox.BackgroundImage = blank;
            middleRightPictureBox.BackgroundImage = blank;
            bottomLeftPictureBox.BackgroundImage = blank;
            bottomMiddlePictureBox.BackgroundImage = blank;
            bottomRightPictureBox.BackgroundImage = blank;

            //set cursers to pointer
            topLeftPictureBox.Cursor = Cursors.Hand;
            topMiddlePictureBox.Cursor = Cursors.Hand;
            topRightPictureBox.Cursor = Cursors.Hand;
            middleLeftPictureBox.Cursor = Cursors.Hand;
            middleMiddlePictureBox.Cursor = Cursors.Hand;
            middleRightPictureBox.Cursor = Cursors.Hand;
            bottomLeftPictureBox.Cursor = Cursors.Hand;
            bottomMiddlePictureBox.Cursor = Cursors.Hand;
            bottomRightPictureBox.Cursor = Cursors.Hand;
        }

        //changes the pictures to show the winning 3 images
        public void SetWinner(char playerMark, string group)
        {
            if (group.Equals("topRow"))
            {
                if(playerMark.Equals('X')) 
                    topLeftPictureBox.BackgroundImage = topMiddlePictureBox.BackgroundImage = topRightPictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    topLeftPictureBox.BackgroundImage = topMiddlePictureBox.BackgroundImage = topRightPictureBox.BackgroundImage = O_winner;
            }
            if (group.Equals("middleRow"))
            {
                if (playerMark.Equals('X'))
                    middleLeftPictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = middleRightPictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    middleLeftPictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = middleRightPictureBox.BackgroundImage = O_winner;
            }
            if (group.Equals("bottomRow"))
            {
                if (playerMark.Equals('X'))
                    bottomLeftPictureBox.BackgroundImage = bottomMiddlePictureBox.BackgroundImage = bottomRightPictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    bottomLeftPictureBox.BackgroundImage = bottomMiddlePictureBox.BackgroundImage = bottomRightPictureBox.BackgroundImage = O_winner;
            }
            if (group.Equals("leftCol"))
            {
                if (playerMark.Equals('X'))
                    topLeftPictureBox.BackgroundImage = middleLeftPictureBox.BackgroundImage = bottomLeftPictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    topLeftPictureBox.BackgroundImage = middleLeftPictureBox.BackgroundImage = bottomLeftPictureBox.BackgroundImage = O_winner;
            }
            if (group.Equals("middleCol"))
            {
                if (playerMark.Equals('X'))
                    topMiddlePictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = bottomMiddlePictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    topMiddlePictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = bottomMiddlePictureBox.BackgroundImage = O_winner;
            }
            if (group.Equals("rightCol"))
            {
                if (playerMark.Equals('X'))
                    topRightPictureBox.BackgroundImage = middleRightPictureBox.BackgroundImage = bottomRightPictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    topRightPictureBox.BackgroundImage = middleRightPictureBox.BackgroundImage = bottomRightPictureBox.BackgroundImage = O_winner;
            }
            if (group.Equals("downDiag"))
            {
                if (playerMark.Equals('X'))
                    topLeftPictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = bottomRightPictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    topLeftPictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = bottomRightPictureBox.BackgroundImage = O_winner;
            }
            if (group.Equals("upDiag"))
            {
                if (playerMark.Equals('X'))
                    topRightPictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = bottomLeftPictureBox.BackgroundImage = X_winner;
                if (playerMark.Equals('O'))
                    topRightPictureBox.BackgroundImage = middleMiddlePictureBox.BackgroundImage = bottomLeftPictureBox.BackgroundImage = O_winner;
            }

            GameOver();
        }

        //game can continue
        public void Play()
        {
            play = true;
        }

        //end game
        public void GameOver()
        {
            play = false;

            //set cursers to 'No'
            topLeftPictureBox.Cursor = Cursors.No;
            topMiddlePictureBox.Cursor = Cursors.No;
            topRightPictureBox.Cursor = Cursors.No;
            middleLeftPictureBox.Cursor = Cursors.No;
            middleMiddlePictureBox.Cursor = Cursors.No;
            middleRightPictureBox.Cursor = Cursors.No;
            bottomLeftPictureBox.Cursor = Cursors.No;
            bottomMiddlePictureBox.Cursor = Cursors.No;
            bottomRightPictureBox.Cursor = Cursors.No;

        }

        //Who's turn is it?
        public char WhosTurn()
        {
            if (x) return 'X';
            return 'O';
        }

        //change whos turn it is
        public void ChangePlayer()
        {
            if (x == true) x = false;
            else x = true;
        }

        //change image to correct image and curser to 'no'
        public void MakePlay(PictureBox box)
        {
            if (WhosTurn() == 'X') box.BackgroundImage = X;
            else box.BackgroundImage = O;
            box.Cursor = Cursors.No;
            gameBoard.AddMark(box, WhosTurn());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clear board and set play to true;
            ClearAll();
            Play();
        }

        private void topLeftPictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (topLeftPictureBox.BackgroundImage == blank && play)
            { 
                MakePlay(topLeftPictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void topMiddlePictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (topMiddlePictureBox.BackgroundImage == blank && play)
            {
                MakePlay(topMiddlePictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void topRightPictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (topRightPictureBox.BackgroundImage == blank && play)
            {
                MakePlay(topRightPictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void middleLeftPictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (middleLeftPictureBox.BackgroundImage == blank && play)
            {
                MakePlay(middleLeftPictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void middleMiddlePictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (middleMiddlePictureBox.BackgroundImage == blank && play)
            {
                MakePlay(middleMiddlePictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void middleRightPictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (middleRightPictureBox.BackgroundImage == blank && play)
            {
                MakePlay(middleRightPictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void bottomLeftPictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (bottomLeftPictureBox.BackgroundImage == blank && play)
            {
                MakePlay(bottomLeftPictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void bottomMiddlePictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (bottomMiddlePictureBox.BackgroundImage == blank && play)
            {
                MakePlay(bottomMiddlePictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void bottomRightPictureBox_Click(object sender, EventArgs e)
        {
            //only do this if this spot is not played on (blank) and play == true
            if (bottomRightPictureBox.BackgroundImage == blank && play)
            {
                MakePlay(bottomRightPictureBox);//add player mark
                gameBoard.Winner(WhosTurn(), this);//check if winner
                ChangePlayer();//alternate to X or O
                Console.WriteLine(gameBoard.ToString());//print board to console for testing
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            gameBoard.NewGame();
            Play();
        }
    }
}   
