namespace Grifindo_Lanka_Toys
{
    partial class View_Leave_Status
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leaveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAppliedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindo_Lanka_ToysDataSet1 = new Grifindo_Lanka_Toys.Grifindo_Lanka_ToysDataSet1();
            this.btnBack = new System.Windows.Forms.Button();
            this.leaveApplicationTableAdapter = new Grifindo_Lanka_Toys.Grifindo_Lanka_ToysDataSet1TableAdapters.LeaveApplicationTableAdapter();
            this.lveId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Lanka_ToysDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(272, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 49);
            this.label3.TabIndex = 93;
            this.label3.Text = "LEAVE STATUS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveTypeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateAppliedDataGridViewTextBoxColumn,
            this.leaveDatesDataGridViewTextBoxColumn,
            this.leaveIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leaveApplicationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 232);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // leaveTypeDataGridViewTextBoxColumn
            // 
            this.leaveTypeDataGridViewTextBoxColumn.DataPropertyName = "LeaveType";
            this.leaveTypeDataGridViewTextBoxColumn.HeaderText = "LeaveType";
            this.leaveTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveTypeDataGridViewTextBoxColumn.Name = "leaveTypeDataGridViewTextBoxColumn";
            this.leaveTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAppliedDataGridViewTextBoxColumn
            // 
            this.dateAppliedDataGridViewTextBoxColumn.DataPropertyName = "DateApplied";
            this.dateAppliedDataGridViewTextBoxColumn.HeaderText = "DateApplied";
            this.dateAppliedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAppliedDataGridViewTextBoxColumn.Name = "dateAppliedDataGridViewTextBoxColumn";
            this.dateAppliedDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveDatesDataGridViewTextBoxColumn
            // 
            this.leaveDatesDataGridViewTextBoxColumn.DataPropertyName = "LeaveDates";
            this.leaveDatesDataGridViewTextBoxColumn.HeaderText = "LeaveDates";
            this.leaveDatesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveDatesDataGridViewTextBoxColumn.Name = "leaveDatesDataGridViewTextBoxColumn";
            this.leaveDatesDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveIDDataGridViewTextBoxColumn
            // 
            this.leaveIDDataGridViewTextBoxColumn.DataPropertyName = "LeaveID";
            this.leaveIDDataGridViewTextBoxColumn.HeaderText = "LeaveID";
            this.leaveIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveIDDataGridViewTextBoxColumn.Name = "leaveIDDataGridViewTextBoxColumn";
            this.leaveIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveApplicationBindingSource
            // 
            this.leaveApplicationBindingSource.DataMember = "LeaveApplication";
            this.leaveApplicationBindingSource.DataSource = this.grifindo_Lanka_ToysDataSet1;
            // 
            // grifindo_Lanka_ToysDataSet1
            // 
            this.grifindo_Lanka_ToysDataSet1.DataSetName = "Grifindo_Lanka_ToysDataSet1";
            this.grifindo_Lanka_ToysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(700, 401);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 36);
            this.btnBack.TabIndex = 96;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // leaveApplicationTableAdapter
            // 
            this.leaveApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // lveId
            // 
            this.lveId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lveId.Location = new System.Drawing.Point(159, 349);
            this.lveId.Name = "lveId";
            this.lveId.Size = new System.Drawing.Size(141, 27);
            this.lveId.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 111;
            this.label2.Text = "Enter ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(352, 340);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 40);
            this.btnRefresh.TabIndex = 95;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // View_Leave_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.lveId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "View_Leave_Status";
            this.Text = "View_Leave_Status";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindo_Lanka_ToysDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private Grifindo_Lanka_ToysDataSet1 grifindo_Lanka_ToysDataSet1;
        private System.Windows.Forms.BindingSource leaveApplicationBindingSource;
        private Grifindo_Lanka_ToysDataSet1TableAdapters.LeaveApplicationTableAdapter leaveApplicationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAppliedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox lveId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
    }
}