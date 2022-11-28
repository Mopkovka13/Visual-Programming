namespace Laba4._3
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
            this.Capacity = new System.Windows.Forms.Label();
            this.TBmaxCapacity = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.TBpush = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.TBindex = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnHead = new System.Windows.Forms.Button();
            this.TBresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(12, 40);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(60, 16);
            this.Capacity.TabIndex = 0;
            this.Capacity.Text = "Capacity";
            // 
            // TBmaxCapacity
            // 
            this.TBmaxCapacity.Location = new System.Drawing.Point(83, 37);
            this.TBmaxCapacity.Name = "TBmaxCapacity";
            this.TBmaxCapacity.Size = new System.Drawing.Size(86, 22);
            this.TBmaxCapacity.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(186, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.Create_Click);
            // 
            // TBpush
            // 
            this.TBpush.Location = new System.Drawing.Point(83, 76);
            this.TBpush.Name = "TBpush";
            this.TBpush.Size = new System.Drawing.Size(86, 22);
            this.TBpush.TabIndex = 5;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(186, 76);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(86, 23);
            this.btnPush.TabIndex = 6;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // TBindex
            // 
            this.TBindex.Location = new System.Drawing.Point(83, 125);
            this.TBindex.Name = "TBindex";
            this.TBindex.Size = new System.Drawing.Size(86, 22);
            this.TBindex.TabIndex = 9;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(186, 125);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(86, 23);
            this.btnGet.TabIndex = 11;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnHead
            // 
            this.btnHead.Location = new System.Drawing.Point(186, 173);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(86, 23);
            this.btnHead.TabIndex = 12;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // TBresult
            // 
            this.TBresult.Location = new System.Drawing.Point(83, 227);
            this.TBresult.Name = "TBresult";
            this.TBresult.Size = new System.Drawing.Size(189, 22);
            this.TBresult.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Result: ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(13, 288);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(67, 16);
            this.lbCount.TabIndex = 18;
            this.lbCount.Text = "Count: null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 316);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBresult);
            this.Controls.Add(this.btnHead);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.TBindex);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.TBpush);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.TBmaxCapacity);
            this.Controls.Add(this.Capacity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.TextBox TBmaxCapacity;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox TBpush;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox TBindex;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.TextBox TBresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCount;
    }
}

