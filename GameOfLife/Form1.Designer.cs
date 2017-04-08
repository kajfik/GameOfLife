namespace GameOfLife
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.zoomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.checkBoxS1 = new System.Windows.Forms.CheckBox();
            this.checkBoxS2 = new System.Windows.Forms.CheckBox();
            this.checkBoxS3 = new System.Windows.Forms.CheckBox();
            this.checkBoxS4 = new System.Windows.Forms.CheckBox();
            this.checkBoxS8 = new System.Windows.Forms.CheckBox();
            this.checkBoxS7 = new System.Windows.Forms.CheckBox();
            this.checkBoxS6 = new System.Windows.Forms.CheckBox();
            this.checkBoxS5 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBoxS0 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBoxB0 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBoxB8 = new System.Windows.Forms.CheckBox();
            this.checkBoxB7 = new System.Windows.Forms.CheckBox();
            this.checkBoxB6 = new System.Windows.Forms.CheckBox();
            this.checkBoxB5 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBoxB4 = new System.Windows.Forms.CheckBox();
            this.checkBoxB3 = new System.Windows.Forms.CheckBox();
            this.checkBoxB2 = new System.Windows.Forms.CheckBox();
            this.checkBoxB1 = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ruleComboBox = new System.Windows.Forms.ComboBox();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.generationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 546);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(77, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "S1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(131, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "S2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(185, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "S3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(239, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "S4:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(22, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Zoom:";
            // 
            // zoomNumericUpDown
            // 
            this.zoomNumericUpDown.DecimalPlaces = 1;
            this.zoomNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.zoomNumericUpDown.Location = new System.Drawing.Point(82, 23);
            this.zoomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zoomNumericUpDown.Name = "zoomNumericUpDown";
            this.zoomNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.zoomNumericUpDown.TabIndex = 13;
            this.zoomNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.zoomNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(675, 62);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(71, 23);
            this.Start.TabIndex = 16;
            this.Start.Text = "(re)Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // checkBoxS1
            // 
            this.checkBoxS1.AutoSize = true;
            this.checkBoxS1.Location = new System.Drawing.Point(110, 66);
            this.checkBoxS1.Name = "checkBoxS1";
            this.checkBoxS1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS1.TabIndex = 17;
            this.checkBoxS1.UseVisualStyleBackColor = true;
            // 
            // checkBoxS2
            // 
            this.checkBoxS2.AutoSize = true;
            this.checkBoxS2.Checked = true;
            this.checkBoxS2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxS2.Location = new System.Drawing.Point(164, 66);
            this.checkBoxS2.Name = "checkBoxS2";
            this.checkBoxS2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS2.TabIndex = 18;
            this.checkBoxS2.UseVisualStyleBackColor = true;
            // 
            // checkBoxS3
            // 
            this.checkBoxS3.AutoSize = true;
            this.checkBoxS3.Checked = true;
            this.checkBoxS3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxS3.Location = new System.Drawing.Point(218, 66);
            this.checkBoxS3.Name = "checkBoxS3";
            this.checkBoxS3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS3.TabIndex = 19;
            this.checkBoxS3.UseVisualStyleBackColor = true;
            // 
            // checkBoxS4
            // 
            this.checkBoxS4.AutoSize = true;
            this.checkBoxS4.Location = new System.Drawing.Point(272, 66);
            this.checkBoxS4.Name = "checkBoxS4";
            this.checkBoxS4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS4.TabIndex = 20;
            this.checkBoxS4.UseVisualStyleBackColor = true;
            // 
            // checkBoxS8
            // 
            this.checkBoxS8.AutoSize = true;
            this.checkBoxS8.Location = new System.Drawing.Point(487, 66);
            this.checkBoxS8.Name = "checkBoxS8";
            this.checkBoxS8.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS8.TabIndex = 28;
            this.checkBoxS8.UseVisualStyleBackColor = true;
            // 
            // checkBoxS7
            // 
            this.checkBoxS7.AutoSize = true;
            this.checkBoxS7.Location = new System.Drawing.Point(433, 66);
            this.checkBoxS7.Name = "checkBoxS7";
            this.checkBoxS7.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS7.TabIndex = 27;
            this.checkBoxS7.UseVisualStyleBackColor = true;
            // 
            // checkBoxS6
            // 
            this.checkBoxS6.AutoSize = true;
            this.checkBoxS6.Location = new System.Drawing.Point(379, 66);
            this.checkBoxS6.Name = "checkBoxS6";
            this.checkBoxS6.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS6.TabIndex = 26;
            this.checkBoxS6.UseVisualStyleBackColor = true;
            // 
            // checkBoxS5
            // 
            this.checkBoxS5.AutoSize = true;
            this.checkBoxS5.Location = new System.Drawing.Point(325, 66);
            this.checkBoxS5.Name = "checkBoxS5";
            this.checkBoxS5.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS5.TabIndex = 25;
            this.checkBoxS5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(454, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "S8:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(400, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "S7:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(346, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "S6:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(292, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "S5:";
            // 
            // checkBoxS0
            // 
            this.checkBoxS0.AutoSize = true;
            this.checkBoxS0.Location = new System.Drawing.Point(56, 66);
            this.checkBoxS0.Name = "checkBoxS0";
            this.checkBoxS0.Size = new System.Drawing.Size(15, 14);
            this.checkBoxS0.TabIndex = 30;
            this.checkBoxS0.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(23, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "S0:";
            // 
            // checkBoxB0
            // 
            this.checkBoxB0.AutoSize = true;
            this.checkBoxB0.Location = new System.Drawing.Point(56, 99);
            this.checkBoxB0.Name = "checkBoxB0";
            this.checkBoxB0.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB0.TabIndex = 48;
            this.checkBoxB0.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(23, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 16);
            this.label19.TabIndex = 47;
            this.label19.Text = "B0:";
            // 
            // checkBoxB8
            // 
            this.checkBoxB8.AutoSize = true;
            this.checkBoxB8.Location = new System.Drawing.Point(487, 99);
            this.checkBoxB8.Name = "checkBoxB8";
            this.checkBoxB8.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB8.TabIndex = 46;
            this.checkBoxB8.UseVisualStyleBackColor = true;
            // 
            // checkBoxB7
            // 
            this.checkBoxB7.AutoSize = true;
            this.checkBoxB7.Location = new System.Drawing.Point(433, 99);
            this.checkBoxB7.Name = "checkBoxB7";
            this.checkBoxB7.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB7.TabIndex = 45;
            this.checkBoxB7.UseVisualStyleBackColor = true;
            // 
            // checkBoxB6
            // 
            this.checkBoxB6.AutoSize = true;
            this.checkBoxB6.Location = new System.Drawing.Point(379, 99);
            this.checkBoxB6.Name = "checkBoxB6";
            this.checkBoxB6.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB6.TabIndex = 44;
            this.checkBoxB6.UseVisualStyleBackColor = true;
            // 
            // checkBoxB5
            // 
            this.checkBoxB5.AutoSize = true;
            this.checkBoxB5.Location = new System.Drawing.Point(325, 99);
            this.checkBoxB5.Name = "checkBoxB5";
            this.checkBoxB5.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB5.TabIndex = 43;
            this.checkBoxB5.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(454, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "B8:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(400, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 16);
            this.label21.TabIndex = 41;
            this.label21.Text = "B7:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(346, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 16);
            this.label22.TabIndex = 40;
            this.label22.Text = "B6:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(292, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 16);
            this.label23.TabIndex = 39;
            this.label23.Text = "B5:";
            // 
            // checkBoxB4
            // 
            this.checkBoxB4.AutoSize = true;
            this.checkBoxB4.Location = new System.Drawing.Point(272, 99);
            this.checkBoxB4.Name = "checkBoxB4";
            this.checkBoxB4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB4.TabIndex = 38;
            this.checkBoxB4.UseVisualStyleBackColor = true;
            // 
            // checkBoxB3
            // 
            this.checkBoxB3.AutoSize = true;
            this.checkBoxB3.Checked = true;
            this.checkBoxB3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxB3.Location = new System.Drawing.Point(218, 99);
            this.checkBoxB3.Name = "checkBoxB3";
            this.checkBoxB3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB3.TabIndex = 37;
            this.checkBoxB3.UseVisualStyleBackColor = true;
            // 
            // checkBoxB2
            // 
            this.checkBoxB2.AutoSize = true;
            this.checkBoxB2.Location = new System.Drawing.Point(164, 99);
            this.checkBoxB2.Name = "checkBoxB2";
            this.checkBoxB2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB2.TabIndex = 36;
            this.checkBoxB2.UseVisualStyleBackColor = true;
            // 
            // checkBoxB1
            // 
            this.checkBoxB1.AutoSize = true;
            this.checkBoxB1.Location = new System.Drawing.Point(110, 99);
            this.checkBoxB1.Name = "checkBoxB1";
            this.checkBoxB1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB1.TabIndex = 35;
            this.checkBoxB1.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(239, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 16);
            this.label24.TabIndex = 34;
            this.label24.Text = "B4:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(185, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 16);
            this.label25.TabIndex = 33;
            this.label25.Text = "B3:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(131, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 16);
            this.label26.TabIndex = 32;
            this.label26.Text = "B2:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(77, 97);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 16);
            this.label27.TabIndex = 31;
            this.label27.Text = "B1:";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(521, 62);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(71, 23);
            this.Reset.TabIndex = 49;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(598, 62);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(71, 23);
            this.Pause.TabIndex = 50;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(517, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Rule:";
            // 
            // ruleComboBox
            // 
            this.ruleComboBox.FormattingEnabled = true;
            this.ruleComboBox.Items.AddRange(new object[] {
            "Game of Life",
            "Własna zasada",
            "High Life",
            "Semena",
            "Ubrousky",
            "Vločky",
            "Suky",
            "Bludiště",
            "2x2",
            "Nahrazovač",
            "Města za zdmi",
            "Skvrny",
            "Srážlivý",
            "Pseudo life",
            "Pohyb",
            "34 Life",
            "Day & Night",
            "Přizpůsobení",
            "Korál",
            "Long life",
            "Kosoaméba"});
            this.ruleComboBox.Location = new System.Drawing.Point(569, 22);
            this.ruleComboBox.MaxDropDownItems = 16;
            this.ruleComboBox.Name = "ruleComboBox";
            this.ruleComboBox.Size = new System.Drawing.Size(121, 21);
            this.ruleComboBox.TabIndex = 52;
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.Location = new System.Drawing.Point(179, 27);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(15, 14);
            this.gridCheckBox.TabIndex = 54;
            this.gridCheckBox.UseVisualStyleBackColor = true;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.mrzizka_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(130, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Grid:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(200, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Generation:";
            // 
            // generationLabel
            // 
            this.generationLabel.AutoSize = true;
            this.generationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generationLabel.Location = new System.Drawing.Point(287, 23);
            this.generationLabel.Name = "generationLabel";
            this.generationLabel.Size = new System.Drawing.Size(18, 20);
            this.generationLabel.TabIndex = 56;
            this.generationLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.generationLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ruleComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.checkBoxB0);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.checkBoxB8);
            this.Controls.Add(this.checkBoxB7);
            this.Controls.Add(this.checkBoxB6);
            this.Controls.Add(this.checkBoxB5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.checkBoxB4);
            this.Controls.Add(this.checkBoxB3);
            this.Controls.Add(this.checkBoxB2);
            this.Controls.Add(this.checkBoxB1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.checkBoxS0);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkBoxS8);
            this.Controls.Add(this.checkBoxS7);
            this.Controls.Add(this.checkBoxS6);
            this.Controls.Add(this.checkBoxS5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.checkBoxS4);
            this.Controls.Add(this.checkBoxS3);
            this.Controls.Add(this.checkBoxS2);
            this.Controls.Add(this.checkBoxS1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.zoomNumericUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown zoomNumericUpDown;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox checkBoxS1;
        private System.Windows.Forms.CheckBox checkBoxS2;
        private System.Windows.Forms.CheckBox checkBoxS3;
        private System.Windows.Forms.CheckBox checkBoxS4;
        private System.Windows.Forms.CheckBox checkBoxS8;
        private System.Windows.Forms.CheckBox checkBoxS7;
        private System.Windows.Forms.CheckBox checkBoxS6;
        private System.Windows.Forms.CheckBox checkBoxS5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBoxS0;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBoxB0;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBoxB8;
        private System.Windows.Forms.CheckBox checkBoxB7;
        private System.Windows.Forms.CheckBox checkBoxB6;
        private System.Windows.Forms.CheckBox checkBoxB5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox checkBoxB4;
        private System.Windows.Forms.CheckBox checkBoxB3;
        private System.Windows.Forms.CheckBox checkBoxB2;
        private System.Windows.Forms.CheckBox checkBoxB1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ruleComboBox;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label generationLabel;
    }
}

