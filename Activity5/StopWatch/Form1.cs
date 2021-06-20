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

        public static int correctHits = 0;
        public static int wrongHits = 3;


        public Form1()
        {
            InitializeComponent();
            label_correctHits.Text = String.Format($"Correct Hits: {correctHits}");
            lbl_wrongHits.Text = string.Format($"Wrong hits left: {wrongHits}");
            BackgroundImage = ((System.Drawing.Image)(Properties.Resources.grass_background));
            btn_target.Visible = true;
            btn_decoy.Visible = true;
            btn_decoy.FlatAppearance.BorderSize = 0;
            btn_playAgain.Visible = false;
            btn_exit.Visible = false;
            watch.Start();
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

            TimeSpan ts = watch.Elapsed;

            //label_timer.Text = watch.Elapsed.ToString();

            label_timer.Text = string.Format("Time elapsed: {0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10);




            if (random.Next(0,10) < 5)
            {
                btn_target.Left = random.Next(0, this.Width);
                btn_target.Top = random.Next(0, this.Height);
                btn_target.Visible = true;
                btn_decoy.Left = random.Next(0, this.Width);
                btn_decoy.Top = random.Next(0, this.Height);
                btn_decoy.Visible = true;
                endGame();
            }
        }

        public void endGame()
        {
            if (wrongHits == 0)
            {
                btn_target.Visible = false;
                btn_decoy.Visible = false;
                watch.Stop();
                btn_exit.Visible = true;
                btn_playAgain.Visible = true;
                lbl_gameOver.Visible = true;
            }
        }

        //private void btn_target_MouseEnter(object sender, EventArgs e)
        //{
        //    btn_target.BackColor = Color.Transparent;
        //}
        //private void btn_target_MouseHover(object sender, EventArgs e)
        //{
        //    btn_target.BackColor = Color.Transparent;
        //}

        //private void btn_target_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_target.BackColor = Color.Transparent;
        //}
        private void Form1_Click_1(object sender, EventArgs e)
        {
            wrongHits -= 1;
            lbl_wrongHits.Text = string.Format($"Wrong hits left: {wrongHits}");

            endGame();
        }

        private void btn_decoy_Click(object sender, EventArgs e)
        {
            wrongHits -= 1;
            lbl_wrongHits.Text = string.Format($"Wrong hits left: {wrongHits}");
            //btn_target.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.dog1));
            //btn_decoy.FlatAppearance.BorderSize = 0;
            //btn_decoy.Visible = false;
            endGame();
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            // add hit counter
            correctHits += 1;
            label_correctHits.Text = string.Format($"Correct Hits: {correctHits}");

            btn_target.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.mole));
            btn_target.FlatAppearance.BorderSize = 0;
            btn_target.Visible = false;

            if (correctHits == 5)
            {
                wrongHits += 1;
                lbl_wrongHits.Text = string.Format($"Wrong hits left: {wrongHits}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            wrongHits = 3;
            lbl_wrongHits.Text = string.Format($"Wrong hits left: {wrongHits}");
            correctHits = 0;
            label_correctHits.Text = string.Format($"Correct Hits: {correctHits}");
            watch.Restart();
            btn_playAgain.Visible = false;
            btn_exit.Visible = false;
            lbl_gameOver.Visible = false;
            btn_target.Visible = true;

        }

        

       
    }
}
