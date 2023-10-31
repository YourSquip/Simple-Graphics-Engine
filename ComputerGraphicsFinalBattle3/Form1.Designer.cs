namespace ComputerGraphicsFinalBattle3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TranslationButton = new System.Windows.Forms.Button();
            this.RotationOxButton = new System.Windows.Forms.Button();
            this.RotationOyButton = new System.Windows.Forms.Button();
            this.RotationOzButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.ScalingButton = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.MappingXButton = new System.Windows.Forms.Button();
            this.MappingYButton = new System.Windows.Forms.Button();
            this.MappingZButton = new System.Windows.Forms.Button();
            this.MappingXYButton = new System.Windows.Forms.Button();
            this.MappingYZButton = new System.Windows.Forms.Button();
            this.MappingXZButton = new System.Windows.Forms.Button();
            this.MappingStartPointButton = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1000, 2400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 642);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // TranslationButton
            // 
            this.TranslationButton.Location = new System.Drawing.Point(799, 12);
            this.TranslationButton.Name = "TranslationButton";
            this.TranslationButton.Size = new System.Drawing.Size(114, 23);
            this.TranslationButton.TabIndex = 1;
            this.TranslationButton.Text = "Translation";
            this.TranslationButton.UseVisualStyleBackColor = true;
            this.TranslationButton.Click += new System.EventHandler(this.TranslationButton_Click);
            // 
            // RotationOxButton
            // 
            this.RotationOxButton.Location = new System.Drawing.Point(763, 225);
            this.RotationOxButton.Name = "RotationOxButton";
            this.RotationOxButton.Size = new System.Drawing.Size(199, 23);
            this.RotationOxButton.TabIndex = 3;
            this.RotationOxButton.Text = "Rotation Around Ox";
            this.RotationOxButton.UseVisualStyleBackColor = true;
            this.RotationOxButton.Click += new System.EventHandler(this.RotationOxButton_Click);
            // 
            // RotationOyButton
            // 
            this.RotationOyButton.Location = new System.Drawing.Point(763, 254);
            this.RotationOyButton.Name = "RotationOyButton";
            this.RotationOyButton.Size = new System.Drawing.Size(199, 23);
            this.RotationOyButton.TabIndex = 4;
            this.RotationOyButton.Text = "Rotation Around Oy";
            this.RotationOyButton.UseVisualStyleBackColor = true;
            this.RotationOyButton.Click += new System.EventHandler(this.RotationOyButton_Click);
            // 
            // RotationOzButton
            // 
            this.RotationOzButton.Location = new System.Drawing.Point(763, 283);
            this.RotationOzButton.Name = "RotationOzButton";
            this.RotationOzButton.Size = new System.Drawing.Size(199, 23);
            this.RotationOzButton.TabIndex = 5;
            this.RotationOzButton.Text = "Rotation Around Oz";
            this.RotationOzButton.UseVisualStyleBackColor = true;
            this.RotationOzButton.Click += new System.EventHandler(this.RotationOzButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(815, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(815, 312);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(77, 15);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Enter angle:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(799, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(114, 15);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Enter difference:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(761, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(64, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(831, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(64, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(901, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 22);
            this.textBox7.TabIndex = 13;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(799, 147);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(178, 15);
            this.textBox11.TabIndex = 17;
            this.textBox11.Text = "Enter scaling odds:";
            // 
            // ScalingButton
            // 
            this.ScalingButton.Location = new System.Drawing.Point(799, 118);
            this.ScalingButton.Name = "ScalingButton";
            this.ScalingButton.Size = new System.Drawing.Size(114, 23);
            this.ScalingButton.TabIndex = 18;
            this.ScalingButton.Text = "Scaling";
            this.ScalingButton.UseVisualStyleBackColor = true;
            this.ScalingButton.Click += new System.EventHandler(this.ScalingButton_Click);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(903, 168);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(64, 22);
            this.textBox12.TabIndex = 21;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(833, 168);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(64, 22);
            this.textBox13.TabIndex = 20;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(763, 168);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(64, 22);
            this.textBox14.TabIndex = 19;
            // 
            // MappingXButton
            // 
            this.MappingXButton.Location = new System.Drawing.Point(758, 397);
            this.MappingXButton.Name = "MappingXButton";
            this.MappingXButton.Size = new System.Drawing.Size(64, 23);
            this.MappingXButton.TabIndex = 22;
            this.MappingXButton.Text = "X";
            this.MappingXButton.UseVisualStyleBackColor = true;
            this.MappingXButton.Click += new System.EventHandler(this.MappingXButton_Click);
            // 
            // MappingYButton
            // 
            this.MappingYButton.Location = new System.Drawing.Point(828, 397);
            this.MappingYButton.Name = "MappingYButton";
            this.MappingYButton.Size = new System.Drawing.Size(64, 23);
            this.MappingYButton.TabIndex = 24;
            this.MappingYButton.Text = "Y";
            this.MappingYButton.UseVisualStyleBackColor = true;
            this.MappingYButton.Click += new System.EventHandler(this.MappingYButton_Click);
            // 
            // MappingZButton
            // 
            this.MappingZButton.Location = new System.Drawing.Point(898, 397);
            this.MappingZButton.Name = "MappingZButton";
            this.MappingZButton.Size = new System.Drawing.Size(64, 23);
            this.MappingZButton.TabIndex = 25;
            this.MappingZButton.Text = "Z";
            this.MappingZButton.UseVisualStyleBackColor = true;
            this.MappingZButton.Click += new System.EventHandler(this.MappingZButton_Click);
            // 
            // MappingXYButton
            // 
            this.MappingXYButton.Location = new System.Drawing.Point(758, 426);
            this.MappingXYButton.Name = "MappingXYButton";
            this.MappingXYButton.Size = new System.Drawing.Size(64, 23);
            this.MappingXYButton.TabIndex = 26;
            this.MappingXYButton.Text = "XY";
            this.MappingXYButton.UseVisualStyleBackColor = true;
            this.MappingXYButton.Click += new System.EventHandler(this.MappingXYButton_Click);
            // 
            // MappingYZButton
            // 
            this.MappingYZButton.Location = new System.Drawing.Point(828, 426);
            this.MappingYZButton.Name = "MappingYZButton";
            this.MappingYZButton.Size = new System.Drawing.Size(64, 23);
            this.MappingYZButton.TabIndex = 27;
            this.MappingYZButton.Text = "YZ";
            this.MappingYZButton.UseVisualStyleBackColor = true;
            this.MappingYZButton.Click += new System.EventHandler(this.MappingYZButton_Click);
            // 
            // MappingXZButton
            // 
            this.MappingXZButton.Location = new System.Drawing.Point(898, 426);
            this.MappingXZButton.Name = "MappingXZButton";
            this.MappingXZButton.Size = new System.Drawing.Size(64, 23);
            this.MappingXZButton.TabIndex = 28;
            this.MappingXZButton.Text = "XZ";
            this.MappingXZButton.UseVisualStyleBackColor = true;
            this.MappingXZButton.Click += new System.EventHandler(this.MappingXZButton_Click);
            // 
            // MappingStartPointButton
            // 
            this.MappingStartPointButton.Location = new System.Drawing.Point(796, 455);
            this.MappingStartPointButton.Name = "MappingStartPointButton";
            this.MappingStartPointButton.Size = new System.Drawing.Size(112, 23);
            this.MappingStartPointButton.TabIndex = 29;
            this.MappingStartPointButton.Text = "Starting Point";
            this.MappingStartPointButton.UseVisualStyleBackColor = true;
            this.MappingStartPointButton.Click += new System.EventHandler(this.MappingStartPointButton_Click);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox15.Location = new System.Drawing.Point(701, 365);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(77, 15);
            this.textBox15.TabIndex = 30;
            this.textBox15.Text = "Mapping";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox16.Location = new System.Drawing.Point(701, 210);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(77, 15);
            this.textBox16.TabIndex = 31;
            this.textBox16.Text = "Rotation";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox17.Location = new System.Drawing.Point(703, 94);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(77, 15);
            this.textBox17.TabIndex = 32;
            this.textBox17.Text = "Scaling";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox18.Location = new System.Drawing.Point(701, 1);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(77, 15);
            this.textBox18.TabIndex = 33;
            this.textBox18.Text = "Translation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "1st task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(796, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "2nd task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Location = new System.Drawing.Point(701, 498);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(105, 15);
            this.textBox3.TabIndex = 36;
            this.textBox3.Text = "Personal Tasks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 638);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.MappingStartPointButton);
            this.Controls.Add(this.MappingXZButton);
            this.Controls.Add(this.MappingYZButton);
            this.Controls.Add(this.MappingXYButton);
            this.Controls.Add(this.MappingZButton);
            this.Controls.Add(this.MappingYButton);
            this.Controls.Add(this.MappingXButton);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.ScalingButton);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RotationOzButton);
            this.Controls.Add(this.RotationOyButton);
            this.Controls.Add(this.RotationOxButton);
            this.Controls.Add(this.TranslationButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cube";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TranslationButton;
        private System.Windows.Forms.Button RotationOxButton;
        private System.Windows.Forms.Button RotationOyButton;
        private System.Windows.Forms.Button RotationOzButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button ScalingButton;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button MappingXButton;
        private System.Windows.Forms.Button MappingYButton;
        private System.Windows.Forms.Button MappingZButton;
        private System.Windows.Forms.Button MappingXYButton;
        private System.Windows.Forms.Button MappingYZButton;
        private System.Windows.Forms.Button MappingXZButton;
        private System.Windows.Forms.Button MappingStartPointButton;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

