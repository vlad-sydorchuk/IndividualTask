namespace IndividualTask
{
    partial class ContactForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.dtCreatedOn = new System.Windows.Forms.DateTimePicker();
            this.lblModifiedOn = new System.Windows.Forms.Label();
            this.dtModifiedOn = new System.Windows.Forms.DateTimePicker();
            this.lblDescriprion = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btcCancel = new System.Windows.Forms.Button();
            this.btcSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(356, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(359, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(308, 22);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(15, 275);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(308, 24);
            this.cmbJob.TabIndex = 2;
            this.cmbJob.SelectedIndexChanged += new System.EventHandler(this.cmbJob_SelectedIndexChanged);
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Location = new System.Drawing.Point(356, 59);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(108, 17);
            this.lblCreatedOn.TabIndex = 0;
            this.lblCreatedOn.Text = "Дата создания";
            this.lblCreatedOn.Click += new System.EventHandler(this.lblCreatedOn_Click);
            // 
            // dtCreatedOn
            // 
            this.dtCreatedOn.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtCreatedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatedOn.Location = new System.Drawing.Point(359, 80);
            this.dtCreatedOn.Name = "dtCreatedOn";
            this.dtCreatedOn.Size = new System.Drawing.Size(308, 22);
            this.dtCreatedOn.TabIndex = 3;
            this.dtCreatedOn.ValueChanged += new System.EventHandler(this.dtCreatedOn_ValueChanged);
            // 
            // lblModifiedOn
            // 
            this.lblModifiedOn.AutoSize = true;
            this.lblModifiedOn.Location = new System.Drawing.Point(356, 105);
            this.lblModifiedOn.Name = "lblModifiedOn";
            this.lblModifiedOn.Size = new System.Drawing.Size(118, 17);
            this.lblModifiedOn.TabIndex = 0;
            this.lblModifiedOn.Text = "Дата изменения";
            this.lblModifiedOn.Click += new System.EventHandler(this.lblModifiedOn_Click);
            // 
            // dtModifiedOn
            // 
            this.dtModifiedOn.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtModifiedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtModifiedOn.Location = new System.Drawing.Point(359, 126);
            this.dtModifiedOn.Name = "dtModifiedOn";
            this.dtModifiedOn.Size = new System.Drawing.Size(308, 22);
            this.dtModifiedOn.TabIndex = 3;
            this.dtModifiedOn.ValueChanged += new System.EventHandler(this.dtModifiedOn_ValueChanged);
            // 
            // lblDescriprion
            // 
            this.lblDescriprion.AutoSize = true;
            this.lblDescriprion.Location = new System.Drawing.Point(12, 59);
            this.lblDescriprion.Name = "lblDescriprion";
            this.lblDescriprion.Size = new System.Drawing.Size(74, 17);
            this.lblDescriprion.TabIndex = 0;
            this.lblDescriprion.Text = "Описание";
            this.lblDescriprion.Click += new System.EventHandler(this.lblDescriprion_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(15, 80);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(308, 80);
            this.rtxtDescription.TabIndex = 4;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.TextChanged += new System.EventHandler(this.rtxtDescription_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 163);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(68, 17);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Телефон";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 184);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(308, 22);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(12, 255);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(81, 17);
            this.lblJob.TabIndex = 0;
            this.lblJob.Text = "Должность";
            this.lblJob.Click += new System.EventHandler(this.lblJob_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 302);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(48, 17);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Город";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(15, 322);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(308, 24);
            this.cmbCity.TabIndex = 2;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // btcCancel
            // 
            this.btcCancel.BackColor = System.Drawing.Color.Transparent;
            this.btcCancel.Image = global::IndividualTask.Properties.Resources.iconfinder_Delete_1327461;
            this.btcCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcCancel.Location = new System.Drawing.Point(577, 315);
            this.btcCancel.Name = "btcCancel";
            this.btcCancel.Size = new System.Drawing.Size(90, 36);
            this.btcCancel.TabIndex = 5;
            this.btcCancel.Text = "Отмена";
            this.btcCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcCancel.UseVisualStyleBackColor = false;
            this.btcCancel.Click += new System.EventHandler(this.btcCancel_Click);
            // 
            // btcSave
            // 
            this.btcSave.BackColor = System.Drawing.Color.Transparent;
            this.btcSave.Image = global::IndividualTask.Properties.Resources.iconfinder_Yes_132693;
            this.btcSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcSave.Location = new System.Drawing.Point(459, 315);
            this.btcSave.Name = "btcSave";
            this.btcSave.Size = new System.Drawing.Size(112, 36);
            this.btcSave.TabIndex = 5;
            this.btcSave.Text = "Сохранить";
            this.btcSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcSave.UseVisualStyleBackColor = false;
            this.btcSave.Click += new System.EventHandler(this.btcSave_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 357);
            this.Controls.Add(this.btcCancel);
            this.Controls.Add(this.btcSave);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.dtModifiedOn);
            this.Controls.Add(this.dtCreatedOn);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblModifiedOn);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.lblDescriprion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.Text = "Контакт";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.DateTimePicker dtCreatedOn;
        private System.Windows.Forms.Label lblModifiedOn;
        private System.Windows.Forms.DateTimePicker dtModifiedOn;
        private System.Windows.Forms.Label lblDescriprion;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btcSave;
        private System.Windows.Forms.Button btcCancel;
    }
}