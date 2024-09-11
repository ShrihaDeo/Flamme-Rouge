namespace Flamme_Rouge
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlayer1S = new System.Windows.Forms.Button();
            this.buttonPlayer1R = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonEx = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEC1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonEC2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 162);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonPlayer1S
            // 
            this.buttonPlayer1S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPlayer1S.Location = new System.Drawing.Point(38, 27);
            this.buttonPlayer1S.Name = "buttonPlayer1S";
            this.buttonPlayer1S.Size = new System.Drawing.Size(100, 150);
            this.buttonPlayer1S.TabIndex = 12;
            this.buttonPlayer1S.Text = "Sprinter";
            this.buttonPlayer1S.UseVisualStyleBackColor = false;
            this.buttonPlayer1S.Click += new System.EventHandler(this.buttonPlayer1S_Click);
            // 
            // buttonPlayer1R
            // 
            this.buttonPlayer1R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPlayer1R.Location = new System.Drawing.Point(144, 27);
            this.buttonPlayer1R.Name = "buttonPlayer1R";
            this.buttonPlayer1R.Size = new System.Drawing.Size(100, 150);
            this.buttonPlayer1R.TabIndex = 13;
            this.buttonPlayer1R.Text = "Routeur";
            this.buttonPlayer1R.UseVisualStyleBackColor = false;
            this.buttonPlayer1R.Click += new System.EventHandler(this.buttonPlayer1R_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(271, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 124);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(365, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 124);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(454, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 124);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(543, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 124);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(510, 470);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(105, 32);
            this.buttonSaveFile.TabIndex = 20;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(621, 470);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(105, 32);
            this.buttonEx.TabIndex = 21;
            this.buttonEx.Text = "Exhaustion";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            // 
            // buttonEC1
            // 
            this.buttonEC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEC1.Location = new System.Drawing.Point(37, 401);
            this.buttonEC1.Name = "buttonEC1";
            this.buttonEC1.Size = new System.Drawing.Size(101, 147);
            this.buttonEC1.TabIndex = 22;
            this.buttonEC1.Text = "Exhaustion Card Player 1";
            this.buttonEC1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(894, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 124);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button7.Location = new System.Drawing.Point(1161, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 124);
            this.button7.TabIndex = 24;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button8.Location = new System.Drawing.Point(1072, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 124);
            this.button8.TabIndex = 25;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(983, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 124);
            this.button9.TabIndex = 26;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MediumPurple;
            this.button10.Location = new System.Drawing.Point(681, 27);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 150);
            this.button10.TabIndex = 27;
            this.button10.Text = "Sprinter";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(787, 27);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 150);
            this.button11.TabIndex = 28;
            this.button11.Text = "Routeur";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonEC2
            // 
            this.buttonEC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEC2.Location = new System.Drawing.Point(1039, 401);
            this.buttonEC2.Name = "buttonEC2";
            this.buttonEC2.Size = new System.Drawing.Size(101, 147);
            this.buttonEC2.TabIndex = 29;
            this.buttonEC2.Text = "Exhaustion Card Player 2";
            this.buttonEC2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Player 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEC2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonEC1);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlayer1R);
            this.Controls.Add(this.buttonPlayer1S);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPlayer1S;
        private System.Windows.Forms.Button buttonPlayer1R;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonEC1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonEC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

