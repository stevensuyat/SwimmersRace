namespace SwimmersRace
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
            this.pbWater = new System.Windows.Forms.PictureBox();
            this.pbDuck = new System.Windows.Forms.PictureBox();
            this.pbFish = new System.Windows.Forms.PictureBox();
            this.pbChild = new System.Windows.Forms.PictureBox();
            this.pbMan = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbZeph = new System.Windows.Forms.RadioButton();
            this.rbSarah = new System.Windows.Forms.RadioButton();
            this.rbMae = new System.Windows.Forms.RadioButton();
            this.rbFey = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDuck = new System.Windows.Forms.RadioButton();
            this.rbFish = new System.Windows.Forms.RadioButton();
            this.rbChild = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.udBets = new System.Windows.Forms.NumericUpDown();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.lbxBets = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFeyCash = new System.Windows.Forms.Label();
            this.lblMaeCash = new System.Windows.Forms.Label();
            this.lblSarahCash = new System.Windows.Forms.Label();
            this.lblZephCash = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDuck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBets)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbWater
            // 
            this.pbWater.BackgroundImage = global::SwimmersRace.Resource1.water;
            this.pbWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWater.Location = new System.Drawing.Point(-1, -138);
            this.pbWater.Name = "pbWater";
            this.pbWater.Size = new System.Drawing.Size(902, 475);
            this.pbWater.TabIndex = 0;
            this.pbWater.TabStop = false;
            // 
            // pbDuck
            // 
            this.pbDuck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDuck.Location = new System.Drawing.Point(12, 12);
            this.pbDuck.Name = "pbDuck";
            this.pbDuck.Size = new System.Drawing.Size(84, 77);
            this.pbDuck.TabIndex = 1;
            this.pbDuck.TabStop = false;
            // 
            // pbFish
            // 
            this.pbFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFish.Location = new System.Drawing.Point(12, 93);
            this.pbFish.Name = "pbFish";
            this.pbFish.Size = new System.Drawing.Size(84, 77);
            this.pbFish.TabIndex = 2;
            this.pbFish.TabStop = false;
            // 
            // pbChild
            // 
            this.pbChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChild.Location = new System.Drawing.Point(12, 176);
            this.pbChild.Name = "pbChild";
            this.pbChild.Size = new System.Drawing.Size(84, 77);
            this.pbChild.TabIndex = 3;
            this.pbChild.TabStop = false;
            // 
            // pbMan
            // 
            this.pbMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMan.Location = new System.Drawing.Point(12, 260);
            this.pbMan.Name = "pbMan";
            this.pbMan.Size = new System.Drawing.Size(84, 77);
            this.pbMan.TabIndex = 4;
            this.pbMan.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 353);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 47);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Race";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 399);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Player";
            // 
            // rbZeph
            // 
            this.rbZeph.AutoSize = true;
            this.rbZeph.Location = new System.Drawing.Point(88, 16);
            this.rbZeph.Name = "rbZeph";
            this.rbZeph.Size = new System.Drawing.Size(50, 17);
            this.rbZeph.TabIndex = 8;
            this.rbZeph.TabStop = true;
            this.rbZeph.Text = "Zeph";
            this.rbZeph.UseVisualStyleBackColor = true;
            this.rbZeph.CheckedChanged += new System.EventHandler(this.PunterRb_CheckedChanged);
            // 
            // rbSarah
            // 
            this.rbSarah.AutoSize = true;
            this.rbSarah.Location = new System.Drawing.Point(88, 37);
            this.rbSarah.Name = "rbSarah";
            this.rbSarah.Size = new System.Drawing.Size(53, 17);
            this.rbSarah.TabIndex = 9;
            this.rbSarah.TabStop = true;
            this.rbSarah.Text = "Sarah";
            this.rbSarah.UseVisualStyleBackColor = true;
            this.rbSarah.CheckedChanged += new System.EventHandler(this.PunterRb_CheckedChanged);
            // 
            // rbMae
            // 
            this.rbMae.AutoSize = true;
            this.rbMae.Location = new System.Drawing.Point(88, 60);
            this.rbMae.Name = "rbMae";
            this.rbMae.Size = new System.Drawing.Size(46, 17);
            this.rbMae.TabIndex = 10;
            this.rbMae.TabStop = true;
            this.rbMae.Text = "Mae";
            this.rbMae.UseVisualStyleBackColor = true;
            this.rbMae.CheckedChanged += new System.EventHandler(this.PunterRb_CheckedChanged);
            // 
            // rbFey
            // 
            this.rbFey.AutoSize = true;
            this.rbFey.Location = new System.Drawing.Point(88, 83);
            this.rbFey.Name = "rbFey";
            this.rbFey.Size = new System.Drawing.Size(42, 17);
            this.rbFey.TabIndex = 11;
            this.rbFey.TabStop = true;
            this.rbFey.Text = "Fey";
            this.rbFey.UseVisualStyleBackColor = true;
            this.rbFey.CheckedChanged += new System.EventHandler(this.PunterRb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Swimmer";
            // 
            // rbDuck
            // 
            this.rbDuck.AutoSize = true;
            this.rbDuck.Location = new System.Drawing.Point(117, 16);
            this.rbDuck.Name = "rbDuck";
            this.rbDuck.Size = new System.Drawing.Size(51, 17);
            this.rbDuck.TabIndex = 13;
            this.rbDuck.TabStop = true;
            this.rbDuck.Text = "Duck";
            this.rbDuck.UseVisualStyleBackColor = true;
            this.rbDuck.CheckedChanged += new System.EventHandler(this.SwimmerRb_CheckedChanged);
            // 
            // rbFish
            // 
            this.rbFish.AutoSize = true;
            this.rbFish.Location = new System.Drawing.Point(117, 39);
            this.rbFish.Name = "rbFish";
            this.rbFish.Size = new System.Drawing.Size(44, 17);
            this.rbFish.TabIndex = 14;
            this.rbFish.TabStop = true;
            this.rbFish.Text = "Fish";
            this.rbFish.UseVisualStyleBackColor = true;
            this.rbFish.CheckedChanged += new System.EventHandler(this.SwimmerRb_CheckedChanged);
            // 
            // rbChild
            // 
            this.rbChild.AutoSize = true;
            this.rbChild.Location = new System.Drawing.Point(117, 62);
            this.rbChild.Name = "rbChild";
            this.rbChild.Size = new System.Drawing.Size(48, 17);
            this.rbChild.TabIndex = 15;
            this.rbChild.TabStop = true;
            this.rbChild.Text = "Child";
            this.rbChild.UseVisualStyleBackColor = true;
            this.rbChild.CheckedChanged += new System.EventHandler(this.SwimmerRb_CheckedChanged);
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(117, 85);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 16;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            this.rbMan.CheckedChanged += new System.EventHandler(this.SwimmerRb_CheckedChanged);
            // 
            // udBets
            // 
            this.udBets.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udBets.Location = new System.Drawing.Point(529, 368);
            this.udBets.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udBets.Name = "udBets";
            this.udBets.Size = new System.Drawing.Size(120, 20);
            this.udBets.TabIndex = 17;
            this.udBets.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.Location = new System.Drawing.Point(529, 399);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(120, 39);
            this.btnPlaceBet.TabIndex = 18;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.BtnPlaceBet_Click);
            // 
            // lbxBets
            // 
            this.lbxBets.FormattingEnabled = true;
            this.lbxBets.Location = new System.Drawing.Point(655, 352);
            this.lbxBets.Name = "lbxBets";
            this.lbxBets.Size = new System.Drawing.Size(195, 56);
            this.lbxBets.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFeyCash);
            this.groupBox1.Controls.Add(this.lblMaeCash);
            this.groupBox1.Controls.Add(this.lblSarahCash);
            this.groupBox1.Controls.Add(this.lblZephCash);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbZeph);
            this.groupBox1.Controls.Add(this.rbSarah);
            this.groupBox1.Controls.Add(this.rbMae);
            this.groupBox1.Controls.Add(this.rbFey);
            this.groupBox1.Location = new System.Drawing.Point(151, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 115);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lblFeyCash
            // 
            this.lblFeyCash.AutoSize = true;
            this.lblFeyCash.Location = new System.Drawing.Point(144, 85);
            this.lblFeyCash.Name = "lblFeyCash";
            this.lblFeyCash.Size = new System.Drawing.Size(0, 13);
            this.lblFeyCash.TabIndex = 15;
            // 
            // lblMaeCash
            // 
            this.lblMaeCash.AutoSize = true;
            this.lblMaeCash.Location = new System.Drawing.Point(144, 62);
            this.lblMaeCash.Name = "lblMaeCash";
            this.lblMaeCash.Size = new System.Drawing.Size(0, 13);
            this.lblMaeCash.TabIndex = 14;
            // 
            // lblSarahCash
            // 
            this.lblSarahCash.AutoSize = true;
            this.lblSarahCash.Location = new System.Drawing.Point(144, 39);
            this.lblSarahCash.Name = "lblSarahCash";
            this.lblSarahCash.Size = new System.Drawing.Size(0, 13);
            this.lblSarahCash.TabIndex = 13;
            // 
            // lblZephCash
            // 
            this.lblZephCash.AutoSize = true;
            this.lblZephCash.Location = new System.Drawing.Point(144, 18);
            this.lblZephCash.Name = "lblZephCash";
            this.lblZephCash.Size = new System.Drawing.Size(0, 13);
            this.lblZephCash.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rbDuck);
            this.groupBox2.Controls.Add(this.rbFish);
            this.groupBox2.Controls.Add(this.rbChild);
            this.groupBox2.Controls.Add(this.rbMan);
            this.groupBox2.Location = new System.Drawing.Point(354, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 115);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(652, 411);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(53, 13);
            this.lblWinner.TabIndex = 16;
            this.lblWinner.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 473);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxBets);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.udBets);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbMan);
            this.Controls.Add(this.pbChild);
            this.Controls.Add(this.pbFish);
            this.Controls.Add(this.pbDuck);
            this.Controls.Add(this.pbWater);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDuck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWater;
        private System.Windows.Forms.PictureBox pbDuck;
        private System.Windows.Forms.PictureBox pbFish;
        private System.Windows.Forms.PictureBox pbChild;
        private System.Windows.Forms.PictureBox pbMan;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbZeph;
        private System.Windows.Forms.RadioButton rbSarah;
        private System.Windows.Forms.RadioButton rbMae;
        private System.Windows.Forms.RadioButton rbFey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDuck;
        private System.Windows.Forms.RadioButton rbFish;
        private System.Windows.Forms.RadioButton rbChild;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.NumericUpDown udBets;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.ListBox lbxBets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFeyCash;
        private System.Windows.Forms.Label lblMaeCash;
        private System.Windows.Forms.Label lblSarahCash;
        private System.Windows.Forms.Label lblZephCash;
        private System.Windows.Forms.Label lblWinner;
    }
}

