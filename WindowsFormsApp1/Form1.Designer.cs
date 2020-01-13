namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CoinFlip = new System.Windows.Forms.Button();
            this.btn_Roulette = new System.Windows.Forms.Button();
            this.btn_SlotMachine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(366, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Casino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(336, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pick from three different games to play";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(88, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coin Flipper";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(403, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Roulette";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(697, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Slot Machine";
            // 
            // btn_CoinFlip
            // 
            this.btn_CoinFlip.BackColor = System.Drawing.Color.Orange;
            this.btn_CoinFlip.Location = new System.Drawing.Point(56, 414);
            this.btn_CoinFlip.Name = "btn_CoinFlip";
            this.btn_CoinFlip.Size = new System.Drawing.Size(133, 134);
            this.btn_CoinFlip.TabIndex = 6;
            this.btn_CoinFlip.Text = "Coin Flipper";
            this.btn_CoinFlip.UseVisualStyleBackColor = false;
            this.btn_CoinFlip.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Roulette
            // 
            this.btn_Roulette.BackColor = System.Drawing.Color.Orange;
            this.btn_Roulette.Location = new System.Drawing.Point(369, 414);
            this.btn_Roulette.Name = "btn_Roulette";
            this.btn_Roulette.Size = new System.Drawing.Size(114, 134);
            this.btn_Roulette.TabIndex = 7;
            this.btn_Roulette.Text = "Roulette";
            this.btn_Roulette.UseVisualStyleBackColor = false;
            this.btn_Roulette.Click += new System.EventHandler(this.btn_Roulette_Click);
            // 
            // btn_SlotMachine
            // 
            this.btn_SlotMachine.BackColor = System.Drawing.Color.Orange;
            this.btn_SlotMachine.Location = new System.Drawing.Point(665, 414);
            this.btn_SlotMachine.Name = "btn_SlotMachine";
            this.btn_SlotMachine.Size = new System.Drawing.Size(133, 134);
            this.btn_SlotMachine.TabIndex = 8;
            this.btn_SlotMachine.Text = "Slot Machine";
            this.btn_SlotMachine.UseVisualStyleBackColor = false;
            this.btn_SlotMachine.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(937, 661);
            this.Controls.Add(this.btn_SlotMachine);
            this.Controls.Add(this.btn_Roulette);
            this.Controls.Add(this.btn_CoinFlip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CoinFlip;
        private System.Windows.Forms.Button btn_Roulette;
        private System.Windows.Forms.Button btn_SlotMachine;
    }
}

