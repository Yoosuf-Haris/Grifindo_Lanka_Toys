namespace Grifindo_Lanka_Toys
{
    partial class Approve_Leave
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
            this.components = new System.ComponentModel.Container();
            this.btnApprove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewLeaveRequests = new System.Windows.Forms.DataGridView();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grifindo_Lanka_ToysDataSet = new Grifindo_Lanka_Toys.Grifindo_Lanka_ToysDataSet();
            this.leaveApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveApplicationTableAdapter = new Grifindo_Lanka_Toys.Grifindo_Lanka_ToysDataSetTableAdapters.LeaveApplicationTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Lanka_ToysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.GhostWhite;
            this.btnApprove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.Black;
            this.btnApprove.Location = new System.Drawing.Point(169, 382);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(134, 40);
            this.btnApprove.TabIndex = 49;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 49);
            this.label3.TabIndex = 70;
            this.label3.Text = "LEAVE REQUESTS";
            // 
            // dataGridViewLeaveRequests
            // 
            this.dataGridViewLeaveRequests.AllowUserToAddRows = false;
            this.dataGridViewLeaveRequests.AllowUserToDeleteRows = false;
            this.dataGridViewLeaveRequests.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewLeaveRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaveRequests.Location = new System.Drawing.Point(152, 103);
            this.dataGridViewLeaveRequests.Name = "dataGridViewLeaveRequests";
            this.dataGridViewLeaveRequests.ReadOnly = true;
            this.dataGridViewLeaveRequests.RowHeadersWidth = 51;
            this.dataGridViewLeaveRequests.RowTemplate.Height = 24;
            this.dataGridViewLeaveRequests.Size = new System.Drawing.Size(609, 253);
            this.dataGridViewLeaveRequests.TabIndex = 71;
            this.dataGridViewLeaveRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReject.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.Black;
            this.btnReject.Location = new System.Drawing.Point(378, 382);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(134, 40);
            this.btnReject.TabIndex = 72;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(798, 464);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 36);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // grifindo_Lanka_ToysDataSet
            // 
            this.grifindo_Lanka_ToysDataSet.DataSetName = "Grifindo_Lanka_ToysDataSet";
            this.grifindo_Lanka_ToysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveApplicationBindingSource
            // 
            this.leaveApplicationBindingSource.DataMember = "LeaveApplication";
            this.leaveApplicationBindingSource.DataSource = this.grifindo_Lanka_ToysDataSet;
            // 
            // leaveApplicationTableAdapter
            // 
            this.leaveApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(595, 382);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 40);
            this.btnRefresh.TabIndex = 75;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // Approve_Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(884, 513);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.dataGridViewLeaveRequests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApprove);
            this.Name = "Approve_Leave";
            this.Text = "Approve_Leave";
            this.Load += new System.EventHandler(this.Approve_Leave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Lanka_ToysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewLeaveRequests;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnBack;
        private Grifindo_Lanka_ToysDataSet grifindo_Lanka_ToysDataSet;
        private System.Windows.Forms.BindingSource leaveApplicationBindingSource;
        private Grifindo_Lanka_ToysDataSetTableAdapters.LeaveApplicationTableAdapter leaveApplicationTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
    }
}