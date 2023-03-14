
namespace ProjectApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.ButtonToBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(100, 374);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(257, 37);
            this.PasswordBox.TabIndex = 12;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(100, 297);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(257, 50);
            this.LoginBox.TabIndex = 11;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
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
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSignUp.Location = new System.Drawing.Point(166, 459);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(131, 46);
            this.buttonSignUp.TabIndex = 9;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(27, 148);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(203, 50);
            this.NameBox.TabIndex = 13;
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // SurnameBox
            // 
            this.SurnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SurnameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.Location = new System.Drawing.Point(236, 148);
            this.SurnameBox.Multiline = true;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(203, 50);
            this.SurnameBox.TabIndex = 14;
            this.SurnameBox.Enter += new System.EventHandler(this.SurnameBox_Enter);
            this.SurnameBox.Leave += new System.EventHandler(this.SurnameBox_Leave);
            // 
            // MailBox
            // 
            this.MailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailBox.Location = new System.Drawing.Point(27, 218);
            this.MailBox.Multiline = true;
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(270, 50);
            this.MailBox.TabIndex = 15;
            this.MailBox.Enter += new System.EventHandler(this.MailBox_Enter);
            this.MailBox.Leave += new System.EventHandler(this.MailBox_Leave);
            // 
            // AgeBox
            // 
            this.AgeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AgeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeBox.Location = new System.Drawing.Point(321, 218);
            this.AgeBox.Multiline = true;
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(118, 50);
            this.AgeBox.TabIndex = 16;
            this.AgeBox.Enter += new System.EventHandler(this.AgeBox_Enter);
            this.AgeBox.Leave += new System.EventHandler(this.AgeBox_Leave);
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
            this.ButtonToBack.TabIndex = 17;
            this.ButtonToBack.Text = "Back";
            this.ButtonToBack.Click += new System.EventHandler(this.ButtonToBack_Click);
            this.ButtonToBack.MouseEnter += new System.EventHandler(this.ButtonToBack_MouseEnter);
            this.ButtonToBack.MouseLeave += new System.EventHandler(this.ButtonToBack_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(459, 561);
            this.Controls.Add(this.ButtonToBack);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label ButtonToBack;
    }
}