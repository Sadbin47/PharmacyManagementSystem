namespace PharmacyManagementSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.pbLoginLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.pnlPassword = new System.Windows.Forms.Label();
            this.pnlUserId = new System.Windows.Forms.Label();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).BeginInit();
            this.pnlSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlLogin);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 696);
            this.panel1.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlLogin.Controls.Add(this.pnlHeader);
            this.pnlLogin.Controls.Add(this.pnlSignIn);
            this.pnlLogin.Location = new System.Drawing.Point(-20, -32);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(975, 760);
            this.pnlLogin.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlHeader.Controls.Add(this.accentPanel);
            this.pnlHeader.Controls.Add(this.pbLoginLogo);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(975, 180);
            this.pnlHeader.TabIndex = 2;
            // 
            // accentPanel
            // 
            this.accentPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.accentPanel.Location = new System.Drawing.Point(0, 170);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(975, 10);
            this.accentPanel.TabIndex = 4;
            // 
            // pbLoginLogo
            // 
            this.pbLoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLoginLogo.Image = global::PharmacyManagementSystem.Properties.Resources.pngegg;
            this.pbLoginLogo.Location = new System.Drawing.Point(60, 40);
            this.pbLoginLogo.Name = "pbLoginLogo";
            this.pbLoginLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginLogo.TabIndex = 0;
            this.pbLoginLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(180, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(659, 59);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pharmacy Management System";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblSubTitle.Location = new System.Drawing.Point(185, 115);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(300, 30);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Access Portal • Verify YourSelf";
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSignIn.Controls.Add(this.chkPassword);
            this.pnlSignIn.Controls.Add(this.lblSignIn);
            this.pnlSignIn.Controls.Add(this.btnCancel);
            this.pnlSignIn.Controls.Add(this.btnLogin);
            this.pnlSignIn.Controls.Add(this.txtPassword);
            this.pnlSignIn.Controls.Add(this.txtUserId);
            this.pnlSignIn.Controls.Add(this.pnlPassword);
            this.pnlSignIn.Controls.Add(this.pnlUserId);
            this.pnlSignIn.Location = new System.Drawing.Point(300, 270);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(450, 410);
            this.pnlSignIn.TabIndex = 3;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblSignIn.Location = new System.Drawing.Point(174, 21);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(94, 32);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "Sign In";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lime;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(60, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(60, 212);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(330, 35);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.White;
            this.txtUserId.Location = new System.Drawing.Point(60, 115);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(330, 35);
            this.txtUserId.TabIndex = 6;
            // 
            // pnlPassword
            // 
            this.pnlPassword.AutoSize = true;
            this.pnlPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pnlPassword.Location = new System.Drawing.Point(56, 180);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(76, 20);
            this.pnlPassword.TabIndex = 4;
            this.pnlPassword.Text = "Password";
            // 
            // pnlUserId
            // 
            this.pnlUserId.AutoSize = true;
            this.pnlUserId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUserId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pnlUserId.Location = new System.Drawing.Point(56, 78);
            this.pnlUserId.Name = "pnlUserId";
            this.pnlUserId.Size = new System.Drawing.Size(57, 20);
            this.pnlUserId.TabIndex = 3;
            this.pnlUserId.Text = "UserID";
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.chkPassword.ForeColor = System.Drawing.Color.White;
            this.chkPassword.Location = new System.Drawing.Point(60, 254);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(108, 17);
            this.chkPassword.TabIndex = 10;
            this.chkPassword.Text = "Show Password";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(959, 721);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).EndInit();
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.PictureBox pbLoginLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label pnlPassword;
        private System.Windows.Forms.Label pnlUserId;
        private System.Windows.Forms.CheckBox chkPassword;
    }
}