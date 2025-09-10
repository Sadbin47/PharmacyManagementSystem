namespace PharmacyManagementSystem
{
    partial class FormManager
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
            this.pnlInfoPlace = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.pnlManagement = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
            this.pnlManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfoPlace
            // 
            this.pnlInfoPlace.Location = new System.Drawing.Point(209, 105);
            this.pnlInfoPlace.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInfoPlace.Name = "pnlInfoPlace";
            this.pnlInfoPlace.Size = new System.Drawing.Size(795, 386);
            this.pnlInfoPlace.TabIndex = 10;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.headerPanel.Controls.Add(this.logoImageBox);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubTitle);
            this.headerPanel.Controls.Add(this.accentPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1015, 100);
            this.headerPanel.TabIndex = 8;
            // 
            // logoImageBox
            // 
            this.logoImageBox.BackColor = System.Drawing.Color.Transparent;
            this.logoImageBox.Image = global::PharmacyManagementSystem.Properties.Resources.pngegg;
            this.logoImageBox.Location = new System.Drawing.Point(30, 20);
            this.logoImageBox.Name = "logoImageBox";
            this.logoImageBox.Size = new System.Drawing.Size(60, 60);
            this.logoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImageBox.TabIndex = 0;
            this.logoImageBox.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(110, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "◆ Manager Panel";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblSubTitle.Location = new System.Drawing.Point(115, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(385, 21);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Manage System • Shop Control • Analytics Dashboard";
            // 
            // accentPanel
            // 
            this.accentPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accentPanel.Location = new System.Drawing.Point(0, 95);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(1015, 5);
            this.accentPanel.TabIndex = 3;
            // 
            // pnlManagement
            // 
            this.pnlManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlManagement.Controls.Add(this.btnLogOut);
            this.pnlManagement.Controls.Add(this.btnViewUser);
            this.pnlManagement.Controls.Add(this.btnSignUp);
            this.pnlManagement.Controls.Add(this.btnDashboard);
            this.pnlManagement.Location = new System.Drawing.Point(0, 98);
            this.pnlManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlManagement.Name = "pnlManagement";
            this.pnlManagement.Size = new System.Drawing.Size(194, 404);
            this.pnlManagement.TabIndex = 9;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(32, 353);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(130, 39);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Exit";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewUser.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.Location = new System.Drawing.Point(32, 167);
            this.btnViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(130, 39);
            this.btnViewUser.TabIndex = 2;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSignUp.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(32, 103);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(130, 39);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Add User";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(32, 37);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(130, 39);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1015, 502);
            this.Controls.Add(this.pnlInfoPlace);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.pnlManagement);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
            this.pnlManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfoPlace;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox logoImageBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.Panel pnlManagement;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnDashboard;
    }
}