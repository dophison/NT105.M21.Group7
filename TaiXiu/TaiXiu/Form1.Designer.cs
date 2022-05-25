namespace UserInformation
{
    partial class Form1
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
            this.btn_ShowUserInf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ShowUserInf
            // 
            this.btn_ShowUserInf.Image = global::UserInformation.Properties.Resources.imageUser;
            this.btn_ShowUserInf.Location = new System.Drawing.Point(136, 99);
            this.btn_ShowUserInf.Name = "btn_ShowUserInf";
            this.btn_ShowUserInf.Size = new System.Drawing.Size(196, 201);
            this.btn_ShowUserInf.TabIndex = 0;
            this.btn_ShowUserInf.UseVisualStyleBackColor = true;
            this.btn_ShowUserInf.Click += new System.EventHandler(this.btn_ShowUserInf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ShowUserInf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowUserInf;
    }
}

