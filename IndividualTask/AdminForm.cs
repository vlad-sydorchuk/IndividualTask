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
    public partial class AdminForm : Form
    {
        Form Form { get; set; }
        User User { get; set; }
        string Id { get; set; }

        public AdminForm(Form form, User user, string id = null)
        {
            InitializeComponent();

            Form = form;
            User = user;
            Id = id;
        }

        public static void Delete(string id)
        {
            using (DBEntities db = new DBEntities())
            {
                var user = db.User.Where(x => x.Id == new Guid(id)).FirstOrDefault();
                if (user != null)
                {
                    db.User.Attach(user);
                    db.User.Remove(user);
                }
                db.SaveChanges();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                var contacts = db.Contact.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();
                var types = db.UserType.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();

                cmbContact.DataSource = contacts;
                cmbType.DataSource = types;
                
                // Add mode
                if (string.IsNullOrWhiteSpace(Id))
                {
                    cmbContact.SelectedIndex = -1;
                    cmbType.SelectedIndex = -1;

                    txtId.Text = Guid.NewGuid().ToString().ToLower();
                }
                // Modify mode
                else
                {
                    var user = db.User.Where(x => x.Id == new Guid(Id)).FirstOrDefault();

                    if (user != null)
                    {
                        txtId.Text = user.Id.ToString();
                        txtName.Text = user.Login;
                        txtPassword.Text = user.Password;
                        dtModifiedOn.Value = DateTime.Now;
                        dtCreatedOn.Value = (DateTime)user.CreatedOn;

                        var contactId = user.ContactId;
                        var typeId = user.TypeId;

                        if (contactId != null)
                        {
                            cmbContact.SelectedIndex = contacts.Select(x => x.Id).ToList().IndexOf((Guid)contactId);
                        }

                        if (typeId != null)
                        {
                            cmbType.SelectedIndex = types.Select(x => x.Id).ToList().IndexOf((Guid)typeId);
                        }
                    }
                }
            }
        }

        private void btcSave_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                User user = new User();

                if (!string.IsNullOrWhiteSpace(Id))
                {
                    user = db.User.Where(x => x.Id == new Guid(Id)).FirstOrDefault();
                }

                user.Id = new Guid(txtId.Text);
                user.CreatedOn = dtCreatedOn.Value;
                user.ModifiedOn = DateTime.Now;
                user.Login = txtName.Text;
                user.Password = txtPassword.Text;

                var contactId = ((Lookup)cmbContact.SelectedValue)?.Id;
                var typeId = ((Lookup)cmbType.SelectedValue)?.Id;

                if (contactId != null)
                {
                    user.ContactId = (Guid)contactId;
                }
                if (typeId != null)
                {
                    user.TypeId = (Guid)typeId;
                }

                if (string.IsNullOrWhiteSpace(Id))
                {
                    db.User.Add(user);
                }
                else
                {
                    db.Entry(user).State = EntityState.Modified;
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
