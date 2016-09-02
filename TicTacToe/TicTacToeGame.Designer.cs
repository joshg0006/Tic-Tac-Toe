namespace TicTacToe
{
    partial class TicTacToeGame
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
            this.pos_1_1 = new System.Windows.Forms.Button();
            this.pos_1_2 = new System.Windows.Forms.Button();
            this.pos_1_3 = new System.Windows.Forms.Button();
            this.pos_2_1 = new System.Windows.Forms.Button();
            this.pos_2_2 = new System.Windows.Forms.Button();
            this.pos_2_3 = new System.Windows.Forms.Button();
            this.pos_3_1 = new System.Windows.Forms.Button();
            this.pos_3_2 = new System.Windows.Forms.Button();
            this.pos_3_3 = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pos_1_1
            // 
            this.pos_1_1.Location = new System.Drawing.Point(0, 0);
            this.pos_1_1.Name = "pos_1_1";
            this.pos_1_1.Size = new System.Drawing.Size(72, 61);
            this.pos_1_1.TabIndex = 0;
            this.pos_1_1.UseVisualStyleBackColor = true;
            this.pos_1_1.Click += new System.EventHandler(this.pos_1_1_Click);
            // 
            // pos_1_2
            // 
            this.pos_1_2.Location = new System.Drawing.Point(78, 0);
            this.pos_1_2.Name = "pos_1_2";
            this.pos_1_2.Size = new System.Drawing.Size(72, 61);
            this.pos_1_2.TabIndex = 1;
            this.pos_1_2.UseVisualStyleBackColor = true;
            this.pos_1_2.Click += new System.EventHandler(this.pos_1_2_Click);
            // 
            // pos_1_3
            // 
            this.pos_1_3.Location = new System.Drawing.Point(156, 0);
            this.pos_1_3.Name = "pos_1_3";
            this.pos_1_3.Size = new System.Drawing.Size(72, 61);
            this.pos_1_3.TabIndex = 2;
            this.pos_1_3.UseVisualStyleBackColor = true;
            this.pos_1_3.Click += new System.EventHandler(this.pos_1_3_Click);
            // 
            // pos_2_1
            // 
            this.pos_2_1.Location = new System.Drawing.Point(0, 67);
            this.pos_2_1.Name = "pos_2_1";
            this.pos_2_1.Size = new System.Drawing.Size(72, 61);
            this.pos_2_1.TabIndex = 3;
            this.pos_2_1.UseVisualStyleBackColor = true;
            this.pos_2_1.Click += new System.EventHandler(this.pos_2_1_Click);
            // 
            // pos_2_2
            // 
            this.pos_2_2.Location = new System.Drawing.Point(78, 67);
            this.pos_2_2.Name = "pos_2_2";
            this.pos_2_2.Size = new System.Drawing.Size(72, 61);
            this.pos_2_2.TabIndex = 4;
            this.pos_2_2.UseVisualStyleBackColor = true;
            this.pos_2_2.Click += new System.EventHandler(this.pos_2_2_Click);
            // 
            // pos_2_3
            // 
            this.pos_2_3.Location = new System.Drawing.Point(156, 67);
            this.pos_2_3.Name = "pos_2_3";
            this.pos_2_3.Size = new System.Drawing.Size(72, 61);
            this.pos_2_3.TabIndex = 5;
            this.pos_2_3.UseVisualStyleBackColor = true;
            this.pos_2_3.Click += new System.EventHandler(this.pos_2_3_Click);
            // 
            // pos_3_1
            // 
            this.pos_3_1.Location = new System.Drawing.Point(0, 134);
            this.pos_3_1.Name = "pos_3_1";
            this.pos_3_1.Size = new System.Drawing.Size(72, 61);
            this.pos_3_1.TabIndex = 6;
            this.pos_3_1.UseVisualStyleBackColor = true;
            this.pos_3_1.Click += new System.EventHandler(this.pos_3_1_Click);
            // 
            // pos_3_2
            // 
            this.pos_3_2.Location = new System.Drawing.Point(78, 134);
            this.pos_3_2.Name = "pos_3_2";
            this.pos_3_2.Size = new System.Drawing.Size(72, 61);
            this.pos_3_2.TabIndex = 7;
            this.pos_3_2.UseVisualStyleBackColor = true;
            this.pos_3_2.Click += new System.EventHandler(this.pos_3_2_Click);
            // 
            // pos_3_3
            // 
            this.pos_3_3.Location = new System.Drawing.Point(156, 134);
            this.pos_3_3.Name = "pos_3_3";
            this.pos_3_3.Size = new System.Drawing.Size(72, 61);
            this.pos_3_3.TabIndex = 8;
            this.pos_3_3.UseVisualStyleBackColor = true;
            this.pos_3_3.Click += new System.EventHandler(this.pos_3_3_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(96, 243);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(7, 13);
            this.lblDisplay.TabIndex = 9;
            this.lblDisplay.Text = "\r\n";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(75, 259);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TicTacToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 291);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.pos_3_3);
            this.Controls.Add(this.pos_3_2);
            this.Controls.Add(this.pos_3_1);
            this.Controls.Add(this.pos_2_3);
            this.Controls.Add(this.pos_2_2);
            this.Controls.Add(this.pos_2_1);
            this.Controls.Add(this.pos_1_3);
            this.Controls.Add(this.pos_1_2);
            this.Controls.Add(this.pos_1_1);
            this.Name = "TicTacToeGame";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pos_1_1;
        private System.Windows.Forms.Button pos_1_2;
        private System.Windows.Forms.Button pos_1_3;
        private System.Windows.Forms.Button pos_2_1;
        private System.Windows.Forms.Button pos_2_2;
        private System.Windows.Forms.Button pos_2_3;
        private System.Windows.Forms.Button pos_3_1;
        private System.Windows.Forms.Button pos_3_2;
        private System.Windows.Forms.Button pos_3_3;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnReset;
    }
}

