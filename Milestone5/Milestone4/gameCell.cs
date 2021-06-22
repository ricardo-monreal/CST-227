using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Milestone5
{
    // Extend button Class
    public class gameCell : Button
    {
        private double row;       // cell rowNumber
        private double column;    // cell columnNumber
        private bool visited;     // cell has been visited
        private bool live;        // cell is live
        private double neighbors; // cell live neighbors

        // Set initial count to 0
        public int count = 0;

        // On initialize
        public gameCell()
        {
            // set starting paramaters
            this.BackColor = Color.LightBlue;
            this.Text = "";
            this.setRow(-1);
            this.setColumn(-1);
            this.setVisited(false);
            this.setLive(false);
            this.setNeighbors(0);
        }

        // get cell count
        public int getCount()
        {
            return this.count;
        }

        // set cell count
        public void setCount()
        {
            this.count = this.count + 1;
        }

        // set cell row
        public void setRow(double row)
        {
            this.row = row;
        }

        // set cell column
        public void setColumn(double column)
        {
            this.column = column;
        }

        // set cell visited
        public void setVisited(bool visited)
        {
            this.visited = visited;
        }

        // set cell live value
        public void setLive(bool live)
        {
            this.live = live;
        }

        // set cell neighbors
        public void setNeighbors(double neighbors)
        {
            this.neighbors = neighbors;
        }

        // get cell row
        public double getRow()
        {
            return this.row;
        }

        // get cell column
        public double getCloumn()
        {
            return this.column;
        }

        // get cell visited value
        public bool getVisited()
        {
            return this.visited;
        }

        // get cell live value
        public bool getLive()
        {
            return this.live;
        }

        // get cell neighbors
        public double getNeighbors()
        {
            return this.neighbors;
        }

        // override base onclick method for button class
        protected override void OnClick(EventArgs e)
        {

        }

        // Set Grid class for each cell
        public GameGrid Grid;

        // Have Current Grid class
        public void createGrid(GameGrid form)
        {
            Grid = form;
        }

        // Control the grid class
        public void ControlGrid(GameGrid form)
        {
            form.revealGrid();
        }

        // use grind class to check in your have won the game
        public void winGrid(GameGrid form)
        {
            form.checkWin();
        }

        // reveal the 0's if a 0 value is clicked
        public void revealZerosGrid(GameGrid form)
        {
            form.revealZeros(Convert.ToInt32(this.getRow()), Convert.ToInt32(this.getCloumn()));
        }

        // Mouse controls
        protected override void OnMouseDown(MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                // On Left Mouse Click
                case MouseButtons.Left:

                    // if you hit a bomb
                    if (this.getNeighbors() == 9)
                    {
                        ControlGrid(Grid);
                        string text = "Game Over";
                        MessageBox.Show(text);
                    }
                    else if (this.getNeighbors() == 0)
                    {
                        // if you hit an 0
                        this.BackColor = Color.LightGray;
                        this.Image = null;
                        revealZerosGrid(Grid);
                    }
                    // if you hit anything else
                    else if (this.getNeighbors() > 0)
                    {
                        this.BackColor = Color.LightGray;
                        this.Image = null;
                        this.Text = Convert.ToString(this.getNeighbors());
                    }
                    this.setVisited(true);
                    winGrid(Grid);
                    break;

                // On Right Mouse Click
                case MouseButtons.Right:
                    // change text
                    this.Text = "";
                    // Assign an image to the button.
                    this.BackColor = Color.LightGray;
                    this.Image = Properties.Resources.flag;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }

        // reveal the bomb in cell is live
        public void revealLive()
        {
            // change text
            this.Text = "";
            // Assign an image to the button.
            this.BackColor = Color.LightGray;
            this.Image = Properties.Resources.bomb;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // reveal the Neighbors for each cell
        public void revealNeighbors()
        {
            // if button has neighbors
            if (this.getNeighbors() > 0)
            {
                this.Text = Convert.ToString(this.getNeighbors());
            }
            else
            {
                this.Text = "";
            }
            // Assign an image to the button.
            this.BackColor = Color.LightGray;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }

}
