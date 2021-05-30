using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUI
{
    public partial class Form1 : Form
    {
        // reference Board class from class library
        static Board myBoard = new Board(8);
        // 2d array of buttons
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            int buttonSize = panel1.Width / myBoard.Size;
            // make the buttons square
            panel1.Height = panel1.Width;

            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    // add click event
                    btnGrid[i, j].Click += Grid_Button_Click;
                    panel1.Controls.Add(btnGrid[i, j]);


                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }

        }

        

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("you clicked a button");
            // get the row and column number of the button clicked
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;
            

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid[x, y];

            
            // determine legal next moves, select current cell and selected drop down menu item
            myBoard.MarkNextLegalMoves(currentCell, (string)cb_ChessPieces.SelectedItem);


            updateButtonLables();
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].BackColor = default(Color);
                }
                
            }
            (sender as Button).BackColor = Color.Cornsilk;
            // update the text on each button
            //for (int i = 0; i < myBoard.Size; i++)
            //{
            //    for (int j = 0; j < myBoard.Size; j++)
            //    {
            //        // clear the board
            //        btnGrid[i, j].Text = "";

            //        // determine if legal move or occupied
            //        if (myBoard.theGrid[i,j].LegalNextMove == true)
            //        {
            //            btnGrid[i, j].Text = "Legal";
            //        }
            //        else if (myBoard.theGrid[i, j].CurrentlyOccupied == true)
            //        {

            //            btnGrid[i, j].Text = (string)cb_ChessPieces.SelectedItem;
            //        }

            //    }
            //    (sender as Button).BackColor = Color.Cornsilk;
            //}


        }

        private void updateButtonLables()
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    // clear the board
                    btnGrid[i, j].Text = "";
                    if (myBoard.theGrid[i, j].CurrentlyOccupied)
                    {
                        btnGrid[i, j].Text = (string)cb_ChessPieces.SelectedItem;
                    }
                    if (myBoard.theGrid[i,j].LegalNextMove)
                    {
                        btnGrid[i, j].Text = "Legal";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
