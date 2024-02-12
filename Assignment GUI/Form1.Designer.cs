namespace Assignment_GUI
{
    partial class Bruna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bruna));
            this.tabBoth = new System.Windows.Forms.TabControl();
            this.tapAboutMe = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Usernamee = new System.Windows.Forms.TextBox();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCalculator = new System.Windows.Forms.TabPage();
            this.btnsine = new System.Windows.Forms.Button();
            this.btnsubt = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnroot = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.tbnCorsine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.btnoperation = new System.Windows.Forms.Button();
            this.checkDarkMode = new System.Windows.Forms.CheckBox();
            this.radioScientific = new System.Windows.Forms.RadioButton();
            this.radioStand = new System.Windows.Forms.RadioButton();
            this.btnplusless = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn07 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.tabBoth.SuspendLayout();
            this.tapAboutMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBoth
            // 
            this.tabBoth.Controls.Add(this.tapAboutMe);
            this.tabBoth.Controls.Add(this.tabCalculator);
            this.tabBoth.Location = new System.Drawing.Point(1, 0);
            this.tabBoth.Name = "tabBoth";
            this.tabBoth.SelectedIndex = 0;
            this.tabBoth.Size = new System.Drawing.Size(412, 448);
            this.tabBoth.TabIndex = 0;
            // 
            // tapAboutMe
            // 
            this.tapAboutMe.Controls.Add(this.label1);
            this.tapAboutMe.Controls.Add(this.Usernamee);
            this.tapAboutMe.Controls.Add(this.btnAboutMe);
            this.tapAboutMe.Controls.Add(this.pictureBox1);
            this.tapAboutMe.Location = new System.Drawing.Point(4, 29);
            this.tapAboutMe.Name = "tapAboutMe";
            this.tapAboutMe.Padding = new System.Windows.Forms.Padding(3);
            this.tapAboutMe.Size = new System.Drawing.Size(404, 415);
            this.tapAboutMe.TabIndex = 0;
            this.tapAboutMe.Text = "About Me";
            this.tapAboutMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type your name:";
            // 
            // Usernamee
            // 
            this.Usernamee.Location = new System.Drawing.Point(264, 97);
            this.Usernamee.Name = "Usernamee";
            this.Usernamee.Size = new System.Drawing.Size(125, 27);
            this.Usernamee.TabIndex = 2;
            this.Usernamee.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAboutMe.Location = new System.Drawing.Point(272, 178);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(124, 108);
            this.btnAboutMe.TabIndex = 1;
            this.btnAboutMe.Text = "Curious? Click Here";
            this.btnAboutMe.UseVisualStyleBackColor = true;
            this.btnAboutMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment_GUI.Properties.Resources.WhatsApp_Image_2023_08_03_at_12_15_51;
            this.pictureBox1.Location = new System.Drawing.Point(18, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 255);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabCalculator
            // 
            this.tabCalculator.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCalculator.Controls.Add(this.btnsine);
            this.tabCalculator.Controls.Add(this.btnsubt);
            this.tabCalculator.Controls.Add(this.btnPower);
            this.tabCalculator.Controls.Add(this.btndiv);
            this.tabCalculator.Controls.Add(this.btnroot);
            this.tabCalculator.Controls.Add(this.btnmult);
            this.tabCalculator.Controls.Add(this.btnFactorial);
            this.tabCalculator.Controls.Add(this.btnsum);
            this.tabCalculator.Controls.Add(this.btnPi);
            this.tabCalculator.Controls.Add(this.tbnCorsine);
            this.tabCalculator.Controls.Add(this.clear);
            this.tabCalculator.Controls.Add(this.btnoperation);
            this.tabCalculator.Controls.Add(this.checkDarkMode);
            this.tabCalculator.Controls.Add(this.radioScientific);
            this.tabCalculator.Controls.Add(this.radioStand);
            this.tabCalculator.Controls.Add(this.btnplusless);
            this.tabCalculator.Controls.Add(this.btndot);
            this.tabCalculator.Controls.Add(this.btn0);
            this.tabCalculator.Controls.Add(this.btn09);
            this.tabCalculator.Controls.Add(this.btn08);
            this.tabCalculator.Controls.Add(this.btn07);
            this.tabCalculator.Controls.Add(this.btn06);
            this.tabCalculator.Controls.Add(this.btn05);
            this.tabCalculator.Controls.Add(this.btn04);
            this.tabCalculator.Controls.Add(this.btn03);
            this.tabCalculator.Controls.Add(this.btn02);
            this.tabCalculator.Controls.Add(this.btn01);
            this.tabCalculator.Controls.Add(this.result);
            this.tabCalculator.Location = new System.Drawing.Point(4, 29);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(404, 415);
            this.tabCalculator.TabIndex = 1;
            this.tabCalculator.Text = "Calculator";
            // 
            // btnsine
            // 
            this.btnsine.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsine.Location = new System.Drawing.Point(238, 170);
            this.btnsine.Name = "btnsine";
            this.btnsine.Size = new System.Drawing.Size(67, 64);
            this.btnsine.TabIndex = 30;
            this.btnsine.Text = "Sine";
            this.btnsine.UseVisualStyleBackColor = false;
            this.btnsine.Click += new System.EventHandler(this.btnroot_Click);
            // 
            // btnsubt
            // 
            this.btnsubt.BackColor = System.Drawing.Color.Orange;
            this.btnsubt.Location = new System.Drawing.Point(316, 290);
            this.btnsubt.Name = "btnsubt";
            this.btnsubt.Size = new System.Drawing.Size(72, 29);
            this.btnsubt.TabIndex = 29;
            this.btnsubt.Text = "-";
            this.btnsubt.UseVisualStyleBackColor = false;
            this.btnsubt.Click += new System.EventHandler(this.btnsubt_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.Orange;
            this.btnPower.Location = new System.Drawing.Point(238, 290);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(72, 29);
            this.btnPower.TabIndex = 28;
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Orange;
            this.btndiv.Location = new System.Drawing.Point(316, 360);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(72, 29);
            this.btndiv.TabIndex = 27;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnroot
            // 
            this.btnroot.BackColor = System.Drawing.Color.Orange;
            this.btnroot.Location = new System.Drawing.Point(238, 360);
            this.btnroot.Name = "btnroot";
            this.btnroot.Size = new System.Drawing.Size(72, 29);
            this.btnroot.TabIndex = 26;
            this.btnroot.Text = "√  ";
            this.btnroot.UseVisualStyleBackColor = false;
            this.btnroot.Click += new System.EventHandler(this.btnsine_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.Orange;
            this.btnmult.Location = new System.Drawing.Point(316, 325);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(72, 29);
            this.btnmult.TabIndex = 25;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.Orange;
            this.btnFactorial.Location = new System.Drawing.Point(238, 325);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(72, 29);
            this.btnFactorial.TabIndex = 24;
            this.btnFactorial.Text = "X!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.Color.Orange;
            this.btnsum.Location = new System.Drawing.Point(316, 255);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(72, 29);
            this.btnsum.TabIndex = 21;
            this.btnsum.Text = "+";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.Orange;
            this.btnPi.Location = new System.Drawing.Point(238, 255);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(72, 29);
            this.btnPi.TabIndex = 20;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // tbnCorsine
            // 
            this.tbnCorsine.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbnCorsine.Location = new System.Drawing.Point(316, 170);
            this.tbnCorsine.Name = "tbnCorsine";
            this.tbnCorsine.Size = new System.Drawing.Size(67, 64);
            this.tbnCorsine.TabIndex = 19;
            this.tbnCorsine.Text = "Corsine";
            this.tbnCorsine.UseVisualStyleBackColor = false;
            this.tbnCorsine.Click += new System.EventHandler(this.tbnLog_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.LightGray;
            this.clear.Location = new System.Drawing.Point(245, 130);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(138, 34);
            this.clear.TabIndex = 17;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btnoperation
            // 
            this.btnoperation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnoperation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnoperation.Location = new System.Drawing.Point(245, 85);
            this.btnoperation.Name = "btnoperation";
            this.btnoperation.Size = new System.Drawing.Size(138, 34);
            this.btnoperation.TabIndex = 16;
            this.btnoperation.Text = "=";
            this.btnoperation.UseVisualStyleBackColor = false;
            this.btnoperation.Click += new System.EventHandler(this.result_Click);
            // 
            // checkDarkMode
            // 
            this.checkDarkMode.AutoSize = true;
            this.checkDarkMode.Location = new System.Drawing.Point(19, 391);
            this.checkDarkMode.Name = "checkDarkMode";
            this.checkDarkMode.Size = new System.Drawing.Size(105, 24);
            this.checkDarkMode.TabIndex = 15;
            this.checkDarkMode.Text = "Dark Mode";
            this.checkDarkMode.UseVisualStyleBackColor = true;
            this.checkDarkMode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioScientific
            // 
            this.radioScientific.AutoSize = true;
            this.radioScientific.Checked = true;
            this.radioScientific.Location = new System.Drawing.Point(126, 85);
            this.radioScientific.Name = "radioScientific";
            this.radioScientific.Size = new System.Drawing.Size(90, 24);
            this.radioScientific.TabIndex = 14;
            this.radioScientific.TabStop = true;
            this.radioScientific.Text = "Scientific";
            this.radioScientific.UseVisualStyleBackColor = true;
            this.radioScientific.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioStand
            // 
            this.radioStand.AutoSize = true;
            this.radioStand.Location = new System.Drawing.Point(30, 85);
            this.radioStand.Name = "radioStand";
            this.radioStand.Size = new System.Drawing.Size(90, 24);
            this.radioStand.TabIndex = 13;
            this.radioStand.Text = "Standard";
            this.radioStand.UseVisualStyleBackColor = true;
            this.radioStand.CheckedChanged += new System.EventHandler(this.radioStand_CheckedChanged);
            // 
            // btnplusless
            // 
            this.btnplusless.BackColor = System.Drawing.Color.Black;
            this.btnplusless.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnplusless.Location = new System.Drawing.Point(165, 325);
            this.btnplusless.Name = "btnplusless";
            this.btnplusless.Size = new System.Drawing.Size(67, 64);
            this.btnplusless.TabIndex = 12;
            this.btnplusless.Text = "+-";
            this.btnplusless.UseVisualStyleBackColor = false;
            this.btnplusless.Click += new System.EventHandler(this.btnplusless_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Black;
            this.btndot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndot.Location = new System.Drawing.Point(92, 325);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(67, 64);
            this.btndot.TabIndex = 11;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Location = new System.Drawing.Point(19, 325);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 64);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn09
            // 
            this.btn09.BackColor = System.Drawing.Color.Black;
            this.btn09.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn09.Location = new System.Drawing.Point(165, 255);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(67, 64);
            this.btn09.TabIndex = 9;
            this.btn09.Text = "09";
            this.btn09.UseVisualStyleBackColor = false;
            this.btn09.Click += new System.EventHandler(this.btn09_Click);
            // 
            // btn08
            // 
            this.btn08.BackColor = System.Drawing.Color.Black;
            this.btn08.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn08.Location = new System.Drawing.Point(92, 255);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(67, 64);
            this.btn08.TabIndex = 8;
            this.btn08.Text = "08";
            this.btn08.UseVisualStyleBackColor = false;
            this.btn08.Click += new System.EventHandler(this.btn08_Click);
            // 
            // btn07
            // 
            this.btn07.BackColor = System.Drawing.Color.Black;
            this.btn07.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn07.Location = new System.Drawing.Point(19, 255);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(67, 64);
            this.btn07.TabIndex = 7;
            this.btn07.Text = "07";
            this.btn07.UseVisualStyleBackColor = false;
            this.btn07.Click += new System.EventHandler(this.btn07_Click);
            // 
            // btn06
            // 
            this.btn06.BackColor = System.Drawing.Color.Black;
            this.btn06.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn06.Location = new System.Drawing.Point(165, 185);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(67, 64);
            this.btn06.TabIndex = 6;
            this.btn06.Text = "06";
            this.btn06.UseVisualStyleBackColor = false;
            this.btn06.Click += new System.EventHandler(this.btn06_Click);
            // 
            // btn05
            // 
            this.btn05.BackColor = System.Drawing.Color.Black;
            this.btn05.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn05.Location = new System.Drawing.Point(92, 185);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(67, 64);
            this.btn05.TabIndex = 5;
            this.btn05.Text = "05";
            this.btn05.UseVisualStyleBackColor = false;
            this.btn05.Click += new System.EventHandler(this.btn05_Click);
            // 
            // btn04
            // 
            this.btn04.BackColor = System.Drawing.Color.Black;
            this.btn04.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn04.Location = new System.Drawing.Point(19, 185);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(67, 64);
            this.btn04.TabIndex = 4;
            this.btn04.Text = "04";
            this.btn04.UseVisualStyleBackColor = false;
            this.btn04.Click += new System.EventHandler(this.btn04_Click);
            // 
            // btn03
            // 
            this.btn03.BackColor = System.Drawing.Color.Black;
            this.btn03.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn03.Location = new System.Drawing.Point(165, 115);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(67, 64);
            this.btn03.TabIndex = 3;
            this.btn03.Text = "03";
            this.btn03.UseVisualStyleBackColor = false;
            this.btn03.Click += new System.EventHandler(this.btn03_Click);
            // 
            // btn02
            // 
            this.btn02.BackColor = System.Drawing.Color.Black;
            this.btn02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn02.Location = new System.Drawing.Point(92, 115);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(67, 64);
            this.btn02.TabIndex = 2;
            this.btn02.Text = "02";
            this.btn02.UseVisualStyleBackColor = false;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn01
            // 
            this.btn01.BackColor = System.Drawing.Color.Black;
            this.btn01.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn01.Location = new System.Drawing.Point(19, 115);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(67, 64);
            this.btn01.TabIndex = 1;
            this.btn01.Text = "01";
            this.btn01.UseVisualStyleBackColor = false;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Wheat;
            this.result.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(19, 11);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(364, 56);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Bruna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.tabBoth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bruna";
            this.Text = "Bruna Calculator";
            this.Load += new System.EventHandler(this.Bruna_Load);
            this.tabBoth.ResumeLayout(false);
            this.tapAboutMe.ResumeLayout(false);
            this.tapAboutMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabBoth;
        private TabPage tapAboutMe;
        private TabPage tabCalculator;
        private RadioButton radioScientific;
        private RadioButton radioStand;
        private Button btnplusless;
        private Button btndot;
        private Button btn0;
        private Button btn09;
        private Button btn08;
        private Button btn07;
        private Button btn06;
        private Button btn05;
        private Button btn04;
        private Button btn03;
        private Button btn02;
        private Button btn01;
        private TextBox result;
        private CheckBox checkDarkMode;
        private Button btnsine;
        private Button btnsubt;
        private Button btnPower;
        private Button btndiv;
        private Button btnroot;
        private Button btnmult;
        private Button btnFactorial;
        private Button btnsum;
        private Button btnPi;
        private Button tbnCorsine;
        private Button clear;
        private Button btnoperation;
        private Button btnAboutMe;
        private PictureBox pictureBox1;
        private TextBox Usernamee;
        private Label label1;
    }
}