
namespace ChessBoardGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ChessPieces = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Chess piece from the drop down menu";
            // 
            // cb_ChessPieces
            // 
            this.cb_ChessPieces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChessPieces.FormattingEnabled = true;
            this.cb_ChessPieces.Items.AddRange(new object[] {
            "Knight",
            "King",
            "Rook",
            "Bishop",
            "Queen"});
            this.cb_ChessPieces.Location = new System.Drawing.Point(391, 12);
            this.cb_ChessPieces.Name = "cb_ChessPieces";
            this.cb_ChessPieces.Size = new System.Drawing.Size(121, 21);
            this.cb_ChessPieces.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_ChessPieces);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CST - 227 Activity 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ChessPieces;
        private System.Windows.Forms.Panel panel1;
    }
}

