namespace IndividualTask
{
    partial class SysLookupForm
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
            this.dgvLookup = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOnAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedOnAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.dtCreatedOn = new System.Windows.Forms.DateTimePicker();
            this.lblModifiedOn = new System.Windows.Forms.Label();
            this.dtModifiedOn = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLookup
            // 
            this.dgvLookup.AllowUserToAddRows = false;
            this.dgvLookup.AllowUserToDeleteRows = false;
            this.dgvLookup.AllowUserToOrderColumns = true;
            this.dgvLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLookup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CreatedOnAll,
            this.ModifiedOnAll,
            this.NameAll,
            this.DescriptionAll});
            this.dgvLookup.Location = new System.Drawing.Point(263, 12);
            this.dgvLookup.Name = "dgvLookup";
            this.dgvLookup.ReadOnly = true;
            this.dgvLookup.RowTemplate.Height = 24;
            this.dgvLookup.Size = new System.Drawing.Size(525, 374);
            this.dgvLookup.TabIndex = 0;
            this.dgvLookup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLookup_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CreatedOnAll
            // 
            this.CreatedOnAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedOnAll.DataPropertyName = "CreatedOn";
            this.CreatedOnAll.HeaderText = "Дата создания";
            this.CreatedOnAll.Name = "CreatedOnAll";
            this.CreatedOnAll.ReadOnly = true;
            // 
            // ModifiedOnAll
            // 
            this.ModifiedOnAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModifiedOnAll.DataPropertyName = "ModifiedOn";
            this.ModifiedOnAll.HeaderText = "Дата изменения";
            this.ModifiedOnAll.Name = "ModifiedOnAll";
            this.ModifiedOnAll.ReadOnly = true;
            // 
            // NameAll
            // 
            this.NameAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameAll.DataPropertyName = "Name";
            this.NameAll.HeaderText = "Название";
            this.NameAll.Name = "NameAll";
            this.NameAll.ReadOnly = true;
            // 
            // DescriptionAll
            // 
            this.DescriptionAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionAll.DataPropertyName = "Description";
            this.DescriptionAll.HeaderText = "Описание";
            this.DescriptionAll.Name = "DescriptionAll";
            this.DescriptionAll.ReadOnly = true;
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Location = new System.Drawing.Point(12, 64);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(108, 17);
            this.lblCreatedOn.TabIndex = 2;
            this.lblCreatedOn.Text = "Дата создания";
            // 
            // dtCreatedOn
            // 
            this.dtCreatedOn.CustomFormat = "dd:MM:yyyy HH:mm:ss";
            this.dtCreatedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatedOn.Location = new System.Drawing.Point(15, 84);
            this.dtCreatedOn.Name = "dtCreatedOn";
            this.dtCreatedOn.Size = new System.Drawing.Size(242, 22);
            this.dtCreatedOn.TabIndex = 3;
            this.dtCreatedOn.Value = new System.DateTime(2020, 1, 5, 17, 8, 16, 0);
            // 
            // lblModifiedOn
            // 
            this.lblModifiedOn.AutoSize = true;
            this.lblModifiedOn.Location = new System.Drawing.Point(12, 117);
            this.lblModifiedOn.Name = "lblModifiedOn";
            this.lblModifiedOn.Size = new System.Drawing.Size(118, 17);
            this.lblModifiedOn.TabIndex = 2;
            this.lblModifiedOn.Text = "Дата изменения";
            // 
            // dtModifiedOn
            // 
            this.dtModifiedOn.CustomFormat = "dd:MM:yyyy HH:mm:ss";
            this.dtModifiedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtModifiedOn.Location = new System.Drawing.Point(15, 137);
            this.dtModifiedOn.Name = "dtModifiedOn";
            this.dtModifiedOn.Size = new System.Drawing.Size(242, 22);
            this.dtModifiedOn.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Название";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 193);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 22);
            this.txtName.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 227);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Описание";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(15, 247);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(239, 99);
            this.rtxtDescription.TabIndex = 6;
            this.rtxtDescription.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Image = global::IndividualTask.Properties.Resources.iconfinder_Sync_132655;
            this.btnUpdate.Location = new System.Drawing.Point(157, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(49, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRecord.Image = global::IndividualTask.Properties.Resources.iconfinder_Delete_1327461;
            this.btnDeleteRecord.Location = new System.Drawing.Point(205, 352);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(49, 34);
            this.btnDeleteRecord.TabIndex = 1;
            this.btnDeleteRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRecord.Image = global::IndividualTask.Properties.Resources.iconfinder_Create_132699;
            this.btnAddRecord.Location = new System.Drawing.Point(109, 352);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(49, 34);
            this.btnAddRecord.TabIndex = 1;
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // SysLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtModifiedOn);
            this.Controls.Add(this.lblModifiedOn);
            this.Controls.Add(this.dtCreatedOn);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.dgvLookup);
            this.Name = "SysLookupForm";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.SysLookupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOnAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedOnAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionAll;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.DateTimePicker dtCreatedOn;
        private System.Windows.Forms.Label lblModifiedOn;
        private System.Windows.Forms.DateTimePicker dtModifiedOn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button btnUpdate;
    }
}