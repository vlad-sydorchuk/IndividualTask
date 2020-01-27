namespace IndividualTask
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsMenuContact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSysLookup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btcDeleteRecord = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOnAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountInInvoiceInContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobInContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityInContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneInContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailInContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountInInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerInInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordInUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusInInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactInAccountInInvoiceInUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DbNameInSysLookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeInUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceInProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenu.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.mainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuContact,
            this.tsMenuAccount,
            this.tsMenuProduct,
            this.tsMenuInvoice,
            this.tsMenuSysLookup,
            this.tsMenuUser,
            this.tsMenuExit});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainMenu.Size = new System.Drawing.Size(196, 453);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tsMenuContact
            // 
            this.tsMenuContact.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tsMenuContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMenuContact.Margin = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.tsMenuContact.Name = "tsMenuContact";
            this.tsMenuContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsMenuContact.Size = new System.Drawing.Size(99, 28);
            this.tsMenuContact.Text = "Контакты";
            this.tsMenuContact.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsMenuContact.Click += new System.EventHandler(this.tsMenuContact_Click);
            // 
            // tsMenuAccount
            // 
            this.tsMenuAccount.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tsMenuAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMenuAccount.Name = "tsMenuAccount";
            this.tsMenuAccount.Size = new System.Drawing.Size(128, 28);
            this.tsMenuAccount.Text = "Контрагенты";
            this.tsMenuAccount.Click += new System.EventHandler(this.tsMenuAccount_Click);
            // 
            // tsMenuProduct
            // 
            this.tsMenuProduct.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tsMenuProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMenuProduct.Name = "tsMenuProduct";
            this.tsMenuProduct.Size = new System.Drawing.Size(104, 28);
            this.tsMenuProduct.Text = "Продукты";
            this.tsMenuProduct.Click += new System.EventHandler(this.tsMenuProduct_Click);
            // 
            // tsMenuInvoice
            // 
            this.tsMenuInvoice.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tsMenuInvoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMenuInvoice.Name = "tsMenuInvoice";
            this.tsMenuInvoice.Size = new System.Drawing.Size(68, 28);
            this.tsMenuInvoice.Text = "Счета";
            this.tsMenuInvoice.Click += new System.EventHandler(this.tsMenuInvoice_Click);
            // 
            // tsMenuSysLookup
            // 
            this.tsMenuSysLookup.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tsMenuSysLookup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMenuSysLookup.Name = "tsMenuSysLookup";
            this.tsMenuSysLookup.Size = new System.Drawing.Size(129, 28);
            this.tsMenuSysLookup.Text = "Справочники";
            this.tsMenuSysLookup.Click += new System.EventHandler(this.tsMenuSysLookup_Click);
            // 
            // tsMenuUser
            // 
            this.tsMenuUser.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tsMenuUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMenuUser.Name = "tsMenuUser";
            this.tsMenuUser.Size = new System.Drawing.Size(193, 28);
            this.tsMenuUser.Text = "Администрирование";
            this.tsMenuUser.Click += new System.EventHandler(this.tsMenuUser_Click);
            // 
            // tsMenuExit
            // 
            this.tsMenuExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMenuExit.Margin = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.tsMenuExit.Name = "tsMenuExit";
            this.tsMenuExit.Size = new System.Drawing.Size(69, 24);
            this.tsMenuExit.Text = "Выйти";
            this.tsMenuExit.Click += new System.EventHandler(this.tsMenuExit_Click);
            // 
            // dgvSection
            // 
            this.dgvSection.AllowUserToAddRows = false;
            this.dgvSection.AllowUserToDeleteRows = false;
            this.dgvSection.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CreatedOnAll,
            this.NameAll,
            this.AccountInInvoiceInContract,
            this.JobInContact,
            this.CityInContact,
            this.PhoneInContact,
            this.EmailInContact,
            this.AmountInInvoice,
            this.OwnerInInvoice,
            this.PasswordInUser,
            this.StatusInInvoice,
            this.ContactInAccountInInvoiceInUser,
            this.DbNameInSysLookup,
            this.TypeInUser,
            this.PriceInProduct});
            this.dgvSection.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSection.Location = new System.Drawing.Point(240, 57);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.ReadOnly = true;
            this.dgvSection.RowTemplate.Height = 24;
            this.dgvSection.Size = new System.Drawing.Size(680, 381);
            this.dgvSection.TabIndex = 1;
            this.dgvSection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSection_CellClick);
            this.dgvSection.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSection_CellMouseDoubleClick);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(240, 12);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(97, 34);
            this.btnAddRecord.TabIndex = 2;
            this.btnAddRecord.Text = "Добавить";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(343, 12);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(97, 34);
            this.btnEditRecord.TabIndex = 2;
            this.btnEditRecord.Text = "Изменить";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btcDeleteRecord
            // 
            this.btcDeleteRecord.Location = new System.Drawing.Point(446, 12);
            this.btcDeleteRecord.Name = "btcDeleteRecord";
            this.btcDeleteRecord.Size = new System.Drawing.Size(97, 34);
            this.btcDeleteRecord.TabIndex = 2;
            this.btcDeleteRecord.Text = "Удалить";
            this.btcDeleteRecord.UseVisualStyleBackColor = true;
            this.btcDeleteRecord.Click += new System.EventHandler(this.btcDeleteRecord_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CreatedOnAll.DefaultCellStyle = dataGridViewCellStyle1;
            this.CreatedOnAll.HeaderText = "Дата создания";
            this.CreatedOnAll.Name = "CreatedOnAll";
            this.CreatedOnAll.ReadOnly = true;
            // 
            // NameAll
            // 
            this.NameAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameAll.DataPropertyName = "Name";
            this.NameAll.HeaderText = "Название";
            this.NameAll.Name = "NameAll";
            this.NameAll.ReadOnly = true;
            // 
            // AccountInInvoiceInContract
            // 
            this.AccountInInvoiceInContract.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountInInvoiceInContract.DataPropertyName = "Account";
            this.AccountInInvoiceInContract.HeaderText = "Контрагент";
            this.AccountInInvoiceInContract.Name = "AccountInInvoiceInContract";
            this.AccountInInvoiceInContract.ReadOnly = true;
            // 
            // JobInContact
            // 
            this.JobInContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobInContact.DataPropertyName = "Job";
            this.JobInContact.HeaderText = "Должность";
            this.JobInContact.Name = "JobInContact";
            this.JobInContact.ReadOnly = true;
            // 
            // CityInContact
            // 
            this.CityInContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CityInContact.DataPropertyName = "City";
            this.CityInContact.HeaderText = "Город";
            this.CityInContact.Name = "CityInContact";
            this.CityInContact.ReadOnly = true;
            // 
            // PhoneInContact
            // 
            this.PhoneInContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneInContact.DataPropertyName = "Phone";
            this.PhoneInContact.HeaderText = "Телефон";
            this.PhoneInContact.Name = "PhoneInContact";
            this.PhoneInContact.ReadOnly = true;
            // 
            // EmailInContact
            // 
            this.EmailInContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailInContact.DataPropertyName = "Email";
            this.EmailInContact.HeaderText = "Email";
            this.EmailInContact.Name = "EmailInContact";
            this.EmailInContact.ReadOnly = true;
            // 
            // AmountInInvoice
            // 
            this.AmountInInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountInInvoice.DataPropertyName = "Amount";
            this.AmountInInvoice.HeaderText = "Итого";
            this.AmountInInvoice.Name = "AmountInInvoice";
            this.AmountInInvoice.ReadOnly = true;
            // 
            // OwnerInInvoice
            // 
            this.OwnerInInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OwnerInInvoice.DataPropertyName = "Owner";
            this.OwnerInInvoice.HeaderText = "Ответственный";
            this.OwnerInInvoice.Name = "OwnerInInvoice";
            this.OwnerInInvoice.ReadOnly = true;
            // 
            // PasswordInUser
            // 
            this.PasswordInUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PasswordInUser.DataPropertyName = "Password";
            this.PasswordInUser.HeaderText = "Пароль";
            this.PasswordInUser.Name = "PasswordInUser";
            this.PasswordInUser.ReadOnly = true;
            // 
            // StatusInInvoice
            // 
            this.StatusInInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusInInvoice.DataPropertyName = "Status";
            this.StatusInInvoice.HeaderText = "Статус";
            this.StatusInInvoice.Name = "StatusInInvoice";
            this.StatusInInvoice.ReadOnly = true;
            // 
            // ContactInAccountInInvoiceInUser
            // 
            this.ContactInAccountInInvoiceInUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactInAccountInInvoiceInUser.DataPropertyName = "Contact";
            this.ContactInAccountInInvoiceInUser.HeaderText = "Контакт";
            this.ContactInAccountInInvoiceInUser.Name = "ContactInAccountInInvoiceInUser";
            this.ContactInAccountInInvoiceInUser.ReadOnly = true;
            // 
            // DbNameInSysLookup
            // 
            this.DbNameInSysLookup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DbNameInSysLookup.DataPropertyName = "DbName";
            this.DbNameInSysLookup.HeaderText = "Название в БД";
            this.DbNameInSysLookup.Name = "DbNameInSysLookup";
            this.DbNameInSysLookup.ReadOnly = true;
            // 
            // TypeInUser
            // 
            this.TypeInUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeInUser.DataPropertyName = "Type";
            this.TypeInUser.HeaderText = "Тип";
            this.TypeInUser.Name = "TypeInUser";
            this.TypeInUser.ReadOnly = true;
            // 
            // PriceInProduct
            // 
            this.PriceInProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceInProduct.DataPropertyName = "Price";
            this.PriceInProduct.HeaderText = "Цена";
            this.PriceInProduct.Name = "PriceInProduct";
            this.PriceInProduct.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IndividualTask.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.btcDeleteRecord);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.dgvSection);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Главная страница";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsMenuContact;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAccount;
        private System.Windows.Forms.ToolStripMenuItem tsMenuProduct;
        private System.Windows.Forms.ToolStripMenuItem tsMenuInvoice;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.DataGridView dgvSection;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSysLookup;
        private System.Windows.Forms.ToolStripMenuItem tsMenuUser;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExit;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btcDeleteRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOnAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountInInvoiceInContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobInContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityInContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneInContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailInContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountInInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerInInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordInUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusInInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactInAccountInInvoiceInUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DbNameInSysLookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeInUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceInProduct;
    }
}