﻿namespace MUDWinForms.Forms
{
    partial class LogWindow
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
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb1
            // 
            this.rtb1.BackColor = System.Drawing.Color.Black;
            this.rtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.ForeColor = System.Drawing.Color.White;
            this.rtb1.Location = new System.Drawing.Point(0, 0);
            this.rtb1.Name = "rtb1";
            this.rtb1.ReadOnly = true;
            this.rtb1.Size = new System.Drawing.Size(584, 362);
            this.rtb1.TabIndex = 1;
            this.rtb1.TabStop = false;
            this.rtb1.Text = "";
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.rtb1);
            this.MaximizeBox = false;
            this.Name = "LogWindow";
            this.ShowIcon = false;
            this.Text = "Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb1;
    }
}