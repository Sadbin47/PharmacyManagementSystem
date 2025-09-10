namespace PharmacyManagementSystem
{
    partial class FormLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLoadingLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbLoadingLogo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblLoadingText);
            this.panel1.Controls.Add(this.pbLoading);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 403);
            this.panel1.TabIndex = 0;
            // 
            // pbLoadingLogo
            // 
            this.pbLoadingLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadingLogo.Image = global::PharmacyManagementSystem.Properties.Resources.pngegg;
            this.pbLoadingLogo.Location = new System.Drawing.Point(153, 114);
            this.pbLoadingLogo.Name = "pbLoadingLogo";
            this.pbLoadingLogo.Size = new System.Drawing.Size(155, 173);
            this.pbLoadingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoadingLogo.TabIndex = 10;
            this.pbLoadingLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 45);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(458, 41);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Pharmacy Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.AutoSize = true;
            this.lblLoadingText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblLoadingText.Location = new System.Drawing.Point(149, 352);
            this.lblLoadingText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(159, 21);
            this.lblLoadingText.TabIndex = 8;
            this.lblLoadingText.Text = "Loading, please wait...";
            this.lblLoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLoading
            // 
            this.pbLoading.ForeColor = System.Drawing.Color.Yellow;
            this.pbLoading.Location = new System.Drawing.Point(153, 309);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(155, 23);
            this.pbLoading.TabIndex = 0;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(497, 428);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLoadingLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoadingText;
        private System.Windows.Forms.ProgressBar pbLoading;
    }
}

