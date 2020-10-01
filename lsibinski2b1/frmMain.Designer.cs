namespace lsibinski2b1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.txtUSDEuro = new System.Windows.Forms.TextBox();
            this.txtRateEuro = new System.Windows.Forms.TextBox();
            this.txtAmountEuro = new System.Windows.Forms.TextBox();
            this.txtUSDCostaRican = new System.Windows.Forms.TextBox();
            this.txtRateCostaRican = new System.Windows.Forms.TextBox();
            this.txtAmountCostaRican = new System.Windows.Forms.TextBox();
            this.txtUSDBhutanese = new System.Windows.Forms.TextBox();
            this.txtRateBhutanese = new System.Windows.Forms.TextBox();
            this.txtAmountBhutanese = new System.Windows.Forms.TextBox();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.txtAmountAustralia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(364, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 23);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(215, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(659, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "=";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(689, 190);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(142, 20);
            this.txtTotalUSD.TabIndex = 52;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDEuro
            // 
            this.txtUSDEuro.Location = new System.Drawing.Point(511, 190);
            this.txtUSDEuro.Name = "txtUSDEuro";
            this.txtUSDEuro.ReadOnly = true;
            this.txtUSDEuro.Size = new System.Drawing.Size(142, 20);
            this.txtUSDEuro.TabIndex = 50;
            this.txtUSDEuro.TabStop = false;
            this.txtUSDEuro.Text = "0.00";
            this.txtUSDEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateEuro
            // 
            this.txtRateEuro.Location = new System.Drawing.Point(511, 164);
            this.txtRateEuro.Name = "txtRateEuro";
            this.txtRateEuro.Size = new System.Drawing.Size(142, 20);
            this.txtRateEuro.TabIndex = 38;
            this.txtRateEuro.Text = "1.19135";
            this.txtRateEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateEuro.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountEuro
            // 
            this.txtAmountEuro.Location = new System.Drawing.Point(511, 138);
            this.txtAmountEuro.Name = "txtAmountEuro";
            this.txtAmountEuro.Size = new System.Drawing.Size(142, 20);
            this.txtAmountEuro.TabIndex = 29;
            this.txtAmountEuro.Text = "0.00";
            this.txtAmountEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountEuro.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDCostaRican
            // 
            this.txtUSDCostaRican.Location = new System.Drawing.Point(363, 190);
            this.txtUSDCostaRican.Name = "txtUSDCostaRican";
            this.txtUSDCostaRican.ReadOnly = true;
            this.txtUSDCostaRican.Size = new System.Drawing.Size(142, 20);
            this.txtUSDCostaRican.TabIndex = 49;
            this.txtUSDCostaRican.TabStop = false;
            this.txtUSDCostaRican.Text = "0.00";
            this.txtUSDCostaRican.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateCostaRican
            // 
            this.txtRateCostaRican.Location = new System.Drawing.Point(363, 164);
            this.txtRateCostaRican.Name = "txtRateCostaRican";
            this.txtRateCostaRican.Size = new System.Drawing.Size(142, 20);
            this.txtRateCostaRican.TabIndex = 37;
            this.txtRateCostaRican.Text = "0.00168171";
            this.txtRateCostaRican.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateCostaRican.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountCostaRican
            // 
            this.txtAmountCostaRican.Location = new System.Drawing.Point(363, 138);
            this.txtAmountCostaRican.Name = "txtAmountCostaRican";
            this.txtAmountCostaRican.Size = new System.Drawing.Size(142, 20);
            this.txtAmountCostaRican.TabIndex = 28;
            this.txtAmountCostaRican.Text = "0.00";
            this.txtAmountCostaRican.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountCostaRican.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDBhutanese
            // 
            this.txtUSDBhutanese.Location = new System.Drawing.Point(215, 190);
            this.txtUSDBhutanese.Name = "txtUSDBhutanese";
            this.txtUSDBhutanese.ReadOnly = true;
            this.txtUSDBhutanese.Size = new System.Drawing.Size(142, 20);
            this.txtUSDBhutanese.TabIndex = 48;
            this.txtUSDBhutanese.TabStop = false;
            this.txtUSDBhutanese.Text = "0.00";
            this.txtUSDBhutanese.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateBhutanese
            // 
            this.txtRateBhutanese.Location = new System.Drawing.Point(215, 164);
            this.txtRateBhutanese.Name = "txtRateBhutanese";
            this.txtRateBhutanese.Size = new System.Drawing.Size(142, 20);
            this.txtRateBhutanese.TabIndex = 35;
            this.txtRateBhutanese.Text = "0.0136924";
            this.txtRateBhutanese.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateBhutanese.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountBhutanese
            // 
            this.txtAmountBhutanese.Location = new System.Drawing.Point(215, 138);
            this.txtAmountBhutanese.Name = "txtAmountBhutanese";
            this.txtAmountBhutanese.Size = new System.Drawing.Size(142, 20);
            this.txtAmountBhutanese.TabIndex = 26;
            this.txtAmountBhutanese.Text = "0.00";
            this.txtAmountBhutanese.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBhutanese.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(67, 190);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(142, 20);
            this.txtUSDAustralia.TabIndex = 47;
            this.txtUSDAustralia.TabStop = false;
            this.txtUSDAustralia.Text = "0.00";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(67, 164);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(142, 20);
            this.txtRateAustralia.TabIndex = 33;
            this.txtRateAustralia.Text = "0.737356";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountAustralia
            // 
            this.txtAmountAustralia.Location = new System.Drawing.Point(67, 138);
            this.txtAmountAustralia.Name = "txtAmountAustralia";
            this.txtAmountAustralia.Size = new System.Drawing.Size(142, 20);
            this.txtAmountAustralia.TabIndex = 25;
            this.txtAmountAustralia.Text = "0.00";
            this.txtAmountAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "$US:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "US Dollars";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(689, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(142, 123);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Euro";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(511, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(142, 123);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Costa Rican Colon";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(363, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Bhutanese Ngultrum";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(215, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Australian Dollars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 255);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDEuro);
            this.Controls.Add(this.txtRateEuro);
            this.Controls.Add(this.txtAmountEuro);
            this.Controls.Add(this.txtUSDCostaRican);
            this.Controls.Add(this.txtRateCostaRican);
            this.Controls.Add(this.txtAmountCostaRican);
            this.Controls.Add(this.txtUSDBhutanese);
            this.Controls.Add(this.txtRateBhutanese);
            this.Controls.Add(this.txtAmountBhutanese);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.txtAmountAustralia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.calculate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDEuro;
        private System.Windows.Forms.TextBox txtRateEuro;
        private System.Windows.Forms.TextBox txtAmountEuro;
        private System.Windows.Forms.TextBox txtUSDCostaRican;
        private System.Windows.Forms.TextBox txtRateCostaRican;
        private System.Windows.Forms.TextBox txtAmountCostaRican;
        private System.Windows.Forms.TextBox txtUSDBhutanese;
        private System.Windows.Forms.TextBox txtRateBhutanese;
        private System.Windows.Forms.TextBox txtAmountBhutanese;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.TextBox txtAmountAustralia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

