namespace DSED_02
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.btnCustTab = new System.Windows.Forms.Button();
            this.btnMoviesTab = new System.Windows.Forms.Button();
            this.btnRentMoviesTab = new System.Windows.Forms.Button();
            this.btnCustCreate = new System.Windows.Forms.Button();
            this.btnCreateMovie = new System.Windows.Forms.Button();
            this.btnDelMovie = new System.Windows.Forms.Button();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtMovTitle = new System.Windows.Forms.TextBox();
            this.txtMovYear = new System.Windows.Forms.TextBox();
            this.txtMovRating = new System.Windows.Forms.TextBox();
            this.txtMovGenre = new System.Windows.Forms.TextBox();
            this.txtMovCost = new System.Windows.Forms.TextBox();
            this.btnUpdCust = new System.Windows.Forms.Button();
            this.btnDelCust = new System.Windows.Forms.Button();
            this.btnMovIssue = new System.Windows.Forms.Button();
            this.btnMovReturn = new System.Windows.Forms.Button();
            this.radAllRented = new System.Windows.Forms.RadioButton();
            this.radOutRented = new System.Windows.Forms.RadioButton();
            this.txtMovID = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnMovUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(12, 57);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(1042, 418);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // btnCustTab
            // 
            this.btnCustTab.Location = new System.Drawing.Point(12, 28);
            this.btnCustTab.Name = "btnCustTab";
            this.btnCustTab.Size = new System.Drawing.Size(75, 23);
            this.btnCustTab.TabIndex = 1;
            this.btnCustTab.Text = "Customers";
            this.btnCustTab.UseVisualStyleBackColor = true;
            this.btnCustTab.Click += new System.EventHandler(this.btnCustTab_Click);
            // 
            // btnMoviesTab
            // 
            this.btnMoviesTab.Location = new System.Drawing.Point(93, 28);
            this.btnMoviesTab.Name = "btnMoviesTab";
            this.btnMoviesTab.Size = new System.Drawing.Size(75, 23);
            this.btnMoviesTab.TabIndex = 2;
            this.btnMoviesTab.Text = "Movies";
            this.btnMoviesTab.UseVisualStyleBackColor = true;
            this.btnMoviesTab.Click += new System.EventHandler(this.btnMoviesTab_Click);
            // 
            // btnRentMoviesTab
            // 
            this.btnRentMoviesTab.Location = new System.Drawing.Point(174, 28);
            this.btnRentMoviesTab.Name = "btnRentMoviesTab";
            this.btnRentMoviesTab.Size = new System.Drawing.Size(111, 23);
            this.btnRentMoviesTab.TabIndex = 3;
            this.btnRentMoviesTab.Text = "Rented Movies";
            this.btnRentMoviesTab.UseVisualStyleBackColor = true;
            this.btnRentMoviesTab.Click += new System.EventHandler(this.btnRentMoviesTab_Click);
            // 
            // btnCustCreate
            // 
            this.btnCustCreate.Location = new System.Drawing.Point(12, 507);
            this.btnCustCreate.Name = "btnCustCreate";
            this.btnCustCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCustCreate.TabIndex = 4;
            this.btnCustCreate.Text = "Add Customer";
            this.btnCustCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreateMovie
            // 
            this.btnCreateMovie.Location = new System.Drawing.Point(12, 536);
            this.btnCreateMovie.Name = "btnCreateMovie";
            this.btnCreateMovie.Size = new System.Drawing.Size(84, 23);
            this.btnCreateMovie.TabIndex = 5;
            this.btnCreateMovie.Text = "Add Movie";
            this.btnCreateMovie.UseVisualStyleBackColor = true;
            // 
            // btnDelMovie
            // 
            this.btnDelMovie.Location = new System.Drawing.Point(12, 565);
            this.btnDelMovie.Name = "btnDelMovie";
            this.btnDelMovie.Size = new System.Drawing.Size(84, 23);
            this.btnDelMovie.TabIndex = 6;
            this.btnDelMovie.Text = "Delete Movie";
            this.btnDelMovie.UseVisualStyleBackColor = true;
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(102, 510);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCustFirstName.TabIndex = 7;
            this.txtCustFirstName.Tag = "test";
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(208, 510);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustLastName.TabIndex = 8;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(314, 510);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(134, 20);
            this.txtCustAddress.TabIndex = 9;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(454, 510);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustPhone.TabIndex = 10;
            // 
            // txtMovTitle
            // 
            this.txtMovTitle.Location = new System.Drawing.Point(137, 539);
            this.txtMovTitle.Name = "txtMovTitle";
            this.txtMovTitle.Size = new System.Drawing.Size(255, 20);
            this.txtMovTitle.TabIndex = 11;
            // 
            // txtMovYear
            // 
            this.txtMovYear.Location = new System.Drawing.Point(398, 539);
            this.txtMovYear.Name = "txtMovYear";
            this.txtMovYear.Size = new System.Drawing.Size(156, 20);
            this.txtMovYear.TabIndex = 12;
            // 
            // txtMovRating
            // 
            this.txtMovRating.Location = new System.Drawing.Point(439, 567);
            this.txtMovRating.Name = "txtMovRating";
            this.txtMovRating.Size = new System.Drawing.Size(115, 20);
            this.txtMovRating.TabIndex = 13;
            // 
            // txtMovGenre
            // 
            this.txtMovGenre.Location = new System.Drawing.Point(102, 568);
            this.txtMovGenre.Name = "txtMovGenre";
            this.txtMovGenre.Size = new System.Drawing.Size(206, 20);
            this.txtMovGenre.TabIndex = 14;
            this.txtMovGenre.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtMovCost
            // 
            this.txtMovCost.Location = new System.Drawing.Point(314, 568);
            this.txtMovCost.Name = "txtMovCost";
            this.txtMovCost.Size = new System.Drawing.Size(119, 20);
            this.txtMovCost.TabIndex = 15;
            // 
            // btnUpdCust
            // 
            this.btnUpdCust.Location = new System.Drawing.Point(161, 481);
            this.btnUpdCust.Name = "btnUpdCust";
            this.btnUpdCust.Size = new System.Drawing.Size(101, 23);
            this.btnUpdCust.TabIndex = 16;
            this.btnUpdCust.Text = "Update Customer";
            this.btnUpdCust.UseVisualStyleBackColor = true;
            this.btnUpdCust.Click += new System.EventHandler(this.btnUpdCust_Click);
            // 
            // btnDelCust
            // 
            this.btnDelCust.Location = new System.Drawing.Point(268, 481);
            this.btnDelCust.Name = "btnDelCust";
            this.btnDelCust.Size = new System.Drawing.Size(101, 23);
            this.btnDelCust.TabIndex = 17;
            this.btnDelCust.Text = "Delete Customer";
            this.btnDelCust.UseVisualStyleBackColor = true;
            this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
            // 
            // btnMovIssue
            // 
            this.btnMovIssue.Location = new System.Drawing.Point(599, 481);
            this.btnMovIssue.Name = "btnMovIssue";
            this.btnMovIssue.Size = new System.Drawing.Size(87, 78);
            this.btnMovIssue.TabIndex = 18;
            this.btnMovIssue.Text = "Issue Movie";
            this.btnMovIssue.UseVisualStyleBackColor = true;
            // 
            // btnMovReturn
            // 
            this.btnMovReturn.Location = new System.Drawing.Point(692, 481);
            this.btnMovReturn.Name = "btnMovReturn";
            this.btnMovReturn.Size = new System.Drawing.Size(87, 78);
            this.btnMovReturn.TabIndex = 19;
            this.btnMovReturn.Text = "Return Movie";
            this.btnMovReturn.UseVisualStyleBackColor = true;
            // 
            // radAllRented
            // 
            this.radAllRented.AutoSize = true;
            this.radAllRented.Location = new System.Drawing.Point(601, 585);
            this.radAllRented.Name = "radAllRented";
            this.radAllRented.Size = new System.Drawing.Size(74, 17);
            this.radAllRented.TabIndex = 20;
            this.radAllRented.TabStop = true;
            this.radAllRented.Text = "All Rented";
            this.radAllRented.UseVisualStyleBackColor = true;
            // 
            // radOutRented
            // 
            this.radOutRented.AutoSize = true;
            this.radOutRented.Location = new System.Drawing.Point(694, 585);
            this.radOutRented.Name = "radOutRented";
            this.radOutRented.Size = new System.Drawing.Size(80, 17);
            this.radOutRented.TabIndex = 21;
            this.radOutRented.TabStop = true;
            this.radOutRented.Text = "Out Rented";
            this.radOutRented.UseVisualStyleBackColor = true;
            // 
            // txtMovID
            // 
            this.txtMovID.Location = new System.Drawing.Point(102, 539);
            this.txtMovID.Name = "txtMovID";
            this.txtMovID.Size = new System.Drawing.Size(29, 20);
            this.txtMovID.TabIndex = 22;
            this.txtMovID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(102, 484);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(53, 20);
            this.txtCustID.TabIndex = 23;
            // 
            // btnMovUpdate
            // 
            this.btnMovUpdate.Location = new System.Drawing.Point(12, 594);
            this.btnMovUpdate.Name = "btnMovUpdate";
            this.btnMovUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnMovUpdate.TabIndex = 24;
            this.btnMovUpdate.Text = "Update Movie";
            this.btnMovUpdate.UseVisualStyleBackColor = true;
            this.btnMovUpdate.Click += new System.EventHandler(this.btnMovUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 631);
            this.Controls.Add(this.btnMovUpdate);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.txtMovID);
            this.Controls.Add(this.radOutRented);
            this.Controls.Add(this.radAllRented);
            this.Controls.Add(this.btnMovReturn);
            this.Controls.Add(this.btnMovIssue);
            this.Controls.Add(this.btnDelCust);
            this.Controls.Add(this.btnUpdCust);
            this.Controls.Add(this.txtMovCost);
            this.Controls.Add(this.txtMovGenre);
            this.Controls.Add(this.txtMovRating);
            this.Controls.Add(this.txtMovYear);
            this.Controls.Add(this.txtMovTitle);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustLastName);
            this.Controls.Add(this.txtCustFirstName);
            this.Controls.Add(this.btnDelMovie);
            this.Controls.Add(this.btnCreateMovie);
            this.Controls.Add(this.btnCustCreate);
            this.Controls.Add(this.btnRentMoviesTab);
            this.Controls.Add(this.btnMoviesTab);
            this.Controls.Add(this.btnCustTab);
            this.Controls.Add(this.dgView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnCustTab;
        private System.Windows.Forms.Button btnMoviesTab;
        private System.Windows.Forms.Button btnRentMoviesTab;
        private System.Windows.Forms.Button btnCustCreate;
        private System.Windows.Forms.Button btnCreateMovie;
        private System.Windows.Forms.Button btnDelMovie;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtMovTitle;
        private System.Windows.Forms.TextBox txtMovYear;
        private System.Windows.Forms.TextBox txtMovRating;
        private System.Windows.Forms.TextBox txtMovGenre;
        private System.Windows.Forms.TextBox txtMovCost;
        private System.Windows.Forms.Button btnUpdCust;
        private System.Windows.Forms.Button btnDelCust;
        private System.Windows.Forms.Button btnMovIssue;
        private System.Windows.Forms.Button btnMovReturn;
        private System.Windows.Forms.RadioButton radAllRented;
        private System.Windows.Forms.RadioButton radOutRented;
        private System.Windows.Forms.TextBox txtMovID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnMovUpdate;
    }
}

