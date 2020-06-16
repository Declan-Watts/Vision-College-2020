namespace CSharpClassMovingMonsters
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBets = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.rbHoward = new System.Windows.Forms.RadioButton();
            this.rbJohn = new System.Windows.Forms.RadioButton();
            this.rbSusan = new System.Windows.Forms.RadioButton();
            this.lblBettorName = new System.Windows.Forms.Label();
            this.udBet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(10, 8);
            this.pb1.Margin = new System.Windows.Forms.Padding(1);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(59, 70);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(10, 87);
            this.pb2.Margin = new System.Windows.Forms.Padding(1);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(59, 70);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(10, 166);
            this.pb3.Margin = new System.Windows.Forms.Padding(1);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(59, 70);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(8, 246);
            this.pb4.Margin = new System.Windows.Forms.Padding(1);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(59, 70);
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 343);
            this.btnStart.Margin = new System.Windows.Forms.Padding(1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 31);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(134, 343);
            this.btnReset.Margin = new System.Windows.Forms.Padding(1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 31);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(268, 343);
            this.btnBets.Margin = new System.Windows.Forms.Padding(1);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(88, 31);
            this.btnBets.TabIndex = 6;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.BtnBets_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(19, 323);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(35, 13);
            this.lblWinner.TabIndex = 7;
            this.lblWinner.Text = "label1";
            // 
            // rbHoward
            // 
            this.rbHoward.AutoSize = true;
            this.rbHoward.Location = new System.Drawing.Point(417, 333);
            this.rbHoward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbHoward.Name = "rbHoward";
            this.rbHoward.Size = new System.Drawing.Size(62, 17);
            this.rbHoward.TabIndex = 8;
            this.rbHoward.TabStop = true;
            this.rbHoward.Text = "Howard";
            this.rbHoward.UseVisualStyleBackColor = true;
            this.rbHoward.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbJohn
            // 
            this.rbJohn.AutoSize = true;
            this.rbJohn.Location = new System.Drawing.Point(417, 372);
            this.rbJohn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJohn.Name = "rbJohn";
            this.rbJohn.Size = new System.Drawing.Size(48, 17);
            this.rbJohn.TabIndex = 9;
            this.rbJohn.TabStop = true;
            this.rbJohn.Text = "John";
            this.rbJohn.UseVisualStyleBackColor = true;
            this.rbJohn.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbSusan
            // 
            this.rbSusan.AutoSize = true;
            this.rbSusan.Location = new System.Drawing.Point(417, 353);
            this.rbSusan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSusan.Name = "rbSusan";
            this.rbSusan.Size = new System.Drawing.Size(55, 17);
            this.rbSusan.TabIndex = 10;
            this.rbSusan.TabStop = true;
            this.rbSusan.Text = "Susan";
            this.rbSusan.UseVisualStyleBackColor = true;
            this.rbSusan.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // lblBettorName
            // 
            this.lblBettorName.Location = new System.Drawing.Point(495, 333);
            this.lblBettorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBettorName.Name = "lblBettorName";
            this.lblBettorName.Size = new System.Drawing.Size(218, 55);
            this.lblBettorName.TabIndex = 11;
            // 
            // udBet
            // 
            this.udBet.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udBet.Location = new System.Drawing.Point(497, 314);
            this.udBet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.udBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udBet.Name = "udBet";
            this.udBet.Size = new System.Drawing.Size(80, 20);
            this.udBet.TabIndex = 12;
            this.udBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 406);
            this.Controls.Add(this.udBet);
            this.Controls.Add(this.lblBettorName);
            this.Controls.Add(this.rbSusan);
            this.Controls.Add(this.rbJohn);
            this.Controls.Add(this.rbHoward);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnBets);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.RadioButton rbHoward;
        private System.Windows.Forms.RadioButton rbJohn;
        private System.Windows.Forms.RadioButton rbSusan;
        private System.Windows.Forms.Label lblBettorName;
        private System.Windows.Forms.NumericUpDown udBet;
    }
}

