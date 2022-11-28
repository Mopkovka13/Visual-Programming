
namespace laba6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.krestikiNoliki1 = new laba6.KrestikiNoliki();
            this.SuspendLayout();
            // 
            // krestikiNoliki1
            // 
            this.krestikiNoliki1.Location = new System.Drawing.Point(0, 107);
            this.krestikiNoliki1.Margin = new System.Windows.Forms.Padding(4);
            this.krestikiNoliki1.Name = "krestikiNoliki1";
            this.krestikiNoliki1.Size = new System.Drawing.Size(489, 414);
            this.krestikiNoliki1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 519);
            this.Controls.Add(this.krestikiNoliki1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private KrestikiNoliki krestikiNoliki1;
    }
}

