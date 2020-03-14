namespace AllProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.btnDash = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnCalc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTemp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashPanel = new System.Windows.Forms.Panel();
            this.lblDashTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.calcPanel = new System.Windows.Forms.Panel();
            this.lblCalcTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tmpPanel = new System.Windows.Forms.Panel();
            this.lblTmpTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCalcAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCalcMinus = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCalcMultiply = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCalcDivide = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbxCalcAnswer = new System.Windows.Forms.ListBox();
            this.txtCalcNum1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCalcNum2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.dashPanel.SuspendLayout();
            this.calcPanel.SuspendLayout();
            this.tmpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnTemp);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 553);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(996, 39);
            this.header.TabIndex = 1;
            // 
            // btnDash
            // 
            this.btnDash.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDash.BorderRadius = 0;
            this.btnDash.ButtonText = "Dashboard";
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.DisabledColor = System.Drawing.Color.Gray;
            this.btnDash.ForeColor = System.Drawing.Color.Black;
            this.btnDash.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDash.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDash.Iconimage")));
            this.btnDash.Iconimage_right = null;
            this.btnDash.Iconimage_right_Selected = null;
            this.btnDash.Iconimage_Selected = null;
            this.btnDash.IconMarginLeft = 0;
            this.btnDash.IconMarginRight = 0;
            this.btnDash.IconRightVisible = true;
            this.btnDash.IconRightZoom = 0D;
            this.btnDash.IconVisible = true;
            this.btnDash.IconZoom = 90D;
            this.btnDash.IsTab = true;
            this.btnDash.Location = new System.Drawing.Point(0, 113);
            this.btnDash.Name = "btnDash";
            this.btnDash.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDash.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDash.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDash.selected = true;
            this.btnDash.Size = new System.Drawing.Size(265, 48);
            this.btnDash.TabIndex = 2;
            this.btnDash.Text = "Dashboard";
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Textcolor = System.Drawing.Color.White;
            this.btnDash.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Vision Application";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(960, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalc.BorderRadius = 0;
            this.btnCalc.ButtonText = "Calculator";
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalc.Iconimage")));
            this.btnCalc.Iconimage_right = null;
            this.btnCalc.Iconimage_right_Selected = null;
            this.btnCalc.Iconimage_Selected = null;
            this.btnCalc.IconMarginLeft = 0;
            this.btnCalc.IconMarginRight = 0;
            this.btnCalc.IconRightVisible = true;
            this.btnCalc.IconRightZoom = 0D;
            this.btnCalc.IconVisible = true;
            this.btnCalc.IconZoom = 90D;
            this.btnCalc.IsTab = true;
            this.btnCalc.Location = new System.Drawing.Point(0, 167);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCalc.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCalc.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCalc.selected = false;
            this.btnCalc.Size = new System.Drawing.Size(265, 48);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculator";
            this.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalc.Textcolor = System.Drawing.Color.White;
            this.btnCalc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTemp.BackColor = System.Drawing.Color.Transparent;
            this.btnTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemp.BorderRadius = 0;
            this.btnTemp.ButtonText = "Temp Convertor";
            this.btnTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemp.DisabledColor = System.Drawing.Color.Gray;
            this.btnTemp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTemp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTemp.Iconimage")));
            this.btnTemp.Iconimage_right = null;
            this.btnTemp.Iconimage_right_Selected = null;
            this.btnTemp.Iconimage_Selected = null;
            this.btnTemp.IconMarginLeft = 0;
            this.btnTemp.IconMarginRight = 0;
            this.btnTemp.IconRightVisible = true;
            this.btnTemp.IconRightZoom = 0D;
            this.btnTemp.IconVisible = true;
            this.btnTemp.IconZoom = 90D;
            this.btnTemp.IsTab = true;
            this.btnTemp.Location = new System.Drawing.Point(0, 221);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTemp.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnTemp.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTemp.selected = false;
            this.btnTemp.Size = new System.Drawing.Size(265, 48);
            this.btnTemp.TabIndex = 4;
            this.btnTemp.Text = "Temp Convertor";
            this.btnTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemp.Textcolor = System.Drawing.Color.White;
            this.btnTemp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // dashPanel
            // 
            this.dashPanel.Controls.Add(this.lblDashTitle);
            this.dashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashPanel.Location = new System.Drawing.Point(265, 39);
            this.dashPanel.Name = "dashPanel";
            this.dashPanel.Size = new System.Drawing.Size(731, 553);
            this.dashPanel.TabIndex = 2;
            // 
            // lblDashTitle
            // 
            this.lblDashTitle.AutoSize = true;
            this.lblDashTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDashTitle.Location = new System.Drawing.Point(35, 32);
            this.lblDashTitle.Name = "lblDashTitle";
            this.lblDashTitle.Size = new System.Drawing.Size(86, 18);
            this.lblDashTitle.TabIndex = 0;
            this.lblDashTitle.Text = "Dashboard";
            // 
            // calcPanel
            // 
            this.calcPanel.Controls.Add(this.txtCalcNum2);
            this.calcPanel.Controls.Add(this.txtCalcNum1);
            this.calcPanel.Controls.Add(this.lbxCalcAnswer);
            this.calcPanel.Controls.Add(this.btnCalcDivide);
            this.calcPanel.Controls.Add(this.btnCalcMultiply);
            this.calcPanel.Controls.Add(this.btnCalcMinus);
            this.calcPanel.Controls.Add(this.btnCalcAdd);
            this.calcPanel.Controls.Add(this.lblCalcTitle);
            this.calcPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcPanel.Location = new System.Drawing.Point(265, 39);
            this.calcPanel.Name = "calcPanel";
            this.calcPanel.Size = new System.Drawing.Size(731, 553);
            this.calcPanel.TabIndex = 3;
            this.calcPanel.Visible = false;
            // 
            // lblCalcTitle
            // 
            this.lblCalcTitle.AutoSize = true;
            this.lblCalcTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCalcTitle.Location = new System.Drawing.Point(35, 32);
            this.lblCalcTitle.Name = "lblCalcTitle";
            this.lblCalcTitle.Size = new System.Drawing.Size(78, 18);
            this.lblCalcTitle.TabIndex = 0;
            this.lblCalcTitle.Text = "Calculator";
            // 
            // tmpPanel
            // 
            this.tmpPanel.Controls.Add(this.lblTmpTitle);
            this.tmpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tmpPanel.Location = new System.Drawing.Point(265, 39);
            this.tmpPanel.Name = "tmpPanel";
            this.tmpPanel.Size = new System.Drawing.Size(731, 553);
            this.tmpPanel.TabIndex = 4;
            this.tmpPanel.Visible = false;
            // 
            // lblTmpTitle
            // 
            this.lblTmpTitle.AutoSize = true;
            this.lblTmpTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmpTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTmpTitle.Location = new System.Drawing.Point(35, 32);
            this.lblTmpTitle.Name = "lblTmpTitle";
            this.lblTmpTitle.Size = new System.Drawing.Size(153, 18);
            this.lblTmpTitle.TabIndex = 0;
            this.lblTmpTitle.Text = "Tempature Converter";
            // 
            // btnCalcAdd
            // 
            this.btnCalcAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcAdd.color = System.Drawing.Color.SeaGreen;
            this.btnCalcAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCalcAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCalcAdd.ForeColor = System.Drawing.Color.White;
            this.btnCalcAdd.Image = null;
            this.btnCalcAdd.ImagePosition = 20;
            this.btnCalcAdd.ImageZoom = 50;
            this.btnCalcAdd.LabelPosition = 70;
            this.btnCalcAdd.LabelText = "+";
            this.btnCalcAdd.Location = new System.Drawing.Point(343, 113);
            this.btnCalcAdd.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnCalcAdd.Name = "btnCalcAdd";
            this.btnCalcAdd.Size = new System.Drawing.Size(126, 129);
            this.btnCalcAdd.TabIndex = 1;
            this.btnCalcAdd.Click += new System.EventHandler(this.btnCalcAdd_Click);
            // 
            // btnCalcMinus
            // 
            this.btnCalcMinus.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcMinus.color = System.Drawing.Color.SeaGreen;
            this.btnCalcMinus.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCalcMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCalcMinus.ForeColor = System.Drawing.Color.White;
            this.btnCalcMinus.Image = null;
            this.btnCalcMinus.ImagePosition = 20;
            this.btnCalcMinus.ImageZoom = 70;
            this.btnCalcMinus.LabelPosition = 70;
            this.btnCalcMinus.LabelText = "-";
            this.btnCalcMinus.Location = new System.Drawing.Point(483, 113);
            this.btnCalcMinus.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcMinus.Name = "btnCalcMinus";
            this.btnCalcMinus.Size = new System.Drawing.Size(128, 129);
            this.btnCalcMinus.TabIndex = 2;
            this.btnCalcMinus.Click += new System.EventHandler(this.btnCalcMinus_Click);
            // 
            // btnCalcMultiply
            // 
            this.btnCalcMultiply.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcMultiply.color = System.Drawing.Color.SeaGreen;
            this.btnCalcMultiply.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCalcMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCalcMultiply.ForeColor = System.Drawing.Color.White;
            this.btnCalcMultiply.Image = null;
            this.btnCalcMultiply.ImagePosition = 20;
            this.btnCalcMultiply.ImageZoom = 50;
            this.btnCalcMultiply.LabelPosition = 70;
            this.btnCalcMultiply.LabelText = "*";
            this.btnCalcMultiply.Location = new System.Drawing.Point(343, 254);
            this.btnCalcMultiply.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcMultiply.Name = "btnCalcMultiply";
            this.btnCalcMultiply.Size = new System.Drawing.Size(128, 129);
            this.btnCalcMultiply.TabIndex = 3;
            this.btnCalcMultiply.Click += new System.EventHandler(this.btnCalcMultiply_Click);
            // 
            // btnCalcDivide
            // 
            this.btnCalcDivide.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcDivide.color = System.Drawing.Color.SeaGreen;
            this.btnCalcDivide.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCalcDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCalcDivide.ForeColor = System.Drawing.Color.White;
            this.btnCalcDivide.Image = null;
            this.btnCalcDivide.ImagePosition = 20;
            this.btnCalcDivide.ImageZoom = 50;
            this.btnCalcDivide.LabelPosition = 70;
            this.btnCalcDivide.LabelText = "/";
            this.btnCalcDivide.Location = new System.Drawing.Point(483, 254);
            this.btnCalcDivide.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcDivide.Name = "btnCalcDivide";
            this.btnCalcDivide.Size = new System.Drawing.Size(128, 129);
            this.btnCalcDivide.TabIndex = 4;
            this.btnCalcDivide.Click += new System.EventHandler(this.btnCalcDivide_Click);
            // 
            // lbxCalcAnswer
            // 
            this.lbxCalcAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbxCalcAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxCalcAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCalcAnswer.ForeColor = System.Drawing.Color.White;
            this.lbxCalcAnswer.FormattingEnabled = true;
            this.lbxCalcAnswer.ItemHeight = 18;
            this.lbxCalcAnswer.Location = new System.Drawing.Point(38, 113);
            this.lbxCalcAnswer.Name = "lbxCalcAnswer";
            this.lbxCalcAnswer.Size = new System.Drawing.Size(150, 252);
            this.lbxCalcAnswer.TabIndex = 5;
            // 
            // txtCalcNum1
            // 
            this.txtCalcNum1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalcNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCalcNum1.ForeColor = System.Drawing.Color.White;
            this.txtCalcNum1.HintForeColor = System.Drawing.Color.White;
            this.txtCalcNum1.HintText = "Number One";
            this.txtCalcNum1.isPassword = false;
            this.txtCalcNum1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtCalcNum1.LineIdleColor = System.Drawing.Color.White;
            this.txtCalcNum1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtCalcNum1.LineThickness = 3;
            this.txtCalcNum1.Location = new System.Drawing.Point(195, 113);
            this.txtCalcNum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalcNum1.Name = "txtCalcNum1";
            this.txtCalcNum1.Size = new System.Drawing.Size(142, 68);
            this.txtCalcNum1.TabIndex = 6;
            this.txtCalcNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCalcNum2
            // 
            this.txtCalcNum2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalcNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCalcNum2.ForeColor = System.Drawing.Color.White;
            this.txtCalcNum2.HintForeColor = System.Drawing.Color.White;
            this.txtCalcNum2.HintText = "Number Two";
            this.txtCalcNum2.isPassword = false;
            this.txtCalcNum2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtCalcNum2.LineIdleColor = System.Drawing.Color.White;
            this.txtCalcNum2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtCalcNum2.LineThickness = 3;
            this.txtCalcNum2.Location = new System.Drawing.Point(195, 189);
            this.txtCalcNum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalcNum2.Name = "txtCalcNum2";
            this.txtCalcNum2.Size = new System.Drawing.Size(142, 70);
            this.txtCalcNum2.TabIndex = 7;
            this.txtCalcNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(996, 592);
            this.Controls.Add(this.calcPanel);
            this.Controls.Add(this.tmpPanel);
            this.Controls.Add(this.dashPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.dashPanel.ResumeLayout(false);
            this.dashPanel.PerformLayout();
            this.calcPanel.ResumeLayout(false);
            this.calcPanel.PerformLayout();
            this.tmpPanel.ResumeLayout(false);
            this.tmpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuFlatButton btnDash;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTemp;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalc;
        private System.Windows.Forms.Panel dashPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDashTitle;
        private System.Windows.Forms.Panel calcPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCalcTitle;
        private System.Windows.Forms.Panel tmpPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTmpTitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCalcNum2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCalcNum1;
        private System.Windows.Forms.ListBox lbxCalcAnswer;
        private Bunifu.Framework.UI.BunifuTileButton btnCalcDivide;
        private Bunifu.Framework.UI.BunifuTileButton btnCalcMultiply;
        private Bunifu.Framework.UI.BunifuTileButton btnCalcMinus;
        private Bunifu.Framework.UI.BunifuTileButton btnCalcAdd;
    }
}

