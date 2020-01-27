using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTask
{
    public partial class AccountForm : Form
    {
        Form Form { get; set; }
        User User { get; set; }
        string Id { get; set; }

        public AccountForm(Form form, User user, string id = null)
        {
            InitializeComponent();

            Form = form;
            User = user;
            Id = id;
        }

        private void btcSave_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                Account account = new Account();

                if (!string.IsNullOrWhiteSpace(Id))
                {
                    account = db.Account.Where(x => x.Id == new Guid(Id)).FirstOrDefault();
                }

                account.Id = new Guid(txtId.Text);
                account.CreatedOn = dtCreatedOn.Value;
                account.ModifiedOn = DateTime.Now;
                account.Name = txtName.Text;
                account.Description = rtxtDescription.Text;
                account.PrimaryContactId = ((Lookup)cmbContact.SelectedValue)?.Id;

                if (string.IsNullOrWhiteSpace(Id))
                {
                    db.Account.Add(account);
                }
                else
                {
                    db.Entry(account).State = EntityState.Modified;
                }

                db.SaveChanges();

                if (MessageBox.Show("Данные сохранены!", "Сохранено", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                    ((MainForm)Form).UpdateGrid();
                }
            }
        }

        private void btcCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                var contacts = db.Contact.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();

                cmbContact.DataSource = contacts;
                cmbContact.SelectedIndex = -1;

                // Add mode
                if (string.IsNullOrWhiteSpace(Id))
                {
                    txtId.Text = Guid.NewGuid().ToString().ToLower();
                }
                // Modify mode
                else
                {
                    var account = db.Account.Where(x => x.Id == new Guid(Id)).FirstOrDefault();

                    if (account != null)
                    {
                        txtId.Text = account.Id.ToString();
                        txtName.Text = account.Name;
                        dtModifiedOn.Value = DateTime.Now;
                        dtCreatedOn.Value = (DateTime)account.CreatedOn;
                        rtxtDescription.Text = account.Description;

                        var pcId = account.PrimaryContactId;
                        if (pcId != null)
                        {
                            cmbContact.SelectedIndex = contacts.Select(x => x.Id).ToList().IndexOf((Guid)account.PrimaryContactId);
                        }
                    }
                }
            }
        }

        public static void Delete(string id)
        {
            using (DBEntities db = new DBEntities())
            {
                var account = db.Account.Where(x => x.Id == new Guid(id)).FirstOrDefault();
                if (account != null)
                {
                    db.Account.Attach(account);
                    db.Account.Remove(account);
                }
                db.SaveChanges();
            }
        }
    }
}
