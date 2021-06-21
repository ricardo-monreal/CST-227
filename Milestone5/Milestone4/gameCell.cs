//using MinesweeperBoardModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Milestone4
{
    class gameCell : Button
    {
        // initiliaze a click counter
        public int count = 0;
        private double RowNumber;
        private double ColumnNumber;
        private bool isVisited;
        private bool isLive;
        private double LiveNeighbors;

        // initialize a game cell
        public gameCell()
        {
        }
        // getters and setters for click counter
        public int getClickCount()
        {
            return this.count;
        }
        public void setClickCount()
        {
            this.count = this.count + 1;
        }

        // override click event to game cell
        protected override void OnClick(EventArgs e)
        {
            this.setClickCount();
            this.Text = Convert.ToString(this.getClickCount());
            // Change color of clicked game cell
            this.BackColor = Color.DarkGray;
        }

        
    }
}
