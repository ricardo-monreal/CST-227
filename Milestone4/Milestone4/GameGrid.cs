﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4
{
    public partial class GameGrid : Form
    {

        private Panel[,] _chessBoardPanels;

        public GameGrid()
        {
            InitializeComponent();
        }

       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            const int tileSize = 40;
            const int gridSize = 12;
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;

            // initialize the "chess board"
            _chessBoardPanels = new Panel[gridSize, gridSize];

            // double for loop to handle all rows and columns
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    // create new Panel control which will be one 
                    // chess board tile
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n, tileSize * m)
                    };

                    // add to Form's Controls so that they show up
                    Controls.Add(newPanel);

                    // add to our 2d array of panels for future use
                    _chessBoardPanels[n, m] = newPanel;

                    // color the backgrounds
                    if (n % 2 == 0)
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                }
            }
        }

        

        

    }
}
