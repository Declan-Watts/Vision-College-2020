namespace DSED05
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
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.pbRacer1 = new System.Windows.Forms.PictureBox();
            this.pbRacer4 = new System.Windows.Forms.PictureBox();
            this.pbRacer3 = new System.Windows.Forms.PictureBox();
            this.pbRacer2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.puntersRADBox = new System.Windows.Forms.GroupBox();
            this.radJeremy = new System.Windows.Forms.RadioButton();
            this.radVaughn = new System.Windows.Forms.RadioButton();
            this.radJack = new System.Windows.Forms.RadioButton();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxRacers = new System.Windows.Forms.ComboBox();
            this.lblJack = new System.Windows.Forms.Label();
            this.lblVaughn = new System.Windows.Forms.Label();
            this.lblJeremy = new System.Windows.Forms.Label();
            this.lbxEvents = new System.Windows.Forms.ListBox();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer2)).BeginInit();
            this.puntersRADBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackgroundImage = global::DSED05.Properties.Resources.background;
            this.pbRaceTrack.Location = new System.Drawing.Point(16, 17);
            this.pbRaceTrack.Margin = new System.Windows.Forms.Padding(2);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(1280, 432);
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            // 
            // pbRacer1
            // 
            this.pbRacer1.Image = global::DSED05.Properties.Resources.csharpLogoResize;
            this.pbRacer1.Location = new System.Drawing.Point(16, 17);
            this.pbRacer1.Margin = new System.Windows.Forms.Padding(2);
            this.pbRacer1.Name = "pbRacer1";
            this.pbRacer1.Size = new System.Drawing.Size(108, 108);
            this.pbRacer1.TabIndex = 1;
            this.pbRacer1.TabStop = false;
            this.pbRacer1.Click += new System.EventHandler(this.pbRacer1_Click);
            // 
            // pbRacer4
            // 
            this.pbRacer4.Image = global::DSED05.Properties.Resources.pythonLogoResize;
            this.pbRacer4.Location = new System.Drawing.Point(16, 341);
            this.pbRacer4.Margin = new System.Windows.Forms.Padding(2);
            this.pbRacer4.Name = "pbRacer4";
            this.pbRacer4.Size = new System.Drawing.Size(108, 108);
            this.pbRacer4.TabIndex = 2;
            this.pbRacer4.TabStop = false;
            // 
            // pbRacer3
            // 
            this.pbRacer3.Image = global::DSED05.Properties.Resources.phpLogoResize;
            this.pbRacer3.Location = new System.Drawing.Point(16, 233);
            this.pbRacer3.Margin = new System.Windows.Forms.Padding(2);
            this.pbRacer3.Name = "pbRacer3";
            this.pbRacer3.Size = new System.Drawing.Size(108, 108);
            this.pbRacer3.TabIndex = 3;
            this.pbRacer3.TabStop = false;
            // 
            // pbRacer2
            // 
            this.pbRacer2.Image = global::DSED05.Properties.Resources.javaLogoResize;
            this.pbRacer2.Location = new System.Drawing.Point(16, 125);
            this.pbRacer2.Margin = new System.Windows.Forms.Padding(2);
            this.pbRacer2.Name = "pbRacer2";
            this.pbRacer2.Size = new System.Drawing.Size(108, 108);
            this.pbRacer2.TabIndex = 4;
            this.pbRacer2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 481);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 49);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(144, 481);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 49);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Next Round";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Location = new System.Drawing.Point(317, 598);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(154, 31);
            this.btnPlaceBet.TabIndex = 7;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // puntersRADBox
            // 
            this.puntersRADBox.Controls.Add(this.radJeremy);
            this.puntersRADBox.Controls.Add(this.radVaughn);
            this.puntersRADBox.Controls.Add(this.radJack);
            this.puntersRADBox.Location = new System.Drawing.Point(274, 481);
            this.puntersRADBox.Name = "puntersRADBox";
            this.puntersRADBox.Size = new System.Drawing.Size(100, 100);
            this.puntersRADBox.TabIndex = 8;
            this.puntersRADBox.TabStop = false;
            this.puntersRADBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radJeremy
            // 
            this.radJeremy.AutoSize = true;
            this.radJeremy.Location = new System.Drawing.Point(6, 62);
            this.radJeremy.Name = "radJeremy";
            this.radJeremy.Size = new System.Drawing.Size(58, 17);
            this.radJeremy.TabIndex = 2;
            this.radJeremy.TabStop = true;
            this.radJeremy.Text = "Jeremy";
            this.radJeremy.UseVisualStyleBackColor = true;
            this.radJeremy.CheckedChanged += new System.EventHandler(this.punterRad_Changed);
            // 
            // radVaughn
            // 
            this.radVaughn.AutoSize = true;
            this.radVaughn.Location = new System.Drawing.Point(6, 39);
            this.radVaughn.Name = "radVaughn";
            this.radVaughn.Size = new System.Drawing.Size(62, 17);
            this.radVaughn.TabIndex = 1;
            this.radVaughn.TabStop = true;
            this.radVaughn.Text = "Vaughn";
            this.radVaughn.UseVisualStyleBackColor = true;
            this.radVaughn.CheckedChanged += new System.EventHandler(this.punterRad_Changed);
            // 
            // radJack
            // 
            this.radJack.AutoSize = true;
            this.radJack.Location = new System.Drawing.Point(6, 16);
            this.radJack.Name = "radJack";
            this.radJack.Size = new System.Drawing.Size(48, 17);
            this.radJack.TabIndex = 0;
            this.radJack.TabStop = true;
            this.radJack.Text = "Jack";
            this.radJack.UseVisualStyleBackColor = true;
            this.radJack.CheckedChanged += new System.EventHandler(this.punterRad_Changed);
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(462, 494);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(120, 20);
            this.betAmount.TabIndex = 3;
            // 
            // cbxRacers
            // 
            this.cbxRacers.FormattingEnabled = true;
            this.cbxRacers.Location = new System.Drawing.Point(461, 519);
            this.cbxRacers.Name = "cbxRacers";
            this.cbxRacers.Size = new System.Drawing.Size(121, 21);
            this.cbxRacers.TabIndex = 9;
            // 
            // lblJack
            // 
            this.lblJack.Location = new System.Drawing.Point(380, 499);
            this.lblJack.Name = "lblJack";
            this.lblJack.Size = new System.Drawing.Size(75, 23);
            this.lblJack.TabIndex = 10;
            this.lblJack.Text = "label1";
            // 
            // lblVaughn
            // 
            this.lblVaughn.Location = new System.Drawing.Point(380, 522);
            this.lblVaughn.Name = "lblVaughn";
            this.lblVaughn.Size = new System.Drawing.Size(35, 13);
            this.lblVaughn.TabIndex = 11;
            this.lblVaughn.Text = "label2";
            // 
            // lblJeremy
            // 
            this.lblJeremy.AutoSize = true;
            this.lblJeremy.Location = new System.Drawing.Point(380, 545);
            this.lblJeremy.Name = "lblJeremy";
            this.lblJeremy.Size = new System.Drawing.Size(35, 13);
            this.lblJeremy.TabIndex = 12;
            this.lblJeremy.Text = "label3";
            // 
            // lbxEvents
            // 
            this.lbxEvents.FormattingEnabled = true;
            this.lbxEvents.Location = new System.Drawing.Point(605, 494);
            this.lbxEvents.Name = "lbxEvents";
            this.lbxEvents.Size = new System.Drawing.Size(483, 134);
            this.lbxEvents.TabIndex = 13;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(817, 499);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 13);
            this.lblWinner.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 698);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lbxEvents);
            this.Controls.Add(this.lblJeremy);
            this.Controls.Add(this.lblVaughn);
            this.Controls.Add(this.lblJack);
            this.Controls.Add(this.cbxRacers);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.puntersRADBox);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbRacer2);
            this.Controls.Add(this.pbRacer3);
            this.Controls.Add(this.pbRacer4);
            this.Controls.Add(this.pbRacer1);
            this.Controls.Add(this.pbRaceTrack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacer2)).EndInit();
            this.puntersRADBox.ResumeLayout(false);
            this.puntersRADBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.PictureBox pbRacer1;
        private System.Windows.Forms.PictureBox pbRacer4;
        private System.Windows.Forms.PictureBox pbRacer3;
        private System.Windows.Forms.PictureBox pbRacer2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.GroupBox puntersRADBox;
        private System.Windows.Forms.RadioButton radJeremy;
        private System.Windows.Forms.RadioButton radVaughn;
        private System.Windows.Forms.RadioButton radJack;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.ComboBox cbxRacers;
        private System.Windows.Forms.Label lblJack;
        private System.Windows.Forms.Label lblVaughn;
        private System.Windows.Forms.Label lblJeremy;
        private System.Windows.Forms.ListBox lbxEvents;
        private System.Windows.Forms.Label lblWinner;
    }
}

