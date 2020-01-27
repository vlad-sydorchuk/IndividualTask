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
    public partial class ProductForm : Form
    {
        Form Form { get; set; }
        User User { get; set; }
        string Id { get; set; }

        public ProductForm(Form form, User user, string id = null)
        {
            InitializeComponent();

            Form = form;
            User = user;
            Id = id;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                // Add mode
                if (string.IsNullOrWhiteSpace(Id))
                {
                    txtId.Text = Guid.NewGuid().ToString().ToLower();
                }
                // Modify mode
                else
                {
                    var product = db.Product.Where(x => x.Id == new Guid(Id)).FirstOrDefault();

                    if (product != null)
                    {
                        txtId.Text = product.Id.ToString();
                        txtName.Text = product.Name;
                        dtModifiedOn.Value = DateTime.Now;
                        dtCreatedOn.Value = (DateTime)product.CreatedOn;
                        rtxtDescription.Text = product.Description;
                        txtPrice.Text = product.Price.ToString();
                    }
                }
            }
        }

        private void btcSave_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                Product product = new Product();

                if (!string.IsNullOrWhiteSpace(Id))
                {
                    product = db.Product.Where(x => x.Id == new Guid(Id)).FirstOrDefault();
                }

                product.Id = new Guid(txtId.Text);
                product.CreatedOn = dtCreatedOn.Value;
                product.ModifiedOn = DateTime.Now;
                product.Name = txtName.Text;
                product.Description = rtxtDescription.Text;
                product.Price = Convert.ToDecimal(txtPrice.Text);

                if (string.IsNullOrWhiteSpace(Id))
                {
                    db.Product.Add(product);
                }
                else
                {
                    db.Entry(product).State = EntityState.Modified;
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

        public static void Delete(string id)
        {
            using (DBEntities db = new DBEntities())
            {
                var product = db.Product.Where(x => x.Id == new Guid(id)).FirstOrDefault();
                if (product != null)
                {
                    db.Product.Attach(product);
                    db.Product.Remove(product);
                }
                db.SaveChanges();
            }
        }
    }
}
