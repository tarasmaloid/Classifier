namespace Classifier
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
            this.btnChooseFolder1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseFolder1
            // 
            this.btnChooseFolder1.Location = new System.Drawing.Point(257, 12);
            this.btnChooseFolder1.Name = "btnChooseFolder1";
            this.btnChooseFolder1.Size = new System.Drawing.Size(75, 41);
            this.btnChooseFolder1.TabIndex = 0;
            this.btnChooseFolder1.Text = "Choose folder";
            this.btnChooseFolder1.UseVisualStyleBackColor = true;
            this.btnChooseFolder1.Click += new System.EventHandler(this.btnChooseFolder1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 289);
            this.Controls.Add(this.btnChooseFolder1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFolder1;
    }
}

