namespace IndividualTask
{
    partial class InvoiceForm
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
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.dtModifiedOn = new System.Windows.Forms.DateTimePicker();
            this.dtCreatedOn = new System.Windows.Forms.DateTimePicker();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblModifiedOn = new System.Windows.Forms.Label();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblDescriprion = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btcCancel
            // 
            this.btcCancel.BackColor = System.Drawing.Color.Transparent;
            this.btcCancel.Image = global::IndividualTask.Properties.Resources.iconfinder_Delete_1327461;
            this.btcCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcCancel.Location = new System.Drawing.Point(577, 307);
            this.btcCancel.Name = "btcCancel";
            this.btcCancel.Size = new System.Drawing.Size(90, 36);
            this.btcCancel.TabIndex = 25;
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
            this.btcSave.Location = new System.Drawing.Point(459, 306);
            this.btcSave.Name = "btcSave";
            this.btcSave.Size = new System.Drawing.Size(112, 36);
            this.btcSave.TabIndex = 24;
            this.btcSave.Text = "Сохранить";
            this.btcSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcSave.UseVisualStyleBackColor = false;
            this.btcSave.Click += new System.EventHandler(this.btcSave_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(15, 76);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(308, 80);
            this.rtxtDescription.TabIndex = 23;
            this.rtxtDescription.Text = "";
            // 
            // dtModifiedOn
            // 
            this.dtModifiedOn.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtModifiedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtModifiedOn.Location = new System.Drawing.Point(359, 122);
            this.dtModifiedOn.Name = "dtModifiedOn";
            this.dtModifiedOn.Size = new System.Drawing.Size(308, 22);
            this.dtModifiedOn.TabIndex = 22;
            // 
            // dtCreatedOn
            // 
            this.dtCreatedOn.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtCreatedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatedOn.Location = new System.Drawing.Point(359, 76);
            this.dtCreatedOn.Name = "dtCreatedOn";
            this.dtCreatedOn.Size = new System.Drawing.Size(308, 22);
            this.dtCreatedOn.TabIndex = 21;
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(15, 272);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(308, 24);
            this.cmbContact.TabIndex = 20;
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(15, 225);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(308, 24);
            this.cmbAccount.TabIndex = 19;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(15, 180);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(308, 22);
            this.txtAmount.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 22);
            this.txtName.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(359, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(308, 22);
            this.txtId.TabIndex = 15;
            // 
            // lblModifiedOn
            // 
            this.lblModifiedOn.AutoSize = true;
            this.lblModifiedOn.Location = new System.Drawing.Point(356, 101);
            this.lblModifiedOn.Name = "lblModifiedOn";
            this.lblModifiedOn.Size = new System.Drawing.Size(118, 17);
            this.lblModifiedOn.TabIndex = 13;
            this.lblModifiedOn.Text = "Дата изменения";
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.AutoSize = true;
            this.lblCreatedOn.Location = new System.Drawing.Point(356, 55);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(108, 17);
            this.lblCreatedOn.TabIndex = 12;
            this.lblCreatedOn.Text = "Дата создания";
            // 
            // lblDescriprion
            // 
            this.lblDescriprion.AutoSize = true;
            this.lblDescriprion.Location = new System.Drawing.Point(12, 55);
            this.lblDescriprion.Name = "lblDescriprion";
            this.lblDescriprion.Size = new System.Drawing.Size(74, 17);
            this.lblDescriprion.TabIndex = 11;
            this.lblDescriprion.Text = "Описание";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 159);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 17);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Сумма";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(12, 252);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(62, 17);
            this.lblContact.TabIndex = 8;
            this.lblContact.Text = "Контакт";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(12, 205);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(84, 17);
            this.lblAccount.TabIndex = 7;
            this.lblAccount.Text = "Контрагент";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Название";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(356, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(356, 159);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(12, 299);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(111, 17);
            this.lblOwner.TabIndex = 8;
            this.lblOwner.Text = "Ответственный";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(359, 179);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(308, 24);
            this.cmbStatus.TabIndex = 19;
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(15, 319);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(308, 24);
            this.cmbOwner.TabIndex = 20;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 355);
            this.Controls.Add(this.btcCancel);
            this.Controls.Add(this.btcSave);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.dtModifiedOn);
            this.Controls.Add(this.dtCreatedOn);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.cmbContact);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblModifiedOn);
            this.Controls.Add(this.lblCreatedOn);
            this.Controls.Add(this.lblDescriprion);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "InvoiceForm";
            this.ShowIcon = false;
            this.Text = "Счет";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcCancel;
        private System.Windows.Forms.Button btcSave;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.DateTimePicker dtModifiedOn;
        private System.Windows.Forms.DateTimePicker dtCreatedOn;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblModifiedOn;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblDescriprion;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbOwner;
    }
}