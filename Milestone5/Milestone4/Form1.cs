using Milestone5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // created game grid based on passed int parameter
            if (radio_easty.Checked)
            {
                GameGrid game = new GameGrid(1);
                game.Show();
            }
            else if (radio_medium.Checked)
            {
                GameGrid game = new GameGrid(2);
                game.Show();
            }
            else if (radio_hard.Checked)
            {
                GameGrid game = new GameGrid(3);
                game.Show();
            }
        }
    }
}
