
namespace ProjectApp
{
    partial class DeleteUserForm
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
            this.CloseButton = new System.Windows.Forms.Label();
            this.ButtonToBack = new System.Windows.Forms.Label();
            this.userLoginBox = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Gray;
            this.CloseButton.Location = new System.Drawing.Point(420, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 31);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ButtonToBack
            // 
            this.ButtonToBack.AutoSize = true;
            this.ButtonToBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonToBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonToBack.Location = new System.Drawing.Point(12, 9);
            this.ButtonToBack.Name = "ButtonToBack";
            this.ButtonToBack.Size = new System.Drawing.Size(43, 16);
            this.ButtonToBack.TabIndex = 22;
            this.ButtonToBack.Text = "Back";
            this.ButtonToBack.Click += new System.EventHandler(this.ButtonToBack_Click);
            // 
            // userLoginBox
            // 
            this.userLoginBox.Location = new System.Drawing.Point(59, 218);
            this.userLoginBox.Multiline = true;
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(340, 46);
            this.userLoginBox.TabIndex = 24;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Location = new System.Drawing.Point(236, 270);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 25;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInfo.Location = new System.Drawing.Point(143, 270);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(75, 23);
            this.ButtonInfo.TabIndex = 26;
            this.ButtonInfo.Text = "Info";
            this.ButtonInfo.UseVisualStyleBackColor = true;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(459, 561);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.userLoginBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ButtonToBack);
            this.Name = "DeleteUserForm";
            this.Text = "DeleteUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label ButtonToBack;
        private System.Windows.Forms.TextBox userLoginBox;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonInfo;
    }
}