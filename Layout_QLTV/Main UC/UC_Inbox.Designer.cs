﻿namespace Custom_Tabs
{
    partial class UC_Inbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(695, 236);
            label1.Name = "label1";
            label1.Size = new Size(317, 114);
            label1.TabIndex = 3;
            label1.Text = "Inbox";
            label1.Click += label1_Click;
            // 
            // UC_Inbox
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(label1);
            Name = "UC_Inbox";
            Size = new Size(1706, 1110);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}