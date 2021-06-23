using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;


namespace Milestone5
{
    // Extend button Class
    public class gameCell : Button
    {
        Stopwatch stopWatch = new Stopwatch();
        private double RowNumber;      
        private double ColumnNumber;   
        private bool isVisited;     
        private bool isLive;        
        private double liveNeighbors; 
        
        public int count = 0;

        public gameCell()
        {
            // set starting paramaters
            this.BackColor = Color.DarkGray;
            this.Text = "";
            this.setRow(-1);
            this.setColumn(-1);
            this.setVisited(false);
            this.setLive(false);
            this.setNeighbors(0);
            stopWatch.Start();
        }

        public int getCount()
        {
            return this.count;
        }

        public void setCount()
        {
            this.count = this.count + 1;
        }

        public void setRow(double row)
        {
            this.RowNumber = row;
        }

        public void setColumn(double column)
        {
            this.ColumnNumber = column;
        }

        public void setVisited(bool visited)
        {
            this.isVisited = visited;
        }

        public void setLive(bool live)
        {
            this.isLive = live;
        }

        public void setNeighbors(double neighbors)
        {
            this.liveNeighbors = neighbors;
        }

        public double getRow()
        {
            return this.RowNumber;
        }

        public double getCloumn()
        {
            return this.ColumnNumber;
        }

        public bool getVisited()
        {
            return this.isVisited;
        }

        public bool getLive()
        {
            return this.isLive;
        }

        public double getNeighbors()
        {
            return this.liveNeighbors;
        }

        //// override base onclick method for button class
        //protected override void OnClick(EventArgs e)
        //{

        //}

        public GameGrid Grid;

        public void createGrid(GameGrid form)
        {
            Grid = form;
        }

        // Control the grid class
        public void setupGrid(GameGrid form)
        {
            form.calculateLiveNeighbors();
        }

        // check if game is won
        public void winGrid(GameGrid form)
        {
            form.checkWin();
        }

        // if safe cell is clicked
        public void safeCell(GameGrid form)
        {
            form.floodFill(Convert.ToInt32(this.getRow()), Convert.ToInt32(this.getCloumn()));
        }

        // Form controls
        protected override void OnMouseDown(MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                // On Left Mouse Click
                case MouseButtons.Left:

                    // if live cell is clicked
                    if (this.getNeighbors() == 9)
                    {
                        setupGrid(Grid);
                        stopWatch.Stop();

                        TimeSpan ts = stopWatch.Elapsed;

                        // Format and display the TimeSpan value.
                        string text = String.Format("Game Over!\n Your play time was\n{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                        // display play time to user
                        MessageBox.Show(text);
                    }
                    else if (this.getNeighbors() == 0)
                    {
                        // if safe cell is clicked
                        this.BackColor = Color.LightGray;
                        this.Image = null;
                        safeCell(Grid);
                    }
                    // if anything else is clicked 
                    else if (this.getNeighbors() > 0)
                    {
                        this.BackColor = Color.LightGray;
                        this.Image = null;
                        this.Text = Convert.ToString(this.getNeighbors());
                    }
                    this.setVisited(true);
                    winGrid(Grid);
                    break;

                // get flag on right click
                case MouseButtons.Right:
                    this.Text = "";
                    // Assign an image to the button.
                    this.BackColor = Color.LightGray;
                    this.Image = Properties.Resources.flag;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }

        // show live bombs
        public void revealLive()
        {
            this.Text = "";
            this.BackColor = Color.LightGray;
            this.Image = Properties.Resources.bomb;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // show cell neighbors
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
            this.BackColor = Color.LightGray;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }

}
