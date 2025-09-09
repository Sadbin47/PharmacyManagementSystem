namespace PharmacyManagementSystem
{
    partial class FormSignUp
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
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.pnlSignUpDetails = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbUserSelect = new System.Windows.Forms.ComboBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pbLogoSignUp = new System.Windows.Forms.PictureBox();
            this.lblTitleSignUp = new System.Windows.Forms.Label();
            this.lblSubTitleSignUp = new System.Windows.Forms.Label();
            this.pnlSignUp.SuspendLayout();
            this.pnlSignUpDetails.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlSignUp.Controls.Add(this.pnlSignUpDetails);
            this.pnlSignUp.Controls.Add(this.headerPanel);
            this.pnlSignUp.Location = new System.Drawing.Point(12, 12);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(892, 797);
            this.pnlSignUp.TabIndex = 2;
            // 
            // pnlSignUpDetails
            // 
            this.pnlSignUpDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSignUpDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSignUpDetails.Controls.Add(this.lblSignUp);
            this.pnlSignUpDetails.Controls.Add(this.btnCancel);
            this.pnlSignUpDetails.Controls.Add(this.btnCreateAccount);
            this.pnlSignUpDetails.Controls.Add(this.txtConfirmPassword);
            this.pnlSignUpDetails.Controls.Add(this.txtPassword);
            this.pnlSignUpDetails.Controls.Add(this.txtUserName);
            this.pnlSignUpDetails.Controls.Add(this.txtEmail);
            this.pnlSignUpDetails.Controls.Add(this.txtLastName);
            this.pnlSignUpDetails.Controls.Add(this.txtFirstName);
            this.pnlSignUpDetails.Controls.Add(this.cmbUserSelect);
            this.pnlSignUpDetails.Controls.Add(this.lblConfirmPassword);
            this.pnlSignUpDetails.Controls.Add(this.lblPassword);
            this.pnlSignUpDetails.Controls.Add(this.lblUserName);
            this.pnlSignUpDetails.Controls.Add(this.lblEmail);
            this.pnlSignUpDetails.Controls.Add(this.lblLastName);
            this.pnlSignUpDetails.Controls.Add(this.lblFirstName);
            this.pnlSignUpDetails.Controls.Add(this.lblAccType);
            this.pnlSignUpDetails.Location = new System.Drawing.Point(275, 198);
            this.pnlSignUpDetails.Name = "pnlSignUpDetails";
            this.pnlSignUpDetails.Size = new System.Drawing.Size(450, 580);
            this.pnlSignUpDetails.TabIndex = 3;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(172, 22);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(103, 32);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(30, 520);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(180, 45);
            this.btnCreateAccount.TabIndex = 16;
            this.btnCreateAccount.Text = "CREATE ACCOUNT";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 465);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(390, 30);
            this.txtConfirmPassword.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(30, 385);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(390, 30);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(30, 305);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(390, 30);
            this.txtUserName.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(30, 225);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 30);
            this.txtEmail.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(240, 145);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 30);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(30, 145);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 30);
            this.txtFirstName.TabIndex = 10;
            // 
            // cmbUserSelect
            // 
            this.cmbUserSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbUserSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserSelect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserSelect.ForeColor = System.Drawing.Color.White;
            this.cmbUserSelect.FormattingEnabled = true;
            this.cmbUserSelect.Items.AddRange(new object[] {
            "Administrator",
            "Manager"});
            this.cmbUserSelect.Location = new System.Drawing.Point(30, 90);
            this.cmbUserSelect.Name = "cmbUserSelect";
            this.cmbUserSelect.Size = new System.Drawing.Size(390, 28);
            this.cmbUserSelect.TabIndex = 9;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 440);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(131, 19);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPassword.Location = new System.Drawing.Point(30, 360);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 19);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserName.Location = new System.Drawing.Point(30, 280);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 19);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEmail.Location = new System.Drawing.Point(30, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email Address";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLastName.Location = new System.Drawing.Point(240, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFirstName.Location = new System.Drawing.Point(30, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 19);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAccType.Location = new System.Drawing.Point(30, 70);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(99, 19);
            this.lblAccType.TabIndex = 2;
            this.lblAccType.Text = "Account Type";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.headerPanel.Controls.Add(this.pbLogoSignUp);
            this.headerPanel.Controls.Add(this.lblTitleSignUp);
            this.headerPanel.Controls.Add(this.lblSubTitleSignUp);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(892, 180);
            this.headerPanel.TabIndex = 2;
            // 
            // pbLogoSignUp
            // 
            this.pbLogoSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoSignUp.Image = global::PharmacyManagementSystem.Properties.Resources.pngegg;
            this.pbLogoSignUp.Location = new System.Drawing.Point(60, 40);
            this.pbLogoSignUp.Name = "pbLogoSignUp";
            this.pbLogoSignUp.Size = new System.Drawing.Size(100, 100);
            this.pbLogoSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoSignUp.TabIndex = 0;
            this.pbLogoSignUp.TabStop = false;
            // 
            // lblTitleSignUp
            // 
            this.lblTitleSignUp.AutoSize = true;
            this.lblTitleSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleSignUp.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblTitleSignUp.Location = new System.Drawing.Point(180, 50);
            this.lblTitleSignUp.Name = "lblTitleSignUp";
            this.lblTitleSignUp.Size = new System.Drawing.Size(659, 59);
            this.lblTitleSignUp.TabIndex = 1;
            this.lblTitleSignUp.Text = "Pharmacy Management System";
            // 
            // lblSubTitleSignUp
            // 
            this.lblSubTitleSignUp.AutoSize = true;
            this.lblSubTitleSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitleSignUp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitleSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblSubTitleSignUp.Location = new System.Drawing.Point(185, 115);
            this.lblSubTitleSignUp.Name = "lblSubTitleSignUp";
            this.lblSubTitleSignUp.Size = new System.Drawing.Size(357, 30);
            this.lblSubTitleSignUp.TabIndex = 2;
            this.lblSubTitleSignUp.Text = "Access Portal • Create New Account";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(923, 821);
            this.Controls.Add(this.pnlSignUp);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUpDetails.ResumeLayout(false);
            this.pnlSignUpDetails.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Panel pnlSignUpDetails;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbUserSelect;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pbLogoSignUp;
        private System.Windows.Forms.Label lblTitleSignUp;
        private System.Windows.Forms.Label lblSubTitleSignUp;
    }
}