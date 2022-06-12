namespace windowForm2.EmployerInterface
{
    partial class MainForm_Employer
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
            this.changeInformationBtn = new FontAwesome.Sharp.IconButton();
            this.logOutButton = new FontAwesome.Sharp.IconButton();
            this.eventManageBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(3)))), ((int)(((byte)(30)))));
            this.panelSideBar.Controls.Add(this.changeInformationBtn);
            this.panelSideBar.Controls.Add(this.logOutButton);
            this.panelSideBar.Controls.Add(this.eventManageBtn);
            this.panelSideBar.Controls.Add(this.homeBtn);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(230, 643);
            this.panelSideBar.TabIndex = 1;
            // 
            // changeInformationBtn
            // 
            this.changeInformationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeInformationBtn.FlatAppearance.BorderSize = 0;
            this.changeInformationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeInformationBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeInformationBtn.ForeColor = System.Drawing.Color.White;
            this.changeInformationBtn.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.changeInformationBtn.IconColor = System.Drawing.Color.White;
            this.changeInformationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeInformationBtn.IconSize = 30;
            this.changeInformationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeInformationBtn.Location = new System.Drawing.Point(0, 120);
            this.changeInformationBtn.Name = "changeInformationBtn";
            this.changeInformationBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.changeInformationBtn.Size = new System.Drawing.Size(230, 60);
            this.changeInformationBtn.TabIndex = 4;
            this.changeInformationBtn.Text = "Change Information";
            this.changeInformationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeInformationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeInformationBtn.UseVisualStyleBackColor = true;
            this.changeInformationBtn.Click += new System.EventHandler(this.changeInformationBtn_Click);
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
            this.logOutButton.Location = new System.Drawing.Point(0, 583);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(230, 60);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // eventManageBtn
            // 
            this.eventManageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventManageBtn.FlatAppearance.BorderSize = 0;
            this.eventManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventManageBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventManageBtn.ForeColor = System.Drawing.Color.White;
            this.eventManageBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.eventManageBtn.IconColor = System.Drawing.Color.White;
            this.eventManageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eventManageBtn.IconSize = 30;
            this.eventManageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventManageBtn.Location = new System.Drawing.Point(0, 60);
            this.eventManageBtn.Name = "eventManageBtn";
            this.eventManageBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.eventManageBtn.Size = new System.Drawing.Size(230, 60);
            this.eventManageBtn.TabIndex = 2;
            this.eventManageBtn.Text = "Manage Recruitment Event";
            this.eventManageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventManageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eventManageBtn.UseVisualStyleBackColor = true;
            this.eventManageBtn.Click += new System.EventHandler(this.eventManageBtn_Click);
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
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(230, 60);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Candidate List";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(236, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1078, 621);
            this.panelContent.TabIndex = 2;
            // 
            // MainForm_Employer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1326, 643);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm_Employer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Employer";
            this.Load += new System.EventHandler(this.MainForm_Employer_Load);
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private FontAwesome.Sharp.IconButton logOutButton;
        private FontAwesome.Sharp.IconButton eventManageBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private System.Windows.Forms.Panel panelContent;
        private FontAwesome.Sharp.IconButton changeInformationBtn;
    }
}