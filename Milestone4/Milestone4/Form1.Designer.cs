
namespace Milestone4
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
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_easty = new System.Windows.Forms.RadioButton();
            this.radio_medium = new System.Windows.Forms.RadioButton();
            this.radio_hard = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(56, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(291, 31);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "CST-227 Minesweeper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Difficulty:";
            // 
            // radio_easty
            // 
            this.radio_easty.AutoSize = true;
            this.radio_easty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_easty.Location = new System.Drawing.Point(176, 167);
            this.radio_easty.Name = "radio_easty";
            this.radio_easty.Size = new System.Drawing.Size(57, 20);
            this.radio_easty.TabIndex = 2;
            this.radio_easty.TabStop = true;
            this.radio_easty.Text = "Easy";
            this.radio_easty.UseVisualStyleBackColor = true;
            // 
            // radio_medium
            // 
            this.radio_medium.AutoSize = true;
            this.radio_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_medium.Location = new System.Drawing.Point(176, 214);
            this.radio_medium.Name = "radio_medium";
            this.radio_medium.Size = new System.Drawing.Size(74, 20);
            this.radio_medium.TabIndex = 3;
            this.radio_medium.TabStop = true;
            this.radio_medium.Text = "Medium";
            this.radio_medium.UseVisualStyleBackColor = true;
            // 
            // radio_hard
            // 
            this.radio_hard.AutoSize = true;
            this.radio_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_hard.Location = new System.Drawing.Point(176, 263);
            this.radio_hard.Name = "radio_hard";
            this.radio_hard.Size = new System.Drawing.Size(56, 20);
            this.radio_hard.TabIndex = 4;
            this.radio_hard.TabStop = true;
            this.radio_hard.Text = "Hard";
            this.radio_hard.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(134, 311);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(135, 45);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start Game!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 399);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.radio_hard);
            this.Controls.Add(this.radio_medium);
            this.Controls.Add(this.radio_easty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "CST-227 Milestone 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_easty;
        private System.Windows.Forms.RadioButton radio_medium;
        private System.Windows.Forms.RadioButton radio_hard;
        private System.Windows.Forms.Button btn_start;
    }
}

