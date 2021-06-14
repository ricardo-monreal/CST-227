
namespace HeroMaker
{
    partial class HeroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroForm));
            this.agePicker = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.moralLevelValueLabel = new System.Windows.Forms.Label();
            this.speedValueLabel = new System.Windows.Forms.Label();
            this.strengthValueLabel = new System.Windows.Forms.Label();
            this.staminaValueLabel = new System.Windows.Forms.Label();
            this.agilityValueLabel = new System.Windows.Forms.Label();
            this.intelligenceValueLabel = new System.Windows.Forms.Label();
            this.intellectScrollBar = new System.Windows.Forms.HScrollBar();
            this.intellectLabel = new System.Windows.Forms.Label();
            this.agilityScrollBar = new System.Windows.Forms.HScrollBar();
            this.agilityLabel = new System.Windows.Forms.Label();
            this.staminaScrollBar = new System.Windows.Forms.HScrollBar();
            this.staminaLabel = new System.Windows.Forms.Label();
            this.strengthScrollBar = new System.Windows.Forms.HScrollBar();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.speedScrollBar = new System.Windows.Forms.HScrollBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moralLeanVal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.experiencePicker = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.transportGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.abilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.flightCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.affiliationListBox = new System.Windows.Forms.CheckedListBox();
            this.affiliationGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experiencePicker)).BeginInit();
            this.transportGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.abilitiesGroupBox.SuspendLayout();
            this.affiliationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // agePicker
            // 
            this.agePicker.Location = new System.Drawing.Point(154, 67);
            this.agePicker.Margin = new System.Windows.Forms.Padding(2);
            this.agePicker.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.agePicker.Name = "agePicker";
            this.agePicker.Size = new System.Drawing.Size(106, 20);
            this.agePicker.TabIndex = 24;
            this.agePicker.ValueChanged += new System.EventHandler(this.agePicker_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Hero\'s Age (yrs):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Create Hero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.moralLevelValueLabel);
            this.groupBox7.Controls.Add(this.speedValueLabel);
            this.groupBox7.Controls.Add(this.strengthValueLabel);
            this.groupBox7.Controls.Add(this.staminaValueLabel);
            this.groupBox7.Controls.Add(this.agilityValueLabel);
            this.groupBox7.Controls.Add(this.intelligenceValueLabel);
            this.groupBox7.Controls.Add(this.intellectScrollBar);
            this.groupBox7.Controls.Add(this.intellectLabel);
            this.groupBox7.Controls.Add(this.agilityScrollBar);
            this.groupBox7.Controls.Add(this.agilityLabel);
            this.groupBox7.Controls.Add(this.staminaScrollBar);
            this.groupBox7.Controls.Add(this.staminaLabel);
            this.groupBox7.Controls.Add(this.strengthScrollBar);
            this.groupBox7.Controls.Add(this.strengthLabel);
            this.groupBox7.Controls.Add(this.speedScrollBar);
            this.groupBox7.Controls.Add(this.speedLabel);
            this.groupBox7.Location = new System.Drawing.Point(796, 102);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(227, 338);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hero\'s Stats:  (Max of 100)";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // moralLeanValueLabel
            // 
            this.moralLevelValueLabel.AutoSize = true;
            this.moralLevelValueLabel.Location = new System.Drawing.Point(-70, 206);
            this.moralLevelValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moralLevelValueLabel.Name = "moralLeanValueLabel";
            this.moralLevelValueLabel.Size = new System.Drawing.Size(0, 13);
            this.moralLevelValueLabel.TabIndex = 13;
            // 
            // speedValueLabel
            // 
            this.speedValueLabel.AutoSize = true;
            this.speedValueLabel.Location = new System.Drawing.Point(58, 26);
            this.speedValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedValueLabel.Name = "speedValueLabel";
            this.speedValueLabel.Size = new System.Drawing.Size(0, 13);
            this.speedValueLabel.TabIndex = 14;
            // 
            // strengthValueLabel
            // 
            this.strengthValueLabel.AutoSize = true;
            this.strengthValueLabel.Location = new System.Drawing.Point(70, 87);
            this.strengthValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strengthValueLabel.Name = "strengthValueLabel";
            this.strengthValueLabel.Size = new System.Drawing.Size(0, 13);
            this.strengthValueLabel.TabIndex = 13;
            // 
            // staminaValueLabel
            // 
            this.staminaValueLabel.AutoSize = true;
            this.staminaValueLabel.Location = new System.Drawing.Point(70, 143);
            this.staminaValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staminaValueLabel.Name = "staminaValueLabel";
            this.staminaValueLabel.Size = new System.Drawing.Size(0, 13);
            this.staminaValueLabel.TabIndex = 12;
            // 
            // agilityValueLabel
            // 
            this.agilityValueLabel.AutoSize = true;
            this.agilityValueLabel.Location = new System.Drawing.Point(59, 200);
            this.agilityValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.agilityValueLabel.Name = "agilityValueLabel";
            this.agilityValueLabel.Size = new System.Drawing.Size(0, 13);
            this.agilityValueLabel.TabIndex = 11;
            // 
            // intellectValueLabel
            // 
            this.intelligenceValueLabel.AutoSize = true;
            this.intelligenceValueLabel.Location = new System.Drawing.Point(70, 255);
            this.intelligenceValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intelligenceValueLabel.Name = "intellectValueLabel";
            this.intelligenceValueLabel.Size = new System.Drawing.Size(0, 13);
            this.intelligenceValueLabel.TabIndex = 10;
            // 
            // intellectScrollBar
            // 
            this.intellectScrollBar.Location = new System.Drawing.Point(8, 273);
            this.intellectScrollBar.Name = "intellectScrollBar";
            this.intellectScrollBar.Size = new System.Drawing.Size(195, 34);
            this.intellectScrollBar.TabIndex = 9;
            this.intellectScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.intellectScrollBar_Scroll_1);
            // 
            // intellectLabel
            // 
            this.intellectLabel.AutoSize = true;
            this.intellectLabel.Location = new System.Drawing.Point(9, 260);
            this.intellectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intellectLabel.Name = "intellectLabel";
            this.intellectLabel.Size = new System.Drawing.Size(61, 13);
            this.intellectLabel.TabIndex = 8;
            this.intellectLabel.Text = "Intelligence";
            // 
            // agilityScrollBar
            // 
            this.agilityScrollBar.Location = new System.Drawing.Point(8, 213);
            this.agilityScrollBar.Name = "agilityScrollBar";
            this.agilityScrollBar.Size = new System.Drawing.Size(195, 34);
            this.agilityScrollBar.TabIndex = 7;
            this.agilityScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.agilityScrollBar_Scroll_1);
            // 
            // agilityLabel
            // 
            this.agilityLabel.AutoSize = true;
            this.agilityLabel.Location = new System.Drawing.Point(9, 200);
            this.agilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(34, 13);
            this.agilityLabel.TabIndex = 6;
            this.agilityLabel.Text = "Agility";
            // 
            // staminaScrollBar
            // 
            this.staminaScrollBar.Location = new System.Drawing.Point(8, 156);
            this.staminaScrollBar.Name = "staminaScrollBar";
            this.staminaScrollBar.Size = new System.Drawing.Size(195, 34);
            this.staminaScrollBar.TabIndex = 5;
            this.staminaScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.staminaScrollBar_Scroll_1);
            // 
            // staminaLabel
            // 
            this.staminaLabel.AutoSize = true;
            this.staminaLabel.Location = new System.Drawing.Point(9, 143);
            this.staminaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staminaLabel.Name = "staminaLabel";
            this.staminaLabel.Size = new System.Drawing.Size(45, 13);
            this.staminaLabel.TabIndex = 4;
            this.staminaLabel.Text = "Stamina";
            // 
            // strengthScrollBar
            // 
            this.strengthScrollBar.Location = new System.Drawing.Point(8, 100);
            this.strengthScrollBar.Name = "strengthScrollBar";
            this.strengthScrollBar.Size = new System.Drawing.Size(195, 34);
            this.strengthScrollBar.TabIndex = 3;
            this.strengthScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.strengthScrollBar_Scroll);
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(9, 87);
            this.strengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(47, 13);
            this.strengthLabel.TabIndex = 2;
            this.strengthLabel.Text = "Strength";
            // 
            // speedScrollBar
            // 
            this.speedScrollBar.Location = new System.Drawing.Point(8, 39);
            this.speedScrollBar.Name = "speedScrollBar";
            this.speedScrollBar.Size = new System.Drawing.Size(195, 34);
            this.speedScrollBar.TabIndex = 1;
            this.speedScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedScrollBar_Scroll_1);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(5, 26);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Speed";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.moralLeanVal);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.trackBar1);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.experiencePicker);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(494, 397);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(275, 263);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hero\'s Information";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 84);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // moralLeanVal
            // 
            this.moralLeanVal.AutoSize = true;
            this.moralLeanVal.Location = new System.Drawing.Point(186, 188);
            this.moralLeanVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moralLeanVal.Name = "moralLeanVal";
            this.moralLeanVal.Size = new System.Drawing.Size(13, 13);
            this.moralLeanVal.TabIndex = 13;
            this.moralLeanVal.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 237);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Good";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 237);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Evil";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 207);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = -50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(211, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Moral Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hero\'s symbol color:";
            // 
            // experiencePicker
            // 
            this.experiencePicker.Location = new System.Drawing.Point(137, 25);
            this.experiencePicker.Margin = new System.Windows.Forms.Padding(2);
            this.experiencePicker.Name = "experiencePicker";
            this.experiencePicker.Size = new System.Drawing.Size(80, 20);
            this.experiencePicker.TabIndex = 1;
            this.experiencePicker.ValueChanged += new System.EventHandler(this.experiencePicker_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Years active:";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(15, 212);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(48, 17);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Uber";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // transportGroupBox
            // 
            this.transportGroupBox.Controls.Add(this.radioButton6);
            this.transportGroupBox.Controls.Add(this.radioButton5);
            this.transportGroupBox.Controls.Add(this.radioButton4);
            this.transportGroupBox.Controls.Add(this.radioButton3);
            this.transportGroupBox.Controls.Add(this.radioButton2);
            this.transportGroupBox.Controls.Add(this.radioButton7);
            this.transportGroupBox.Controls.Add(this.radioButton1);
            this.transportGroupBox.Location = new System.Drawing.Point(279, 397);
            this.transportGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.transportGroupBox.Name = "transportGroupBox";
            this.transportGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.transportGroupBox.Size = new System.Drawing.Size(193, 246);
            this.transportGroupBox.TabIndex = 19;
            this.transportGroupBox.TabStop = false;
            this.transportGroupBox.Text = "Way of transportation";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(13, 184);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(110, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Teletransportation";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(13, 154);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(65, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Running";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 119);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "X-Jet";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 90);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Motorcycle";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 58);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Flying";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 27);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tank";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.locationListBox);
            this.groupBox4.Location = new System.Drawing.Point(58, 398);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(202, 246);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where is the Hero located?";
            // 
            // officeListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Items.AddRange(new object[] {
            "Phoenix",
            "Tempe",
            "Mesa",
            "Chandler",
            "Gilbert",
            "Scottsdale",
            "Glendale",
            "Tucson",
            "Casa Grande",
            "Maricoa",
            "Flagstaff",
            "Prescott",
            "Sedona",
            "Nogales",
            "Payson",
            "Tombstone",
            "Bisbee"});
            this.locationListBox.Location = new System.Drawing.Point(11, 27);
            this.locationListBox.Margin = new System.Windows.Forms.Padding(2);
            this.locationListBox.Name = "officeListBox";
            this.locationListBox.Size = new System.Drawing.Size(153, 212);
            this.locationListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(494, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(275, 213);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hero\'s Journey";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(14, 170);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker3.TabIndex = 5;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Death:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 110);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saved the Earth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inception:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 44);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // abilitiesGroupBox
            // 
            this.abilitiesGroupBox.Controls.Add(this.checkBox14);
            this.abilitiesGroupBox.Controls.Add(this.checkBox10);
            this.abilitiesGroupBox.Controls.Add(this.checkBox9);
            this.abilitiesGroupBox.Controls.Add(this.checkBox8);
            this.abilitiesGroupBox.Controls.Add(this.checkBox7);
            this.abilitiesGroupBox.Controls.Add(this.checkBox6);
            this.abilitiesGroupBox.Controls.Add(this.checkBox5);
            this.abilitiesGroupBox.Controls.Add(this.checkBox3);
            this.abilitiesGroupBox.Controls.Add(this.checkBox2);
            this.abilitiesGroupBox.Controls.Add(this.flightCheckBox);
            this.abilitiesGroupBox.Location = new System.Drawing.Point(58, 109);
            this.abilitiesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.abilitiesGroupBox.Name = "abilitiesGroupBox";
            this.abilitiesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.abilitiesGroupBox.Size = new System.Drawing.Size(202, 265);
            this.abilitiesGroupBox.TabIndex = 14;
            this.abilitiesGroupBox.TabStop = false;
            this.abilitiesGroupBox.Text = "Select Hero\'s Special Powers";
            this.abilitiesGroupBox.Enter += new System.EventHandler(this.abilitiesGroupBox_Enter);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(11, 95);
            this.checkBox14.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(96, 17);
            this.checkBox14.TabIndex = 13;
            this.checkBox14.Text = "Transfiguration";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(11, 236);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(112, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Time Manipulation";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(11, 212);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(87, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Combustable";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(11, 189);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(70, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Invisibility";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(11, 166);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(109, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Enhanced Speed";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(11, 143);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(83, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Telekenesis";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(11, 120);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(73, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Telepathy";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 74);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Night Vision";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 52);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Enhanced Strength";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // flightCheckBox
            // 
            this.flightCheckBox.AutoSize = true;
            this.flightCheckBox.Location = new System.Drawing.Point(11, 29);
            this.flightCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.flightCheckBox.Name = "flightCheckBox";
            this.flightCheckBox.Size = new System.Drawing.Size(51, 17);
            this.flightCheckBox.TabIndex = 0;
            this.flightCheckBox.Text = "Flight";
            this.flightCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(154, 27);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 20);
            this.nameTextBox.TabIndex = 13;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hero\'s Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "CST-227 Hero Maker";
            // 
            // allegiencesListBox
            // 
            this.affiliationListBox.FormattingEnabled = true;
            this.affiliationListBox.Items.AddRange(new object[] {
            "The Avengers",
            "The Defenders",
            "X-Men",
            "New Mutants",
            "Galactic Empire",
            "Guardians of The Galaxy",
            "Teen Titans",
            "Flying Solo"});
            this.affiliationListBox.Location = new System.Drawing.Point(17, 29);
            this.affiliationListBox.Margin = new System.Windows.Forms.Padding(2);
            this.affiliationListBox.Name = "allegiencesListBox";
            this.affiliationListBox.Size = new System.Drawing.Size(159, 154);
            this.affiliationListBox.TabIndex = 0;
            // 
            // allegiancesGroupBox
            // 
            this.affiliationGroupBox.Controls.Add(this.affiliationListBox);
            this.affiliationGroupBox.Location = new System.Drawing.Point(279, 109);
            this.affiliationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.affiliationGroupBox.Name = "allegiancesGroupBox";
            this.affiliationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.affiliationGroupBox.Size = new System.Drawing.Size(193, 213);
            this.affiliationGroupBox.TabIndex = 16;
            this.affiliationGroupBox.TabStop = false;
            this.affiliationGroupBox.Text = "Team Affiliation";
            // 
            // HeroForm
            // 
            this.ClientSize = new System.Drawing.Size(1053, 759);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.agePicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.transportGroupBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.affiliationGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.abilitiesGroupBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "HeroForm";
            this.Text = "021";
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experiencePicker)).EndInit();
            this.transportGroupBox.ResumeLayout(false);
            this.transportGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.abilitiesGroupBox.ResumeLayout(false);
            this.abilitiesGroupBox.PerformLayout();
            this.affiliationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown agePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label moralLevelValueLabel;
        private System.Windows.Forms.Label speedValueLabel;
        private System.Windows.Forms.Label strengthValueLabel;
        private System.Windows.Forms.Label staminaValueLabel;
        private System.Windows.Forms.Label agilityValueLabel;
        private System.Windows.Forms.Label intelligenceValueLabel;
        private System.Windows.Forms.HScrollBar intellectScrollBar;
        private System.Windows.Forms.Label intellectLabel;
        private System.Windows.Forms.HScrollBar agilityScrollBar;
        private System.Windows.Forms.Label agilityLabel;
        private System.Windows.Forms.HScrollBar staminaScrollBar;
        private System.Windows.Forms.Label staminaLabel;
        private System.Windows.Forms.HScrollBar strengthScrollBar;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.HScrollBar speedScrollBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label moralLeanVal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown experiencePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.GroupBox transportGroupBox;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox abilitiesGroupBox;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox flightCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox affiliationListBox;
        private System.Windows.Forms.GroupBox affiliationGroupBox;
    }
}