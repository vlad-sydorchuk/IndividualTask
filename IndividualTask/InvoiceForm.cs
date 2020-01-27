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
    public partial class InvoiceForm : Form
    {
        Form Form { get; set; }
        User User { get; set; }
        string Id { get; set; }

        public InvoiceForm(Form form, User user, string id = null)
        {
            InitializeComponent();

            Form = form;
            User = user;
            Id = id;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                var contacts = db.Contact.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();
                var owners = db.Contact.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();
                var acounts = db.Account.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();
                var statuses = db.InvoiceStatus.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();

                cmbAccount.DataSource = acounts;
                cmbContact.DataSource = contacts;
                cmbOwner.DataSource = owners;
                cmbStatus.DataSource = statuses;

                // Add mode
                if (string.IsNullOrWhiteSpace(Id))
                {
                    cmbAccount.SelectedIndex = -1;
                    cmbContact.SelectedIndex = -1;
                    cmbOwner.SelectedIndex = -1;
                    cmbStatus.SelectedIndex = -1;

                    txtId.Text = Guid.NewGuid().ToString().ToLower();
                }
                // Modify mode
                else
                {
                    var invoice = db.Invoice.Where(x => x.Id == new Guid(Id)).FirstOrDefault();

                    if (invoice != null)
                    {
                        txtId.Text = invoice.Id.ToString();
                        txtName.Text = invoice.Name;
                        dtModifiedOn.Value = DateTime.Now;
                        dtCreatedOn.Value = (DateTime)invoice.CreatedOn;
                        txtAmount.Text = invoice.Amount.ToString();
                        rtxtDescription.Text = invoice.Description;

                        var accountId = invoice.AccountId;
                        var contactId = invoice.ContactId;
                        var ownerId = invoice.OwnerId;
                        var statusId = invoice.StatusId;

                        if (accountId != Guid.Empty)
                        {
                            cmbAccount.SelectedIndex = acounts.Select(x => x.Id).ToList().IndexOf(accountId);
                        }

                        if (contactId != Guid.Empty)
                        {
                            cmbContact.SelectedIndex = contacts.Select(x => x.Id).ToList().IndexOf(contactId);
                        }

                        if (ownerId != Guid.Empty)
                        {
                            cmbOwner.SelectedIndex = owners.Select(x => x.Id).ToList().IndexOf((Guid)ownerId);
                        }

                        if (statusId != Guid.Empty)
                        {
                            cmbStatus.SelectedIndex = statuses.Select(x => x.Id).ToList().IndexOf((Guid)statusId);
                        }
                    }
                }
            }
        }

        public static void Delete(string id)
        {
            using (DBEntities db = new DBEntities())
            {
                var invoice = db.Invoice.Where(x => x.Id == new Guid(id)).FirstOrDefault();
                if (invoice != null)
                {
                    db.Invoice.Attach(invoice);
                    db.Invoice.Remove(invoice);
                }
                db.SaveChanges();
            }
        }

        private void btcSave_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                Invoice invoice = new Invoice();

                if (!string.IsNullOrWhiteSpace(Id))
                {
                    invoice = db.Invoice.Where(x => x.Id == new Guid(Id)).FirstOrDefault();
                }

                invoice.Id = new Guid(txtId.Text);
                invoice.CreatedOn = dtCreatedOn.Value;
                invoice.ModifiedOn = DateTime.Now;
                invoice.Name = txtName.Text;
                invoice.Description = rtxtDescription.Text;

                var accountId = ((Lookup)cmbAccount.SelectedValue)?.Id;
                var contactId = ((Lookup)cmbContact.SelectedValue)?.Id;
                var ownerId = ((Lookup)cmbOwner.SelectedValue)?.Id;
                var statusId = ((Lookup)cmbStatus.SelectedValue)?.Id;

                if (accountId != null)
                {
                    invoice.AccountId = (Guid)accountId;
                }
                if (contactId != null)
                {
                    invoice.ContactId = (Guid)contactId;
                }
                if (ownerId != null)
                {
                    invoice.OwnerId = (Guid)ownerId;
                }
                if (statusId != null)
                {
                    invoice.StatusId = (Guid)statusId;
                }

                if (string.IsNullOrWhiteSpace(Id))
                {
                    db.Invoice.Add(invoice);
                }
                else
                {
                    db.Entry(invoice).State = EntityState.Modified;
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
    }
}
