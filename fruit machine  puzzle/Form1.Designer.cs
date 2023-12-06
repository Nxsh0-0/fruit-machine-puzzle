namespace fruit_machine__puzzle
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
            this.MainBG = new System.Windows.Forms.PictureBox();
            this.MoneyBG = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.slot1B = new System.Windows.Forms.PictureBox();
            this.slot2T = new System.Windows.Forms.PictureBox();
            this.slot3B = new System.Windows.Forms.PictureBox();
            this.slot3T = new System.Windows.Forms.PictureBox();
            this.slot2B = new System.Windows.Forms.PictureBox();
            this.slot1T = new System.Windows.Forms.PictureBox();
            this.moneybox = new System.Windows.Forms.TextBox();
            this.nudge1 = new System.Windows.Forms.Button();
            this.nudge2 = new System.Windows.Forms.Button();
            this.nudge3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1T)).BeginInit();
            this.SuspendLayout();
            // 
            // MainBG
            // 
            this.MainBG.BackColor = System.Drawing.Color.Wheat;
            this.MainBG.Location = new System.Drawing.Point(92, 3);
            this.MainBG.Name = "MainBG";
            this.MainBG.Size = new System.Drawing.Size(1011, 640);
            this.MainBG.TabIndex = 0;
            this.MainBG.TabStop = false;
            // 
            // MoneyBG
            // 
            this.MoneyBG.BackColor = System.Drawing.Color.LightYellow;
            this.MoneyBG.Location = new System.Drawing.Point(2, 4);
            this.MoneyBG.Name = "MoneyBG";
            this.MoneyBG.Size = new System.Drawing.Size(90, 638);
            this.MoneyBG.TabIndex = 1;
            this.MoneyBG.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slot3.Location = new System.Drawing.Point(773, 234);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(100, 100);
            this.slot3.TabIndex = 2;
            this.slot3.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slot2.Location = new System.Drawing.Point(539, 234);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(100, 100);
            this.slot2.TabIndex = 3;
            this.slot2.TabStop = false;
            // 
            // slot1
            // 
            this.slot1.BackColor = System.Drawing.Color.White;
            this.slot1.Location = new System.Drawing.Point(314, 234);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(100, 100);
            this.slot1.TabIndex = 4;
            this.slot1.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Green;
            this.Start.ForeColor = System.Drawing.SystemColors.Control;
            this.Start.Location = new System.Drawing.Point(11, 46);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 52);
            this.Start.TabIndex = 5;
            this.Start.Text = "SPIN";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "HOLD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "HOLD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "HOLD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // slot1B
            // 
            this.slot1B.Location = new System.Drawing.Point(314, 178);
            this.slot1B.Name = "slot1B";
            this.slot1B.Size = new System.Drawing.Size(100, 50);
            this.slot1B.TabIndex = 9;
            this.slot1B.TabStop = false;
            // 
            // slot2T
            // 
            this.slot2T.Location = new System.Drawing.Point(539, 340);
            this.slot2T.Name = "slot2T";
            this.slot2T.Size = new System.Drawing.Size(100, 50);
            this.slot2T.TabIndex = 10;
            this.slot2T.TabStop = false;
            // 
            // slot3B
            // 
            this.slot3B.Location = new System.Drawing.Point(773, 178);
            this.slot3B.Name = "slot3B";
            this.slot3B.Size = new System.Drawing.Size(100, 50);
            this.slot3B.TabIndex = 11;
            this.slot3B.TabStop = false;
            // 
            // slot3T
            // 
            this.slot3T.Location = new System.Drawing.Point(773, 340);
            this.slot3T.Name = "slot3T";
            this.slot3T.Size = new System.Drawing.Size(100, 50);
            this.slot3T.TabIndex = 12;
            this.slot3T.TabStop = false;
            // 
            // slot2B
            // 
            this.slot2B.Location = new System.Drawing.Point(539, 178);
            this.slot2B.Name = "slot2B";
            this.slot2B.Size = new System.Drawing.Size(100, 50);
            this.slot2B.TabIndex = 13;
            this.slot2B.TabStop = false;
            // 
            // slot1T
            // 
            this.slot1T.Location = new System.Drawing.Point(314, 340);
            this.slot1T.Name = "slot1T";
            this.slot1T.Size = new System.Drawing.Size(100, 50);
            this.slot1T.TabIndex = 14;
            this.slot1T.TabStop = false;
            // 
            // moneybox
            // 
            this.moneybox.Location = new System.Drawing.Point(2, 104);
            this.moneybox.Multiline = true;
            this.moneybox.Name = "moneybox";
            this.moneybox.Size = new System.Drawing.Size(90, 68);
            this.moneybox.TabIndex = 15;
            this.moneybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudge1
            // 
            this.nudge1.Location = new System.Drawing.Point(300, 133);
            this.nudge1.Name = "nudge1";
            this.nudge1.Size = new System.Drawing.Size(75, 23);
            this.nudge1.TabIndex = 16;
            this.nudge1.Text = "NUDGE";
            this.nudge1.UseVisualStyleBackColor = true;
            this.nudge1.Click += new System.EventHandler(this.nudge1_Click);
            // 
            // nudge2
            // 
            this.nudge2.Location = new System.Drawing.Point(456, 133);
            this.nudge2.Name = "nudge2";
            this.nudge2.Size = new System.Drawing.Size(75, 23);
            this.nudge2.TabIndex = 17;
            this.nudge2.Text = "NUDGE";
            this.nudge2.UseVisualStyleBackColor = true;
            this.nudge2.Click += new System.EventHandler(this.nudge2_Click);
            // 
            // nudge3
            // 
            this.nudge3.Location = new System.Drawing.Point(624, 133);
            this.nudge3.Name = "nudge3";
            this.nudge3.Size = new System.Drawing.Size(75, 23);
            this.nudge3.TabIndex = 18;
            this.nudge3.Text = "NUDGE";
            this.nudge3.UseVisualStyleBackColor = true;
            this.nudge3.Click += new System.EventHandler(this.nudge3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 646);
            this.Controls.Add(this.nudge3);
            this.Controls.Add(this.nudge2);
            this.Controls.Add(this.nudge1);
            this.Controls.Add(this.moneybox);
            this.Controls.Add(this.slot1T);
            this.Controls.Add(this.slot2B);
            this.Controls.Add(this.slot3T);
            this.Controls.Add(this.slot3B);
            this.Controls.Add(this.slot2T);
            this.Controls.Add(this.slot1B);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.MoneyBG);
            this.Controls.Add(this.MainBG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1T)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainBG;
        private System.Windows.Forms.PictureBox MoneyBG;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox slot1B;
        private System.Windows.Forms.PictureBox slot2T;
        private System.Windows.Forms.PictureBox slot3B;
        private System.Windows.Forms.PictureBox slot3T;
        private System.Windows.Forms.PictureBox slot2B;
        private System.Windows.Forms.PictureBox slot1T;
        private System.Windows.Forms.TextBox moneybox;
        private System.Windows.Forms.Button nudge1;
        private System.Windows.Forms.Button nudge2;
        private System.Windows.Forms.Button nudge3;
    }
}

