﻿namespace Classifier
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGrayscaleAndResizingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAllImagesToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHumanDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeGrayscaleAndResizingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "Files";
            // 
            // makeGrayscaleAndResizingToolStripMenuItem
            // 
            this.makeGrayscaleAndResizingToolStripMenuItem.Name = "makeGrayscaleAndResizingToolStripMenuItem";
            this.makeGrayscaleAndResizingToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.makeGrayscaleAndResizingToolStripMenuItem.Text = "Make grayscale and resizing";
            this.makeGrayscaleAndResizingToolStripMenuItem.Click += new System.EventHandler(this.makeGrayscaleAndResizingToolStripMenuItem_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAllImagesToDBToolStripMenuItem,
            this.clearHumanDBToolStripMenuItem});
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.databasesToolStripMenuItem.Text = "Databases";
            // 
            // addAllImagesToDBToolStripMenuItem
            // 
            this.addAllImagesToDBToolStripMenuItem.Name = "addAllImagesToDBToolStripMenuItem";
            this.addAllImagesToDBToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addAllImagesToDBToolStripMenuItem.Text = "Add all humans";
            this.addAllImagesToDBToolStripMenuItem.Click += new System.EventHandler(this.addAllImagesToDBToolStripMenuItem_Click);
            // 
            // clearHumanDBToolStripMenuItem
            // 
            this.clearHumanDBToolStripMenuItem.Name = "clearHumanDBToolStripMenuItem";
            this.clearHumanDBToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearHumanDBToolStripMenuItem.Text = "Clear HumanDB";
            this.clearHumanDBToolStripMenuItem.Click += new System.EventHandler(this.clearHumanDBToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 289);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeGrayscaleAndResizingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAllImagesToDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHumanDBToolStripMenuItem;
    }
}

