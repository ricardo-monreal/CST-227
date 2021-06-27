
namespace Milestone6
{
    partial class HighScore
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
            this.label_topFive = new System.Windows.Forms.Label();
            this.label_playerInitials = new System.Windows.Forms.Label();
            this.textBox_initials = new System.Windows.Forms.TextBox();
            this.label_score = new System.Windows.Forms.Label();
            this.label_playerScore = new System.Windows.Forms.Label();
            this.button_addScore = new System.Windows.Forms.Button();
            this.label_highScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_topFive
            // 
            this.label_topFive.AutoSize = true;
            this.label_topFive.Location = new System.Drawing.Point(209, 9);
            this.label_topFive.Name = "label_topFive";
            this.label_topFive.Size = new System.Drawing.Size(71, 13);
            this.label_topFive.TabIndex = 0;
            this.label_topFive.Text = "Top 5 Scores";
            //this.label_topFive.Click += new System.EventHandler(this.label_topFive_Click);
            // 
            // label_playerInitials
            // 
            this.label_playerInitials.AutoSize = true;
            this.label_playerInitials.Location = new System.Drawing.Point(12, 57);
            this.label_playerInitials.Name = "label_playerInitials";
            this.label_playerInitials.Size = new System.Drawing.Size(92, 13);
            this.label_playerInitials.TabIndex = 1;
            this.label_playerInitials.Text = "Enter Your Initials:";
            //this.label_playerInitials.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_initials
            // 
            this.textBox_initials.Location = new System.Drawing.Point(110, 54);
            this.textBox_initials.Name = "textBox_initials";
            this.textBox_initials.Size = new System.Drawing.Size(61, 20);
            this.textBox_initials.TabIndex = 2;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(202, 57);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(41, 13);
            this.label_score.TabIndex = 3;
            this.label_score.Text = "Score: ";
            // 
            // label_playerScore
            // 
            this.label_playerScore.AutoSize = true;
            this.label_playerScore.Location = new System.Drawing.Point(250, 57);
            this.label_playerScore.Name = "label_playerScore";
            this.label_playerScore.Size = new System.Drawing.Size(63, 13);
            this.label_playerScore.TabIndex = 4;
            this.label_playerScore.Text = "playerScore";
            // 
            // button_addScore
            // 
            this.button_addScore.Location = new System.Drawing.Point(379, 52);
            this.button_addScore.Name = "button_addScore";
            this.button_addScore.Size = new System.Drawing.Size(75, 23);
            this.button_addScore.TabIndex = 5;
            this.button_addScore.Text = "Add Entry";
            this.button_addScore.UseVisualStyleBackColor = true;
            this.button_addScore.Click += new System.EventHandler(this.button_addScore_Click);
            // 
            // label_highScores
            // 
            this.label_highScores.Location = new System.Drawing.Point(82, 106);
            this.label_highScores.Name = "label_highScores";
            this.label_highScores.Size = new System.Drawing.Size(322, 243);
            this.label_highScores.TabIndex = 6;
            this.label_highScores.Text = "label1";
            this.label_highScores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 419);
            this.Controls.Add(this.label_highScores);
            this.Controls.Add(this.button_addScore);
            this.Controls.Add(this.label_playerScore);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.textBox_initials);
            this.Controls.Add(this.label_playerInitials);
            this.Controls.Add(this.label_topFive);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_topFive;
        private System.Windows.Forms.Label label_playerInitials;
        private System.Windows.Forms.TextBox textBox_initials;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_playerScore;
        private System.Windows.Forms.Button button_addScore;
        private System.Windows.Forms.Label label_highScores;
    }
}