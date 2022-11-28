namespace Lab6._8._2
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
            this.ticTacToe2 = new TicTacToe.TicTacToe();
            this.button1 = new System.Windows.Forms.Button();
            this.ticTacToe3 = new TicTacToe.TicTacToe();
            this.ticTacToe4 = new TicTacToe.TicTacToe();
            this.SuspendLayout();
            // 
            // ticTacToe2
            // 
            this.ticTacToe2.Location = new System.Drawing.Point(139, 35);
            this.ticTacToe2.Name = "ticTacToe2";
            this.ticTacToe2.Size = new System.Drawing.Size(405, 376);
            this.ticTacToe2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ticTacToe3
            // 
            this.ticTacToe3.Location = new System.Drawing.Point(597, 12);
            this.ticTacToe3.Name = "ticTacToe3";
            this.ticTacToe3.Size = new System.Drawing.Size(196, 208);
            this.ticTacToe3.TabIndex = 2;
            // 
            // ticTacToe4
            // 
            this.ticTacToe4.Location = new System.Drawing.Point(537, 174);
            this.ticTacToe4.Name = "ticTacToe4";
            this.ticTacToe4.Size = new System.Drawing.Size(300, 300);
            this.ticTacToe4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 486);
            this.Controls.Add(this.ticTacToe4);
            this.Controls.Add(this.ticTacToe3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ticTacToe2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TicTacToe.TicTacToe ticTacToe1;
        private TicTacToe.TicTacToe ticTacToe2;
        private System.Windows.Forms.Button button1;
        private TicTacToe.TicTacToe ticTacToe3;
        private TicTacToe.TicTacToe ticTacToe4;
    }
}

