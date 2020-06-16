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
            this.radAllAvailable = new System.Windows.Forms.RadioButton();
            this.radOutRented = new System.Windows.Forms.RadioButton();
            this.txtMovID = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnMovUpdate = new System.Windows.Forms.Button();
            this.txtMovCopies = new System.Windows.Forms.TextBox();
            this.txtMovPlot = new System.Windows.Forms.TextBox();
            this.txtRMID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBestCustomers = new System.Windows.Forms.Button();
            this.btnBestMovies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(22, 105);
            this.dgView.Margin = new System.Windows.Forms.Padding(6);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 72;
            this.dgView.Size = new System.Drawing.Size(2044, 772);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // btnCustTab
            // 
            this.btnCustTab.Location = new System.Drawing.Point(22, 52);
            this.btnCustTab.Margin = new System.Windows.Forms.Padding(6);
            this.btnCustTab.Name = "btnCustTab";
            this.btnCustTab.Size = new System.Drawing.Size(138, 42);
            this.btnCustTab.TabIndex = 1;
            this.btnCustTab.Text = "Customers";
            this.btnCustTab.UseVisualStyleBackColor = true;
            this.btnCustTab.Click += new System.EventHandler(this.btnCustTab_Click);
            // 
            // btnMoviesTab
            // 
            this.btnMoviesTab.Location = new System.Drawing.Point(171, 52);
            this.btnMoviesTab.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoviesTab.Name = "btnMoviesTab";
            this.btnMoviesTab.Size = new System.Drawing.Size(138, 42);
            this.btnMoviesTab.TabIndex = 2;
            this.btnMoviesTab.Text = "Movies";
            this.btnMoviesTab.UseVisualStyleBackColor = true;
            this.btnMoviesTab.Click += new System.EventHandler(this.btnMoviesTab_Click);
            // 
            // btnRentMoviesTab
            // 
            this.btnRentMoviesTab.Location = new System.Drawing.Point(319, 52);
            this.btnRentMoviesTab.Margin = new System.Windows.Forms.Padding(6);
            this.btnRentMoviesTab.Name = "btnRentMoviesTab";
            this.btnRentMoviesTab.Size = new System.Drawing.Size(204, 42);
            this.btnRentMoviesTab.TabIndex = 3;
            this.btnRentMoviesTab.Text = "Rented Movies";
            this.btnRentMoviesTab.UseVisualStyleBackColor = true;
            this.btnRentMoviesTab.Click += new System.EventHandler(this.btnRentMoviesTab_Click);
            // 
            // btnCustCreate
            // 
            this.btnCustCreate.Location = new System.Drawing.Point(200, 975);
            this.btnCustCreate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCustCreate.Name = "btnCustCreate";
            this.btnCustCreate.Size = new System.Drawing.Size(180, 42);
            this.btnCustCreate.TabIndex = 4;
            this.btnCustCreate.Text = "Add Customer";
            this.btnCustCreate.UseVisualStyleBackColor = true;
            this.btnCustCreate.Click += new System.EventHandler(this.btnCustCreate_Click);
            // 
            // btnCreateMovie
            // 
            this.btnCreateMovie.Location = new System.Drawing.Point(200, 1090);
            this.btnCreateMovie.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateMovie.Name = "btnCreateMovie";
            this.btnCreateMovie.Size = new System.Drawing.Size(180, 42);
            this.btnCreateMovie.TabIndex = 5;
            this.btnCreateMovie.Text = "Add Movie";
            this.btnCreateMovie.UseVisualStyleBackColor = true;
            this.btnCreateMovie.Click += new System.EventHandler(this.btnCreateMovie_Click);
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(269, 934);
            this.txtCustFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(180, 29);
            this.txtCustFirstName.TabIndex = 7;
            this.txtCustFirstName.Tag = "test";
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(461, 934);
            this.txtCustLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(180, 29);
            this.txtCustLastName.TabIndex = 8;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(653, 934);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(354, 29);
            this.txtCustAddress.TabIndex = 9;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(1019, 934);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(180, 29);
            this.txtCustPhone.TabIndex = 10;
            // 
            // txtMovTitle
            // 
            this.txtMovTitle.Location = new System.Drawing.Point(262, 1144);
            this.txtMovTitle.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovTitle.Name = "txtMovTitle";
            this.txtMovTitle.Size = new System.Drawing.Size(656, 29);
            this.txtMovTitle.TabIndex = 11;
            this.txtMovTitle.TextChanged += new System.EventHandler(this.txtMovTitle_TextChanged);
            // 
            // txtMovYear
            // 
            this.txtMovYear.Location = new System.Drawing.Point(930, 1145);
            this.txtMovYear.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovYear.Name = "txtMovYear";
            this.txtMovYear.Size = new System.Drawing.Size(125, 29);
            this.txtMovYear.TabIndex = 12;
            this.txtMovYear.TextChanged += new System.EventHandler(this.txtMovYear_TextChanged);
            // 
            // txtMovRating
            // 
            this.txtMovRating.Location = new System.Drawing.Point(1067, 1145);
            this.txtMovRating.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovRating.Name = "txtMovRating";
            this.txtMovRating.Size = new System.Drawing.Size(132, 29);
            this.txtMovRating.TabIndex = 13;
            this.txtMovRating.TextChanged += new System.EventHandler(this.txtMovRating_TextChanged);
            // 
            // txtMovGenre
            // 
            this.txtMovGenre.Location = new System.Drawing.Point(200, 1186);
            this.txtMovGenre.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovGenre.Name = "txtMovGenre";
            this.txtMovGenre.Size = new System.Drawing.Size(631, 29);
            this.txtMovGenre.TabIndex = 14;
            this.txtMovGenre.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtMovCost
            // 
            this.txtMovCost.Location = new System.Drawing.Point(843, 1186);
            this.txtMovCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovCost.Name = "txtMovCost";
            this.txtMovCost.Size = new System.Drawing.Size(215, 29);
            this.txtMovCost.TabIndex = 15;
            this.txtMovCost.TextChanged += new System.EventHandler(this.txtMovCost_TextChanged);
            // 
            // btnUpdCust
            // 
            this.btnUpdCust.Location = new System.Drawing.Point(8, 928);
            this.btnUpdCust.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdCust.Name = "btnUpdCust";
            this.btnUpdCust.Size = new System.Drawing.Size(180, 42);
            this.btnUpdCust.TabIndex = 16;
            this.btnUpdCust.Text = "Update Customer";
            this.btnUpdCust.UseVisualStyleBackColor = true;
            this.btnUpdCust.Click += new System.EventHandler(this.btnUpdCust_Click);
            // 
            // btnDelCust
            // 
            this.btnDelCust.Location = new System.Drawing.Point(392, 975);
            this.btnDelCust.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelCust.Name = "btnDelCust";
            this.btnDelCust.Size = new System.Drawing.Size(180, 42);
            this.btnDelCust.TabIndex = 17;
            this.btnDelCust.Text = "Delete Customer";
            this.btnDelCust.UseVisualStyleBackColor = true;
            this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
            // 
            // btnMovIssue
            // 
            this.btnMovIssue.Location = new System.Drawing.Point(1361, 889);
            this.btnMovIssue.Margin = new System.Windows.Forms.Padding(6);
            this.btnMovIssue.Name = "btnMovIssue";
            this.btnMovIssue.Size = new System.Drawing.Size(160, 144);
            this.btnMovIssue.TabIndex = 18;
            this.btnMovIssue.Text = "Issue Movie";
            this.btnMovIssue.UseVisualStyleBackColor = true;
            this.btnMovIssue.Click += new System.EventHandler(this.btnMovIssue_Click);
            // 
            // btnMovReturn
            // 
            this.btnMovReturn.Location = new System.Drawing.Point(1533, 889);
            this.btnMovReturn.Margin = new System.Windows.Forms.Padding(6);
            this.btnMovReturn.Name = "btnMovReturn";
            this.btnMovReturn.Size = new System.Drawing.Size(160, 144);
            this.btnMovReturn.TabIndex = 19;
            this.btnMovReturn.Text = "Return Movie";
            this.btnMovReturn.UseVisualStyleBackColor = true;
            this.btnMovReturn.Click += new System.EventHandler(this.btnMovReturn_Click);
            // 
            // radAllAvailable
            // 
            this.radAllAvailable.AutoSize = true;
            this.radAllAvailable.Location = new System.Drawing.Point(16, 35);
            this.radAllAvailable.Margin = new System.Windows.Forms.Padding(6);
            this.radAllAvailable.Name = "radAllAvailable";
            this.radAllAvailable.Size = new System.Drawing.Size(144, 29);
            this.radAllAvailable.TabIndex = 20;
            this.radAllAvailable.TabStop = true;
            this.radAllAvailable.Text = "All Available";
            this.radAllAvailable.UseVisualStyleBackColor = true;
            this.radAllAvailable.CheckedChanged += new System.EventHandler(this.radAllRented_CheckedChanged);
            // 
            // radOutRented
            // 
            this.radOutRented.AutoSize = true;
            this.radOutRented.Location = new System.Drawing.Point(172, 35);
            this.radOutRented.Margin = new System.Windows.Forms.Padding(6);
            this.radOutRented.Name = "radOutRented";
            this.radOutRented.Size = new System.Drawing.Size(163, 29);
            this.radOutRented.TabIndex = 21;
            this.radOutRented.TabStop = true;
            this.radOutRented.Text = "All Out Rented";
            this.radOutRented.UseVisualStyleBackColor = true;
            this.radOutRented.CheckedChanged += new System.EventHandler(this.radOutRented_CheckedChanged);
            // 
            // txtMovID
            // 
            this.txtMovID.Location = new System.Drawing.Point(200, 1145);
            this.txtMovID.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovID.Name = "txtMovID";
            this.txtMovID.Size = new System.Drawing.Size(50, 29);
            this.txtMovID.TabIndex = 22;
            this.txtMovID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(200, 934);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(57, 29);
            this.txtCustID.TabIndex = 23;
            // 
            // btnMovUpdate
            // 
            this.btnMovUpdate.Location = new System.Drawing.Point(8, 1138);
            this.btnMovUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnMovUpdate.Name = "btnMovUpdate";
            this.btnMovUpdate.Size = new System.Drawing.Size(180, 42);
            this.btnMovUpdate.TabIndex = 24;
            this.btnMovUpdate.Text = "Update Movie";
            this.btnMovUpdate.UseVisualStyleBackColor = true;
            this.btnMovUpdate.Click += new System.EventHandler(this.btnMovUpdate_Click);
            // 
            // txtMovCopies
            // 
            this.txtMovCopies.Location = new System.Drawing.Point(1067, 1186);
            this.txtMovCopies.Name = "txtMovCopies";
            this.txtMovCopies.Size = new System.Drawing.Size(132, 29);
            this.txtMovCopies.TabIndex = 25;
            // 
            // txtMovPlot
            // 
            this.txtMovPlot.Location = new System.Drawing.Point(200, 1224);
            this.txtMovPlot.Multiline = true;
            this.txtMovPlot.Name = "txtMovPlot";
            this.txtMovPlot.Size = new System.Drawing.Size(999, 150);
            this.txtMovPlot.TabIndex = 26;
            // 
            // txtRMID
            // 
            this.txtRMID.Location = new System.Drawing.Point(1470, 1249);
            this.txtRMID.Name = "txtRMID";
            this.txtRMID.Size = new System.Drawing.Size(100, 29);
            this.txtRMID.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAllAvailable);
            this.groupBox1.Controls.Add(this.radOutRented);
            this.groupBox1.Location = new System.Drawing.Point(1361, 1055);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btnBestCustomers
            // 
            this.btnBestCustomers.Location = new System.Drawing.Point(535, 52);
            this.btnBestCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.btnBestCustomers.Name = "btnBestCustomers";
            this.btnBestCustomers.Size = new System.Drawing.Size(204, 42);
            this.btnBestCustomers.TabIndex = 29;
            this.btnBestCustomers.Text = "Best Customers";
            this.btnBestCustomers.UseVisualStyleBackColor = true;
            this.btnBestCustomers.Click += new System.EventHandler(this.btnBestCustomers_Click);
            // 
            // btnBestMovies
            // 
            this.btnBestMovies.Location = new System.Drawing.Point(751, 52);
            this.btnBestMovies.Margin = new System.Windows.Forms.Padding(6);
            this.btnBestMovies.Name = "btnBestMovies";
            this.btnBestMovies.Size = new System.Drawing.Size(204, 42);
            this.btnBestMovies.TabIndex = 30;
            this.btnBestMovies.Text = "Best Movies";
            this.btnBestMovies.UseVisualStyleBackColor = true;
            this.btnBestMovies.Click += new System.EventHandler(this.btnBestMovies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2081, 1429);
            this.Controls.Add(this.btnBestMovies);
            this.Controls.Add(this.btnBestCustomers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRMID);
            this.Controls.Add(this.txtMovPlot);
            this.Controls.Add(this.txtMovCopies);
            this.Controls.Add(this.btnMovUpdate);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.txtMovID);
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
            this.Controls.Add(this.btnCreateMovie);
            this.Controls.Add(this.btnCustCreate);
            this.Controls.Add(this.btnRentMoviesTab);
            this.Controls.Add(this.btnMoviesTab);
            this.Controls.Add(this.btnCustTab);
            this.Controls.Add(this.dgView);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radAllAvailable;
        private System.Windows.Forms.RadioButton radOutRented;
        private System.Windows.Forms.TextBox txtMovID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnMovUpdate;
        private System.Windows.Forms.TextBox txtMovCopies;
        private System.Windows.Forms.TextBox txtMovPlot;
        private System.Windows.Forms.TextBox txtRMID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBestCustomers;
        private System.Windows.Forms.Button btnBestMovies;
    }
}

