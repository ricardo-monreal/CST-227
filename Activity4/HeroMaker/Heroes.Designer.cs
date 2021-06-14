
namespace HeroMaker
{
    partial class Heroes
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
            this.heroInfoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.heroesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // heroInfoBox
            // 
            this.heroInfoBox.Location = new System.Drawing.Point(267, 39);
            this.heroInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.heroInfoBox.Multiline = true;
            this.heroInfoBox.Name = "heroInfoBox";
            this.heroInfoBox.Size = new System.Drawing.Size(322, 264);
            this.heroInfoBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hero\'s Information:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Heroes:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // heroesListBox
            // 
            this.heroesListBox.FormattingEnabled = true;
            this.heroesListBox.Location = new System.Drawing.Point(38, 39);
            this.heroesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.heroesListBox.Name = "heroesListBox";
            this.heroesListBox.Size = new System.Drawing.Size(173, 264);
            this.heroesListBox.TabIndex = 5;
            this.heroesListBox.SelectedIndexChanged += new System.EventHandler(this.heroesListBox_SelectedIndexChanged_1);
            // 
            // Heroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 390);
            this.Controls.Add(this.heroInfoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.heroesListBox);
            this.Name = "Heroes";
            this.Text = "Heroes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heroInfoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox heroesListBox;
    }
}