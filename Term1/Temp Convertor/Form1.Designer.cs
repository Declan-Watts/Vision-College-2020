namespace Temp_Convertor
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
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblOne = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(12, 12);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(215, 420);
            this.lbxOutput.TabIndex = 0;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(305, 82);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 1;
            this.txtTemp.TextChanged += new System.EventHandler(this.txtTemp_TextChanged);
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(302, 57);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(88, 13);
            this.lblOne.TabIndex = 2;
            this.lblOne.Text = "Enter Temp Here";
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(518, 73);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(94, 29);
            this.btnCelsius.TabIndex = 3;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(519, 108);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(93, 29);
            this.btnFahrenheit.TabIndex = 4;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lbxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnFahrenheit;
    }
}

