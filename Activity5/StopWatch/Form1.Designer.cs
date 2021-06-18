
namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_timer = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_target = new System.Windows.Forms.Button();
            this.label_correctHits = new System.Windows.Forms.Label();
            this.lbl_wrongHits = new System.Windows.Forms.Label();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_decoy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.Location = new System.Drawing.Point(134, 29);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(0, 29);
            this.label_timer.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(34, 400);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(109, 39);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(178, 400);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(109, 39);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(335, 400);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 39);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_target
            // 
            this.btn_target.BackColor = System.Drawing.Color.Transparent;
            this.btn_target.BackgroundImage = global::StopWatch.Properties.Resources.mole;
            this.btn_target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_target.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_target.FlatAppearance.BorderSize = 0;
            this.btn_target.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_target.ForeColor = System.Drawing.Color.Transparent;
            this.btn_target.Location = new System.Drawing.Point(194, 169);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(93, 74);
            this.btn_target.TabIndex = 4;
            this.btn_target.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_target.UseVisualStyleBackColor = false;
            this.btn_target.Visible = false;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // label_correctHits
            // 
            this.label_correctHits.AutoSize = true;
            this.label_correctHits.BackColor = System.Drawing.Color.Transparent;
            this.label_correctHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correctHits.Location = new System.Drawing.Point(12, 9);
            this.label_correctHits.Name = "label_correctHits";
            this.label_correctHits.Size = new System.Drawing.Size(92, 18);
            this.label_correctHits.TabIndex = 5;
            this.label_correctHits.Text = "Correct Hits:";
            // 
            // lbl_wrongHits
            // 
            this.lbl_wrongHits.AutoSize = true;
            this.lbl_wrongHits.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wrongHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wrongHits.Location = new System.Drawing.Point(355, 5);
            this.lbl_wrongHits.Name = "lbl_wrongHits";
            this.lbl_wrongHits.Size = new System.Drawing.Size(91, 18);
            this.lbl_wrongHits.TabIndex = 6;
            this.lbl_wrongHits.Text = "Wrong Hits: ";
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.AutoSize = true;
            this.lbl_gameOver.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver.Location = new System.Drawing.Point(105, 169);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Size = new System.Drawing.Size(285, 55);
            this.lbl_gameOver.TabIndex = 7;
            this.lbl_gameOver.Text = "Game Over!";
            this.lbl_gameOver.Visible = false;
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Location = new System.Drawing.Point(34, 275);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(159, 63);
            this.btn_playAgain.TabIndex = 8;
            this.btn_playAgain.Text = "Play Again?";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(287, 275);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 63);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_decoy
            // 
            this.btn_decoy.BackColor = System.Drawing.Color.Transparent;
            this.btn_decoy.BackgroundImage = global::StopWatch.Properties.Resources.dog1;
            this.btn_decoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_decoy.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_decoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decoy.ForeColor = System.Drawing.Color.Transparent;
            this.btn_decoy.Location = new System.Drawing.Point(15, 64);
            this.btn_decoy.Name = "btn_decoy";
            this.btn_decoy.Size = new System.Drawing.Size(108, 111);
            this.btn_decoy.TabIndex = 10;
            this.btn_decoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_decoy.UseVisualStyleBackColor = false;
            this.btn_decoy.Visible = false;
            this.btn_decoy.Click += new System.EventHandler(this.btn_decoy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StopWatch.Properties.Resources.grass_background;
            this.ClientSize = new System.Drawing.Size(491, 451);
            this.Controls.Add(this.btn_decoy);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.lbl_wrongHits);
            this.Controls.Add(this.label_correctHits);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label_timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_target;
        private System.Windows.Forms.Label label_correctHits;
        private System.Windows.Forms.Label lbl_wrongHits;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_decoy;
    }
}

