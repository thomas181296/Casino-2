namespace WindowsFormsApp1
{
    partial class Coin_Flipper
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
            this.btn_result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(250, 238);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(205, 148);
            this.btn_result.TabIndex = 0;
            this.btn_result.Text = "Click to see the results";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is the game coin flipper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "It will calculate how many times heads and tails was flipped";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "How many times Heads was flipped";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "How many times Tails was flipped";
            // 
            // lblHead
            // 
            this.lblHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHead.Location = new System.Drawing.Point(594, 128);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 23);
            this.lblHead.TabIndex = 7;
            // 
            // lblTail
            // 
            this.lblTail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTail.Location = new System.Drawing.Point(597, 194);
            this.lblTail.Name = "lblTail";
            this.lblTail.Size = new System.Drawing.Size(100, 23);
            this.lblTail.TabIndex = 8;
            // 
            // Coin_Flipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTail);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_result);
            this.Name = "Coin_Flipper";
            this.Load += new System.EventHandler(this.Coin_Flipper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTail;
    }
}