namespace windowForm2.Global
{
    partial class Account_SignUp
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
            this.panelAccount_Insert = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioBtnEmployer = new System.Windows.Forms.RadioButton();
            this.radioBtnStudent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword_reEnter = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword_signUp = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txtUsername_signUp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAccount_Insert.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccount_Insert
            // 
            this.panelAccount_Insert.Controls.Add(this.panel2);
            this.panelAccount_Insert.Controls.Add(this.panel3);
            this.panelAccount_Insert.Controls.Add(this.panel1);
            this.panelAccount_Insert.Controls.Add(this.panelUsername);
            this.panelAccount_Insert.Controls.Add(this.label2);
            this.panelAccount_Insert.Controls.Add(this.label6);
            this.panelAccount_Insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccount_Insert.Location = new System.Drawing.Point(0, 0);
            this.panelAccount_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAccount_Insert.Name = "panelAccount_Insert";
            this.panelAccount_Insert.Size = new System.Drawing.Size(800, 562);
            this.panelAccount_Insert.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.radioBtnEmployer);
            this.panel2.Controls.Add(this.radioBtnStudent);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 95);
            this.panel2.TabIndex = 3;
            // 
            // radioBtnEmployer
            // 
            this.radioBtnEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnEmployer.AutoSize = true;
            this.radioBtnEmployer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnEmployer.Location = new System.Drawing.Point(201, 55);
            this.radioBtnEmployer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnEmployer.Name = "radioBtnEmployer";
            this.radioBtnEmployer.Size = new System.Drawing.Size(105, 25);
            this.radioBtnEmployer.TabIndex = 4;
            this.radioBtnEmployer.TabStop = true;
            this.radioBtnEmployer.Text = "Employer";
            this.radioBtnEmployer.UseVisualStyleBackColor = true;
            this.radioBtnEmployer.CheckedChanged += new System.EventHandler(this.radioBtnStudent_CheckedChanged);
            // 
            // radioBtnStudent
            // 
            this.radioBtnStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnStudent.AutoSize = true;
            this.radioBtnStudent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnStudent.Location = new System.Drawing.Point(69, 55);
            this.radioBtnStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnStudent.Name = "radioBtnStudent";
            this.radioBtnStudent.Size = new System.Drawing.Size(96, 25);
            this.radioBtnStudent.TabIndex = 3;
            this.radioBtnStudent.TabStop = true;
            this.radioBtnStudent.Text = "Student";
            this.radioBtnStudent.UseVisualStyleBackColor = true;
            this.radioBtnStudent.CheckedChanged += new System.EventHandler(this.radioBtnStudent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up as";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtPassword_reEnter);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(3, 254);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 56);
            this.panel3.TabIndex = 1;
            // 
            // txtPassword_reEnter
            // 
            this.txtPassword_reEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword_reEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_reEnter.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword_reEnter.Location = new System.Drawing.Point(56, 10);
            this.txtPassword_reEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword_reEnter.Name = "txtPassword_reEnter";
            this.txtPassword_reEnter.Size = new System.Drawing.Size(678, 29);
            this.txtPassword_reEnter.TabIndex = 2;
            this.txtPassword_reEnter.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::windowForm2.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPassword_signUp);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 164);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 56);
            this.panel1.TabIndex = 1;
            // 
            // txtPassword_signUp
            // 
            this.txtPassword_signUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword_signUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_signUp.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword_signUp.Location = new System.Drawing.Point(56, 10);
            this.txtPassword_signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword_signUp.Name = "txtPassword_signUp";
            this.txtPassword_signUp.Size = new System.Drawing.Size(678, 29);
            this.txtPassword_signUp.TabIndex = 1;
            this.txtPassword_signUp.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::windowForm2.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelUsername
            // 
            this.panelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.Controls.Add(this.txtUsername_signUp);
            this.panelUsername.Controls.Add(this.pictureBox1);
            this.panelUsername.Location = new System.Drawing.Point(3, 100);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(772, 56);
            this.panelUsername.TabIndex = 1;
            // 
            // txtUsername_signUp
            // 
            this.txtUsername_signUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername_signUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername_signUp.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername_signUp.Location = new System.Drawing.Point(56, 10);
            this.txtUsername_signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername_signUp.Name = "txtUsername_signUp";
            this.txtUsername_signUp.Size = new System.Drawing.Size(678, 29);
            this.txtUsername_signUp.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::windowForm2.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(3, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Re-enter the password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sign Up Now !";
            // 
            // Account_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelAccount_Insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Account_SignUp";
            this.Text = "Account_SignUp";
            this.panelAccount_Insert.ResumeLayout(false);
            this.panelAccount_Insert.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccount_Insert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioBtnEmployer;
        private System.Windows.Forms.RadioButton radioBtnStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword_signUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtUsername_signUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassword_reEnter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}