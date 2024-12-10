namespace Grifindo_Lanka_Toys
{
    partial class Emp_Dash
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
            this.btnLeaveHistory = new System.Windows.Forms.Button();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.btnLeaveStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeaveHistory
            // 
            this.btnLeaveHistory.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLeaveHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveHistory.ForeColor = System.Drawing.Color.Black;
            this.btnLeaveHistory.Location = new System.Drawing.Point(151, 197);
            this.btnLeaveHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeaveHistory.Name = "btnLeaveHistory";
            this.btnLeaveHistory.Size = new System.Drawing.Size(283, 40);
            this.btnLeaveHistory.TabIndex = 54;
            this.btnLeaveHistory.Text = "View Leave History";
            this.btnLeaveHistory.UseVisualStyleBackColor = false;
            this.btnLeaveHistory.Click += new System.EventHandler(this.btnLeaveHistory_Click);
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.Color.GhostWhite;
            this.btnApplyLeave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyLeave.ForeColor = System.Drawing.Color.Black;
            this.btnApplyLeave.Location = new System.Drawing.Point(151, 66);
            this.btnApplyLeave.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(283, 40);
            this.btnApplyLeave.TabIndex = 53;
            this.btnApplyLeave.Text = "Apply Leaves";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            this.btnApplyLeave.Click += new System.EventHandler(this.btnApplyLeave_Click);
            // 
            // btnLeaveStatus
            // 
            this.btnLeaveStatus.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLeaveStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveStatus.ForeColor = System.Drawing.Color.Black;
            this.btnLeaveStatus.Location = new System.Drawing.Point(151, 131);
            this.btnLeaveStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeaveStatus.Name = "btnLeaveStatus";
            this.btnLeaveStatus.Size = new System.Drawing.Size(283, 40);
            this.btnLeaveStatus.TabIndex = 52;
            this.btnLeaveStatus.Text = "View Leave Status";
            this.btnLeaveStatus.UseVisualStyleBackColor = false;
            this.btnLeaveStatus.Click += new System.EventHandler(this.btnLeaveStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Welcome Back,";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(468, 269);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 36);
            this.btnLogout.TabIndex = 98;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Emp_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(585, 318);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeaveHistory);
            this.Controls.Add(this.btnApplyLeave);
            this.Controls.Add(this.btnLeaveStatus);
            this.Name = "Emp_Dash";
            this.Text = "Emp_Dash";
            this.Load += new System.EventHandler(this.Emp_Dash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeaveHistory;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.Button btnLeaveStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}