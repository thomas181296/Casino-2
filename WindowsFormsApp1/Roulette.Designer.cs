namespace WindowsFormsApp1
{
    partial class Roulette
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Answer = new System.Windows.Forms.Button();
            this.txtuserNumber = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Location = new System.Drawing.Point(688, 536);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(158, 55);
            this.lblNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(361, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the game Roulette";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(361, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "You will pick a number 1-36";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(508, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(278, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Winings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(361, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "You got number right: 10,000 dollars";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(564, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "The wining number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(564, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Enter your number:";
            // 
            // btn_Answer
            // 
            this.btn_Answer.BackColor = System.Drawing.Color.Orange;
            this.btn_Answer.Location = new System.Drawing.Point(266, 466);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(196, 125);
            this.btn_Answer.TabIndex = 14;
            this.btn_Answer.Text = "Click here to start the game";
            this.btn_Answer.UseVisualStyleBackColor = false;
            this.btn_Answer.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // txtuserNumber
            // 
            this.txtuserNumber.Location = new System.Drawing.Point(688, 473);
            this.txtuserNumber.Name = "txtuserNumber";
            this.txtuserNumber.Size = new System.Drawing.Size(100, 20);
            this.txtuserNumber.TabIndex = 16;
            // 
            // lblMoney
            // 
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoney.Location = new System.Drawing.Point(688, 301);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(158, 78);
            this.lblMoney.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(504, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "The amount of money you won:";
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download__1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 659);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtuserNumber);
            this.Controls.Add(this.btn_Answer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumber);
            this.Name = "Roulette";
            this.Text = "Roulette";
            this.Load += new System.EventHandler(this.Roulette_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Answer;
        private System.Windows.Forms.TextBox txtuserNumber;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label11;
    }
}