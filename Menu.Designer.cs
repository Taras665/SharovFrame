﻿
namespace SharovFrame
{
    partial class Menu
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
            this.button_WorkerOrder = new System.Windows.Forms.Button();
            this.button_WorkerEdit = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_WorkerOrder
            // 
            this.button_WorkerOrder.Location = new System.Drawing.Point(178, 153);
            this.button_WorkerOrder.Name = "button_WorkerOrder";
            this.button_WorkerOrder.Size = new System.Drawing.Size(75, 23);
            this.button_WorkerOrder.TabIndex = 0;
            this.button_WorkerOrder.Text = "button1";
            this.button_WorkerOrder.UseVisualStyleBackColor = true;
            this.button_WorkerOrder.Click += new System.EventHandler(this.button_WorkerOrder_Click);
            // 
            // button_WorkerEdit
            // 
            this.button_WorkerEdit.Location = new System.Drawing.Point(178, 183);
            this.button_WorkerEdit.Name = "button_WorkerEdit";
            this.button_WorkerEdit.Size = new System.Drawing.Size(75, 23);
            this.button_WorkerEdit.TabIndex = 1;
            this.button_WorkerEdit.Text = "button2";
            this.button_WorkerEdit.UseVisualStyleBackColor = true;
            this.button_WorkerEdit.Click += new System.EventHandler(this.button_WorkerEdit_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(178, 213);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "button3";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_WorkerEdit);
            this.Controls.Add(this.button_WorkerOrder);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_WorkerOrder;
        private System.Windows.Forms.Button button_WorkerEdit;
        private System.Windows.Forms.Button button_Exit;
    }
}