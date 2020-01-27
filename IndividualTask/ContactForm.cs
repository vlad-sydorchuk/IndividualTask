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
    public partial class ContactForm : Form
    {
        Form Form { get; set; }
        User User { get; set; }
        string Id { get; set; }

        public ContactForm(Form form, User user, string id = null)
        {
            InitializeComponent();

            Form = form;
            User = user;
            Id = id;
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                var jobs = db.Job.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();
                var cities = db.City.Select(x => new Lookup() { Id = x.Id, DisplayValue = x.Name }).ToList();

                cmbJob.DataSource = jobs;
                cmbCity.DataSource = cities;

                // Add mode
                if (string.IsNullOrWhiteSpace(Id))
                {
                    cmbJob.SelectedIndex = -1;
                    cmbCity.SelectedIndex = -1;
                    txtId.Text = Guid.NewGuid().ToString().ToLower();
                }
                // Modify mode
                else 
                {
                    var contact = db.Contact.Where(x => x.Id == new Guid(Id)).FirstOrDefault();

                    if (contact != null)
                    {
                        txtId.Text = contact.Id.ToString();
                        txtName.Text = contact.Name;
                        dtModifiedOn.Value = DateTime.Now;
                        dtCreatedOn.Value = (DateTime)contact.CreatedOn;
                        txtPhone.Text = contact.Phone;
                        txtEmail.Text = contact.Email;
                        rtxtDescription.Text = contact.Description;

                        cmbJob.SelectedIndex = jobs.Select(x => x.Id).ToList().IndexOf((Guid)contact.JobId);
                        cmbCity.SelectedIndex = cities.Select(x => x.Id).ToList().IndexOf((Guid)contact.CityId);
                    }
                }
            }
        }

        private void btcSave_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                Contact contact = new Contact();

                if (!string.IsNullOrWhiteSpace(Id))
                {
                    contact = db.Contact.Where(x => x.Id == new Guid(Id)).FirstOrDefault();
                }

                contact.Id = new Guid(txtId.Text);
                contact.CreatedOn = dtCreatedOn.Value;
                contact.ModifiedOn = DateTime.Now;
                contact.Name = txtName.Text;
                contact.Description = rtxtDescription.Text;
                contact.Phone = txtPhone.Text;
                contact.Email = txtEmail.Text;
                contact.JobId = ((Lookup)cmbJob.SelectedValue)?.Id;
                contact.CityId = ((Lookup)cmbCity.SelectedValue)?.Id;

                if (string.IsNullOrWhiteSpace(Id))
                {
                    db.Contact.Add(contact);
                }
                else
                {
                    db.Entry(contact).State = EntityState.Modified;
                }

                db.SaveChanges();

                if (MessageBox.Show("Данные сохранены!", "Сохранено", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                    ((MainForm)Form).UpdateGrid();
                }
            }
        }

        public static void Delete(string id)
        {
            using (DBEntities db = new DBEntities())
            {
                var contact = db.Contact.Where(x => x.Id == new Guid(id)).FirstOrDefault();
                if (contact != null)
                {
                    db.Contact.Attach(contact);
                    db.Contact.Remove(contact);
                }
                db.SaveChanges();
            }
        }

        private void btcCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCreatedOn_Click(object sender, EventArgs e)
        {

        }

        private void dtCreatedOn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblModifiedOn_Click(object sender, EventArgs e)
        {

        }

        private void dtModifiedOn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDescriprion_Click(object sender, EventArgs e)
        {

        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblJob_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
