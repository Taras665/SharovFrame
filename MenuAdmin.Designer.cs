
namespace SharovFrame
{
    partial class MenuAdmin
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
            this.button_UserEdit = new System.Windows.Forms.Button();
            this.button_History = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_UserEdit
            // 
            this.button_UserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UserEdit.Location = new System.Drawing.Point(12, 12);
            this.button_UserEdit.Name = "button_UserEdit";
            this.button_UserEdit.Size = new System.Drawing.Size(191, 56);
            this.button_UserEdit.TabIndex = 0;
            this.button_UserEdit.Text = "Добавление пользователя";
            this.button_UserEdit.UseVisualStyleBackColor = true;
            this.button_UserEdit.Click += new System.EventHandler(this.button_UserEdit_Click);
            // 
            // button_History
            // 
            this.button_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_History.Location = new System.Drawing.Point(12, 74);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(191, 56);
            this.button_History.TabIndex = 1;
            this.button_History.Text = "История входов";
            this.button_History.UseVisualStyleBackColor = true;
            this.button_History.Click += new System.EventHandler(this.button_History_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(12, 136);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(191, 56);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 217);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_History);
            this.Controls.Add(this.button_UserEdit);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_UserEdit;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_Exit;
    }
}