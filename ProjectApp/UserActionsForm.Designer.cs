
namespace ProjectApp
{
    partial class UserActionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserActionsForm));
            this.ButtonToBack = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.LoadAdButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MonitoringAdButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogAdminButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonToBack
            // 
            this.ButtonToBack.AutoSize = true;
            this.ButtonToBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonToBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonToBack.Location = new System.Drawing.Point(12, 9);
            this.ButtonToBack.Name = "ButtonToBack";
            this.ButtonToBack.Size = new System.Drawing.Size(61, 16);
            this.ButtonToBack.TabIndex = 18;
            this.ButtonToBack.Text = "Log Out";
            this.ButtonToBack.Click += new System.EventHandler(this.ButtonToBack_Click);
            this.ButtonToBack.MouseEnter += new System.EventHandler(this.ButtonToBack_MouseEnter);
            this.ButtonToBack.MouseLeave += new System.EventHandler(this.ButtonToBack_MouseLeave);
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
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // LoadAdButton
            // 
            this.LoadAdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoadAdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadAdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadAdButton.Location = new System.Drawing.Point(173, 144);
            this.LoadAdButton.Name = "LoadAdButton";
            this.LoadAdButton.Size = new System.Drawing.Size(190, 52);
            this.LoadAdButton.TabIndex = 20;
            this.LoadAdButton.Text = "Load Ad";
            this.LoadAdButton.UseVisualStyleBackColor = false;
            this.LoadAdButton.Click += new System.EventHandler(this.LoadAdButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // MonitoringAdButton
            // 
            this.MonitoringAdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MonitoringAdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonitoringAdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonitoringAdButton.Location = new System.Drawing.Point(173, 216);
            this.MonitoringAdButton.Name = "MonitoringAdButton";
            this.MonitoringAdButton.Size = new System.Drawing.Size(190, 52);
            this.MonitoringAdButton.TabIndex = 22;
            this.MonitoringAdButton.Text = "Monitoring Ad";
            this.MonitoringAdButton.UseVisualStyleBackColor = false;
            this.MonitoringAdButton.Click += new System.EventHandler(this.MonitoringAdButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(111, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // LogAdminButton
            // 
            this.LogAdminButton.AutoSize = true;
            this.LogAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogAdminButton.Location = new System.Drawing.Point(411, 539);
            this.LogAdminButton.Name = "LogAdminButton";
            this.LogAdminButton.Size = new System.Drawing.Size(36, 13);
            this.LogAdminButton.TabIndex = 26;
            this.LogAdminButton.Text = "Admin";
            this.LogAdminButton.Click += new System.EventHandler(this.LogAdminButton_Click);
            // 
            // UserActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(459, 561);
            this.Controls.Add(this.LogAdminButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MonitoringAdButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadAdButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ButtonToBack);
            this.Name = "UserActionsForm";
            this.Text = "UserActionsForm";
            this.Load += new System.EventHandler(this.UserActionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ButtonToBack;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button LoadAdButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MonitoringAdButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LogAdminButton;
    }
}