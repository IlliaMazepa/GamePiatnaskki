namespace FINALADO
{
    partial class Registration
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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbPas = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSingup = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(351, 139);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(166, 20);
            this.tbLog.TabIndex = 0;
            // 
            // tbPas
            // 
            this.tbPas.Location = new System.Drawing.Point(351, 206);
            this.tbPas.Name = "tbPas";
            this.tbPas.PasswordChar = '*';
            this.tbPas.Size = new System.Drawing.Size(166, 20);
            this.tbPas.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(312, 279);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSingup
            // 
            this.btnSingup.Location = new System.Drawing.Point(494, 279);
            this.btnSingup.Name = "btnSingup";
            this.btnSingup.Size = new System.Drawing.Size(75, 23);
            this.btnSingup.TabIndex = 3;
            this.btnSingup.Text = "Sign up";
            this.btnSingup.UseVisualStyleBackColor = true;
            this.btnSingup.Click += new System.EventHandler(this.btnSingup_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(374, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Sign in OR Sign up";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(228, 146);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(39, 13);
            this.lblLog.TabIndex = 5;
            this.lblLog.Text = "Login: ";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(228, 213);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 13);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password: ";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSingup);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbPas);
            this.Controls.Add(this.tbLog);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbPas;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSingup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblPass;
    }
}