
namespace FileIOGUI
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
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_url = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(11, 22);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(60, 13);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "First Name:";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(11, 69);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(61, 13);
            this.label_lastName.TabIndex = 1;
            this.label_lastName.Text = "Last Name:";
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(11, 113);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(32, 13);
            this.label_url.TabIndex = 2;
            this.label_url.Text = "URL:";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(14, 159);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(186, 23);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Add to List -->";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(125, 226);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save to File";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(125, 269);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 5;
            this.button_load.Text = "Load from File";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(76, 19);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(124, 20);
            this.textBox_firstName.TabIndex = 8;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(78, 66);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(122, 20);
            this.textBox_lastName.TabIndex = 9;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(78, 110);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(122, 20);
            this.textBox_url.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 273);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 323);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.label_firstName);
            this.Name = "Form1";
            this.Text = "People I Know";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.TextBox textBox1;
    }
}

