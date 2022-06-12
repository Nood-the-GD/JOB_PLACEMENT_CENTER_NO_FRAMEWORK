namespace windowForm2.StudentInterfaces
{
    partial class MainForm_Student
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
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.btnAppliedJob = new FontAwesome.Sharp.IconButton();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.manageCVBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.panelSideBar.Controls.Add(this.btnAppliedJob);
            this.panelSideBar.Controls.Add(this.logOutButton);
            this.panelSideBar.Controls.Add(this.manageCVBtn);
            this.panelSideBar.Controls.Add(this.homeBtn);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(230, 941);
            this.panelSideBar.TabIndex = 0;
            // 
            // btnAppliedJob
            // 
            this.btnAppliedJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppliedJob.FlatAppearance.BorderSize = 0;
            this.btnAppliedJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppliedJob.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAppliedJob.ForeColor = System.Drawing.Color.White;
            this.btnAppliedJob.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAppliedJob.IconColor = System.Drawing.Color.White;
            this.btnAppliedJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppliedJob.IconSize = 30;
            this.btnAppliedJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppliedJob.Location = new System.Drawing.Point(0, 150);
            this.btnAppliedJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAppliedJob.Name = "btnAppliedJob";
            this.btnAppliedJob.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAppliedJob.Size = new System.Drawing.Size(230, 75);
            this.btnAppliedJob.TabIndex = 4;
            this.btnAppliedJob.Text = "Applied Job";
            this.btnAppliedJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppliedJob.UseVisualStyleBackColor = true;
            this.btnAppliedJob.Click += new System.EventHandler(this.btnAppliedJob_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logOutButton.IconColor = System.Drawing.Color.White;
            this.logOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutButton.IconSize = 30;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(0, 866);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(230, 75);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // manageCVBtn
            // 
            this.manageCVBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageCVBtn.FlatAppearance.BorderSize = 0;
            this.manageCVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCVBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manageCVBtn.ForeColor = System.Drawing.Color.White;
            this.manageCVBtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.manageCVBtn.IconColor = System.Drawing.Color.White;
            this.manageCVBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manageCVBtn.IconSize = 30;
            this.manageCVBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageCVBtn.Location = new System.Drawing.Point(0, 75);
            this.manageCVBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageCVBtn.Name = "manageCVBtn";
            this.manageCVBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.manageCVBtn.Size = new System.Drawing.Size(230, 75);
            this.manageCVBtn.TabIndex = 2;
            this.manageCVBtn.Text = "Manage CV";
            this.manageCVBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageCVBtn.UseVisualStyleBackColor = true;
            this.manageCVBtn.Click += new System.EventHandler(this.manageCVBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.White;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 30;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(230, 75);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Location = new System.Drawing.Point(236, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1134, 935);
            this.panelContent.TabIndex = 1;
            // 
            // MainForm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 941);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Student";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelContent;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton logOutButton;
        private FontAwesome.Sharp.IconButton manageCVBtn;
        private FontAwesome.Sharp.IconButton btnAppliedJob;
    }
}
