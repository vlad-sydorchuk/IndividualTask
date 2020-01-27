namespace IndividualTask
{
    partial class AdminForm
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
            this.btcCancel = new System.Windows.Forms.Button();
            this.btcSave = new System.Windows.Forms.Button();
            this.dtModifiedOn = new System.Windows.Forms.DateTimePicker();
            this.dtCreatedOn = new System.Windows.Forms.DateTimePicker();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblModifiedOn = new System.Windows.Forms.Label();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btcCancel
            // 
            this.btcCancel.BackColor = System.Drawing.Color.Transparent;
            this.btcCancel.Image = global::IndividualTask.Properties.Resources.iconfinder_Delete_1327461;
            this.btcCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcCancel.Location = new System.Drawing.Point(577, 156);
            this.btcCancel.Name = "btcCancel";
            this.btcCancel.Size = new System.Drawing.Size(90, 36);
            this.btcCancel.TabIndex = 47;
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
            this.btcSave.Location = new System.Drawing.Point(459, 155);
            this.btcSave.Name = "btcSave";
            this.btcSave.Size = new System.Drawing.Size(112, 36);
            this.btcSave.TabIndex = 46;
            this.btcSave.Text = "Сохранить";
            this.btcSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcSave.UseVisualStyleBackColor = false;
            this.btcSave.Click += new System.EventHandler(this.btcSave_Click);
            // 
            // dtModifiedOn
            // 
            this.dtModifiedOn.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtModifiedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtModifiedOn.Location = new System.Drawing.Point(359, 122);
            this.dtModifiedOn.Name = "dtModifiedOn";
            this.dtModifiedOn.Size = new System.Drawing.Size(308, 22);
            this.dtModifiedOn.TabIndex = 44;
            // 
            // dtCreatedOn
            // 
            this.dtCreatedOn.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtCreatedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatedOn.Location = new System.Drawing.Point(359, 76);
            this.dtCreatedOn.Name = "dtCreatedOn";
            this.dtCreatedOn.Size = new System.Drawing.Size(308, 22);
            this.dtCreatedOn.TabIndex = 43;
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(15, 121);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(308, 24);
            this.cmbContact.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 22);
            this.txtName.TabIndex = 37;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(359, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(308, 22);
            this.txtId.TabIndex = 36;
            // 
            // lblModifiedOn
            // 
            this.lblModifiedOn.AutoSize = true;
            this.lblModifiedOn.Location = new System.Drawing.Point(356, 101);
            this.lblModifiedOn.Name = "lblModifiedOn";
            this.lblModifiedOn.Size = new System.Drawing.Size(118, 17);
            this.lblModifiedOn.TabIndex = 34;
            this.lblModifiedOn.Text = "Дата изменения";
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Location = new System.Drawing.Point(356, 55);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(108, 17);
            this.lblCreatedOn.TabIndex = 33;
            this.lblCreatedOn.Text = "Дата создания";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(12, 101);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(62, 17);
            this.lblContact.TabIndex = 29;
            this.lblContact.Text = "Контакт";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 35;
            this.lblLogin.Text = "Логин";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(356, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "Id";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 55);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 17);
            this.lblPassword.TabIndex = 35;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 22);
            this.txtPassword.TabIndex = 37;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 148);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 17);
            this.lblType.TabIndex = 29;
            this.lblType.Text = "Тип";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(15, 168);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(308, 24);
            this.cmbType.TabIndex = 41;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 203);
            this.Controls.Add(this.btcCancel);
            this.Controls.Add(this.btcSave);
            this.Controls.Add(this.dtModifiedOn);
            this.Controls.Add(this.dtCreatedOn);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbContact);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblModifiedOn);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblId);
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcCancel;
        private System.Windows.Forms.Button btcSave;
        private System.Windows.Forms.DateTimePicker dtModifiedOn;
        private System.Windows.Forms.DateTimePicker dtCreatedOn;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblModifiedOn;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
    }
}