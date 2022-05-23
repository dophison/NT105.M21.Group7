namespace TaiXiu
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbUserLogin = new System.Windows.Forms.Label();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.lbInvalidUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.ptbPass = new System.Windows.Forms.PictureBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.ptbLogin = new System.Windows.Forms.PictureBox();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbUserLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(794, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // lbUserLogin
            // 
            this.lbUserLogin.BackColor = System.Drawing.Color.Red;
            this.lbUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUserLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.lbUserLogin.Location = new System.Drawing.Point(0, 0);
            this.lbUserLogin.Name = "lbUserLogin";
            this.lbUserLogin.Size = new System.Drawing.Size(834, 100);
            this.lbUserLogin.TabIndex = 0;
            this.lbUserLogin.Text = "USER LOGIN";
            this.lbUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBackground
            // 
            this.pnBackground.AutoSize = true;
            this.pnBackground.BackgroundImage = global::TaiXiu.Properties.Resources.background;
            this.pnBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBackground.Controls.Add(this.lbSignUp);
            this.pnBackground.Controls.Add(this.lbInvalidUser);
            this.pnBackground.Controls.Add(this.btnLogin);
            this.pnBackground.Controls.Add(this.tbPassword);
            this.pnBackground.Controls.Add(this.ptbPass);
            this.pnBackground.Controls.Add(this.tbUsername);
            this.pnBackground.Controls.Add(this.ptbLogin);
            this.pnBackground.Location = new System.Drawing.Point(0, 92);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(810, 357);
            this.pnBackground.TabIndex = 1;
            // 
            // lbInvalidUser
            // 
            this.lbInvalidUser.AutoSize = true;
            this.lbInvalidUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbInvalidUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInvalidUser.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidUser.Location = new System.Drawing.Point(168, 258);
            this.lbInvalidUser.Name = "lbInvalidUser";
            this.lbInvalidUser.Size = new System.Drawing.Size(139, 29);
            this.lbInvalidUser.TabIndex = 8;
            this.lbInvalidUser.Text = "Invalid User";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnLogin.Location = new System.Drawing.Point(389, 243);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 67);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(106, 292);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(277, 45);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TabStop = false;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // ptbPass
            // 
            this.ptbPass.Image = global::TaiXiu.Properties.Resources.password;
            this.ptbPass.Location = new System.Drawing.Point(33, 292);
            this.ptbPass.Name = "ptbPass";
            this.ptbPass.Size = new System.Drawing.Size(50, 46);
            this.ptbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPass.TabIndex = 7;
            this.ptbPass.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Location = new System.Drawing.Point(106, 210);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(277, 45);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TabStop = false;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // ptbLogin
            // 
            this.ptbLogin.Image = global::TaiXiu.Properties.Resources.user_login;
            this.ptbLogin.Location = new System.Drawing.Point(33, 210);
            this.ptbLogin.Name = "ptbLogin";
            this.ptbLogin.Size = new System.Drawing.Size(50, 45);
            this.ptbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogin.TabIndex = 5;
            this.ptbLogin.TabStop = false;
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSignUp.ForeColor = System.Drawing.Color.Red;
            this.lbSignUp.Location = new System.Drawing.Point(464, 324);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(339, 25);
            this.lbSignUp.TabIndex = 9;
            this.lbSignUp.Text = "Don\'t have an Account? Sign up now!";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            this.lbSignUp.MouseEnter += new System.EventHandler(this.lbSignUp_MouseEnter);
            this.lbSignUp.MouseLeave += new System.EventHandler(this.lbSignUp_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 447);
            this.Controls.Add(this.pnBackground);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUserLogin;
        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox ptbPass;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.PictureBox ptbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbInvalidUser;
        private System.Windows.Forms.Label lbSignUp;
    }
}

