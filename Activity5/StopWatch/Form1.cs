using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
   

    public partial class Form1 : Form
    {

        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            watch.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            watch.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            watch.Reset();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //label_timer.Text = watch.Elapsed.ToString();

            
            
            label_timer.Text = watch.Elapsed.ToString();


          

            if (random.Next(0,10) < 5)
            {
                btn_target.Left = random.Next(0, this.Width);
                btn_target.Top = random.Next(0, this.Height);
                btn_target.Visible = true;
            }
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            btn_target.Visible = false;
        }
    }
}
