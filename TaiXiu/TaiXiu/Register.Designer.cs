namespace TaiXiu
{
    partial class Register
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
            this.lbSignIn = new System.Windows.Forms.Label();
            this.lbPassSame = new System.Windows.Forms.Label();
            this.lbEnterInfo = new System.Windows.Forms.Label();
            this.lbAlrealyExists = new System.Windows.Forms.Label();
            this.ptbConfirmPass = new System.Windows.Forms.PictureBox();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.ptbPass = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.ptbLogin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbUserLogin);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(859, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbUserLogin
            // 
            this.lbUserLogin.BackColor = System.Drawing.Color.Black;
            this.lbUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUserLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.lbUserLogin.Location = new System.Drawing.Point(0, 0);
            this.lbUserLogin.Name = "lbUserLogin";
            this.lbUserLogin.Size = new System.Drawing.Size(899, 100);
            this.lbUserLogin.TabIndex = 0;
            this.lbUserLogin.Text = "USER SIGN UP";
            this.lbUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBackground
            // 
            this.pnBackground.BackgroundImage = global::TaiXiu.Properties.Resources.backgroundsignup;
            this.pnBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBackground.Controls.Add(this.lbSignIn);
            this.pnBackground.Controls.Add(this.lbPassSame);
            this.pnBackground.Controls.Add(this.lbEnterInfo);
            this.pnBackground.Controls.Add(this.lbAlrealyExists);
            this.pnBackground.Controls.Add(this.ptbConfirmPass);
            this.pnBackground.Controls.Add(this.tbConfirmPass);
            this.pnBackground.Controls.Add(this.ptbPass);
            this.pnBackground.Controls.Add(this.tbPassword);
            this.pnBackground.Controls.Add(this.btnCreateAcc);
            this.pnBackground.Controls.Add(this.tbUsername);
            this.pnBackground.Controls.Add(this.ptbLogin);
            this.pnBackground.Location = new System.Drawing.Point(-2, 98);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(896, 391);
            this.pnBackground.TabIndex = 2;
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSignIn.ForeColor = System.Drawing.Color.Red;
            this.lbSignIn.Location = new System.Drawing.Point(71, 18);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(264, 25);
            this.lbSignIn.TabIndex = 19;
            this.lbSignIn.Text = "Alrealy have account? Login!";
            this.lbSignIn.Click += new System.EventHandler(this.lbSignIn_Click);
            this.lbSignIn.MouseEnter += new System.EventHandler(this.lbSignIn_MouseEnter);
            this.lbSignIn.MouseLeave += new System.EventHandler(this.lbSignIn_MouseLeave);
            // 
            // lbPassSame
            // 
            this.lbPassSame.AutoSize = true;
            this.lbPassSame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPassSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPassSame.ForeColor = System.Drawing.Color.Red;
            this.lbPassSame.Location = new System.Drawing.Point(571, 173);
            this.lbPassSame.Name = "lbPassSame";
            this.lbPassSame.Size = new System.Drawing.Size(208, 25);
            this.lbPassSame.TabIndex = 18;
            this.lbPassSame.Text = "Password is not same!";
            // 
            // lbEnterInfo
            // 
            this.lbEnterInfo.AutoSize = true;
            this.lbEnterInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEnterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEnterInfo.ForeColor = System.Drawing.Color.Red;
            this.lbEnterInfo.Location = new System.Drawing.Point(569, 261);
            this.lbEnterInfo.Name = "lbEnterInfo";
            this.lbEnterInfo.Size = new System.Drawing.Size(287, 25);
            this.lbEnterInfo.TabIndex = 17;
            this.lbEnterInfo.Text = "Please enter full your infomation";
            // 
            // lbAlrealyExists
            // 
            this.lbAlrealyExists.AutoSize = true;
            this.lbAlrealyExists.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAlrealyExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAlrealyExists.ForeColor = System.Drawing.Color.Red;
            this.lbAlrealyExists.Location = new System.Drawing.Point(571, 18);
            this.lbAlrealyExists.Name = "lbAlrealyExists";
            this.lbAlrealyExists.Size = new System.Drawing.Size(268, 25);
            this.lbAlrealyExists.TabIndex = 16;
            this.lbAlrealyExists.Text = "Username has alrealy existed";
            // 
            // ptbConfirmPass
            // 
            this.ptbConfirmPass.Image = global::TaiXiu.Properties.Resources.confirm_password;
            this.ptbConfirmPass.Location = new System.Drawing.Point(488, 200);
            this.ptbConfirmPass.Name = "ptbConfirmPass";
            this.ptbConfirmPass.Size = new System.Drawing.Size(50, 46);
            this.ptbConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbConfirmPass.TabIndex = 15;
            this.ptbConfirmPass.TabStop = false;
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbConfirmPass.ForeColor = System.Drawing.Color.Silver;
            this.tbConfirmPass.Location = new System.Drawing.Point(574, 200);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Size = new System.Drawing.Size(277, 45);
            this.tbConfirmPass.TabIndex = 14;
            this.tbConfirmPass.TabStop = false;
            this.tbConfirmPass.Text = "Confirm Password";
            this.tbConfirmPass.TextChanged += new System.EventHandler(this.tbConfirmPass_TextChanged);
            this.tbConfirmPass.Enter += new System.EventHandler(this.tbConfirmPass_Enter);
            this.tbConfirmPass.Leave += new System.EventHandler(this.tbConfirmPass_Leave);
            // 
            // ptbPass
            // 
            this.ptbPass.Image = global::TaiXiu.Properties.Resources.password;
            this.ptbPass.Location = new System.Drawing.Point(488, 125);
            this.ptbPass.Name = "ptbPass";
            this.ptbPass.Size = new System.Drawing.Size(50, 46);
            this.ptbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPass.TabIndex = 13;
            this.ptbPass.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(574, 125);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(277, 45);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.TabStop = false;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.AutoSize = true;
            this.btnCreateAcc.BackColor = System.Drawing.Color.OldLace;
            this.btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.btnCreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateAcc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCreateAcc.Location = new System.Drawing.Point(488, 289);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(363, 67);
            this.btnCreateAcc.TabIndex = 11;
            this.btnCreateAcc.Text = "CREATE ACCOUNT";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Location = new System.Drawing.Point(574, 51);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(277, 45);
            this.tbUsername.TabIndex = 9;
            this.tbUsername.TabStop = false;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // ptbLogin
            // 
            this.ptbLogin.Image = global::TaiXiu.Properties.Resources.user_login;
            this.ptbLogin.Location = new System.Drawing.Point(488, 51);
            this.ptbLogin.Name = "ptbLogin";
            this.ptbLogin.Size = new System.Drawing.Size(50, 45);
            this.ptbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogin.TabIndex = 12;
            this.ptbLogin.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 487);
            this.Controls.Add(this.pnBackground);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbUserLogin;
        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.PictureBox ptbConfirmPass;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.PictureBox ptbPass;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.PictureBox ptbLogin;
        private System.Windows.Forms.Label lbAlrealyExists;
        private System.Windows.Forms.Label lbEnterInfo;
        private System.Windows.Forms.Label lbPassSame;
        private System.Windows.Forms.Label lbSignIn;
    }
}