using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndividualTask.DataGridViewHelper;

namespace IndividualTask
{
    public partial class MainForm : Form
    {
        Form Form { get; set; }
        User User { get; set; }
        object CurrentMenuItem { get; set; }

        public MainForm(AuthorizeForm authorizeForm, User user)
        {
            InitializeComponent();
            Form = authorizeForm;
            User = user;

            dgvSection.AutoGenerateColumns = false;
            tsMenuContact_Click(tsMenuContact, null); // Чтобы изначально заполнить грид
        }

        private void tsMenuExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверенны, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form.Visible = true;
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Visible = true;
        }

        private void tsMenuContact_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
            using (DBEntities db = new DBEntities())
            {
                ColumnHelper.ChangeDataGridViewColumnVisible(dgvSection, "InContact");
                dgvSection.DataSource = db.Contact.Select(x => new {
                    x.Id,
                    x.CreatedOn,
                    x.Name,
                    City = x.City.Name,
                    Account = x.Account.FirstOrDefault().Name,
                    Job = x.Job.Name,
                    x.Phone,
                    x.Email
                }).ToList();
            }
        }

        private void tsMenuAccount_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
            using (DBEntities db = new DBEntities())
            {
                ColumnHelper.ChangeDataGridViewColumnVisible(dgvSection, "InAccount");
                dgvSection.DataSource = db.Account.Select(x => new {
                    x.Id,
                    x.CreatedOn,
                    x.Name,
                    Contact = x.Contact.Name
                }).ToList();
            }
        }

        private void tsMenuProduct_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
            using (DBEntities db = new DBEntities())
            {
                ColumnHelper.ChangeDataGridViewColumnVisible(dgvSection);
                dgvSection.DataSource = db.Product.ToList();
            }
        }

        private void tsMenuInvoice_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
            using (DBEntities db = new DBEntities())
            {
                ColumnHelper.ChangeDataGridViewColumnVisible(dgvSection, "InInvoice");
                dgvSection.DataSource = db.Invoice.Select(x => new {
                    x.Id,
                    x.CreatedOn,
                    x.Name,
                    Account = x.Account.Name,
                    Contact = x.Contact.Name,
                    x.Amount,
                    Owner = x.ContactOwner.Name,
                    Status = x.InvoiceStatus.Name
                }).ToList();
            }
        }

        private void menuItemChanged(object sender)
        {
            CurrentMenuItem = sender;
            changeSelectedSectionFont(sender);
        }

        private void changeSelectedSectionFont(object sender)
        {
            foreach (ToolStripMenuItem item in mainMenu.Items)
            {
                item.Font = new Font(item.Font, ((ToolStripMenuItem)sender)?.Name == item.Name ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void tsMenuLookup_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
            using (DBEntities db = new DBEntities())
            {
                ColumnHelper.ChangeDataGridViewColumnVisible(dgvSection, "InSysLookup");
                dgvSection.DataSource = db.SysLookup.Select(x => new {
                    x.Id,
                    x.CreatedOn,
                    x.Name,
                    x.DbName
                }).ToList();
            }
        }

        private void tsMenuAdministration_Click(object sender, EventArgs e)
        {
            if (User?.TypeId != UserTypeHelper.AdminTypeId)
            {
                MessageBox.Show("У Вас нет прав доступа к этому разделу");
                return;
            }

            menuItemChanged(sender);
            using (DBEntities db = new DBEntities())
            {
                ColumnHelper.ChangeDataGridViewColumnVisible(dgvSection, "InAdmin");
                dgvSection.DataSource = db.User.Select(x => new {
                    x.Id,
                    x.CreatedOn,
                    Name = x.Login,
                    x.Password,
                    Contact = x.Contact.Name,
                    Type = x.UserType.Name
                }).ToList();
            }
        }

        private void dgvSection_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowIndex = dgvSection.SelectedCells[0]?.RowIndex;

            if (rowIndex == null)
            {
                MessageBox.Show("Нажмите дважды по строке, которую хотите отредактировать");
                return;
            }

            var id = dgvSection.Rows[(int)rowIndex].Cells[0]?.Value;
            if (id == null)
            {
                MessageBox.Show("Id этой записи не найден. Обратитесь к администратору");
                return;
            }

            if (((ToolStripMenuItem)CurrentMenuItem)?.Name == "tsMenuLookup")
            {
                var sysLookupForm = new SysLookupForm(this, User, id);
                sysLookupForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Form is developing...");
            }
        }
    }
}
