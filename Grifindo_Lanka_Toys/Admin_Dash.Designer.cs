namespace Grifindo_Lanka_Toys
{
    partial class Admin_Dash
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
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.btnManageLeave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEmpDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDetails.ForeColor = System.Drawing.Color.Black;
            this.btnEmpDetails.Location = new System.Drawing.Point(163, 58);
            this.btnEmpDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(271, 40);
            this.btnEmpDetails.TabIndex = 48;
            this.btnEmpDetails.Text = "Employee Details";
            this.btnEmpDetails.UseVisualStyleBackColor = false;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnManageLeave
            // 
            this.btnManageLeave.BackColor = System.Drawing.Color.GhostWhite;
            this.btnManageLeave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLeave.ForeColor = System.Drawing.Color.Black;
            this.btnManageLeave.Location = new System.Drawing.Point(163, 106);
            this.btnManageLeave.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageLeave.Name = "btnManageLeave";
            this.btnManageLeave.Size = new System.Drawing.Size(271, 40);
            this.btnManageLeave.TabIndex = 49;
            this.btnManageLeave.Text = "Leave Management";
            this.btnManageLeave.UseVisualStyleBackColor = false;
            this.btnManageLeave.Click += new System.EventHandler(this.btnManageLeave_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(163, 154);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(271, 40);
            this.btnReport.TabIndex = 51;
            this.btnReport.Text = "View Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Welcome Back,";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(263, 224);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 36);
            this.btnLogout.TabIndex = 97;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(597, 287);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnManageLeave);
            this.Controls.Add(this.btnEmpDetails);
            this.Name = "Admin_Dash";
            this.Text = "Admin_Dash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Button btnManageLeave;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}