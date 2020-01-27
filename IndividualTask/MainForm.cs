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
        string PrefMenuItem { get; set; } = "tsMenu";
        int CurrentRowIndex { get; set; } = 0;

        Dictionary<string, Func<Form, User, string, Form>> Forms { get; set; }
        Dictionary<string, Action<string>> DeleteMethods { get; set; }

        public MainForm(AuthorizeForm authorizeForm, User user)
        {
            InitializeComponent();

            Form = authorizeForm;
            User = user;

            Forms = new Dictionary<string, Func<Form, User, string, Form>>()
            {
                { "tsMenuContact", (a, b, c) => { return new ContactForm(a, b, c); } },
                { "tsMenuAccount", (a, b, c) => { return new AccountForm(a, b, c); } },
                { "tsMenuProduct", (a, b, c) => { return new ProductForm(a, b, c); } },
                { "tsMenuInvoice", (a, b, c) => { return new InvoiceForm(a, b, c); } },
                { "tsMenuSysLookup", (a, b, c) => { return new SysLookupForm(a, b, c); } },
                { "tsMenuUser", (a, b, c) => { return new AdminForm(a, b, c); } },
            };

            DeleteMethods = new Dictionary<string, Action<string>>()
            {
                { "tsMenuContact", (a) => ContactForm.Delete(a) },
                { "tsMenuAccount", (a) => AccountForm.Delete(a) },
                { "tsMenuProduct", (a) => ProductForm.Delete(a) },
                { "tsMenuInvoice", (a) => InvoiceForm.Delete(a) },
                { "tsMenuUser", (a) => AdminForm.Delete(a) },
            };

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

        private void menuItemChanged(object sender)
        {
            using (DBEntities db = new DBEntities())
            {
                TableHelper.UpdateDataGridView(db, sender, dgvSection);
            }

            CurrentMenuItem = sender;
            changeSelectedSectionFont(sender);

            // Запрещаем нажимать на кнопки, если выбран раздел "Справочники"
            btnAddRecord.Enabled = ((ToolStripMenuItem)sender).Name == "tsMenuSysLookup" ? false : true;
            btcDeleteRecord.Enabled = ((ToolStripMenuItem)sender).Name == "tsMenuSysLookup" ? false : true;
        }

        public void UpdateGrid()
        {
            menuItemChanged(CurrentMenuItem);
        }

        private void changeSelectedSectionFont(object sender)
        {
            foreach (ToolStripMenuItem item in mainMenu.Items)
            {
                item.Font = new Font(item.Font, ((ToolStripMenuItem)sender)?.Name == item.Name ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void tsMenuContact_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
        }

        private void tsMenuAccount_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
        }

        private void tsMenuProduct_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
        }

        private void tsMenuInvoice_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
        }

        private void tsMenuSysLookup_Click(object sender, EventArgs e)
        {
            menuItemChanged(sender);
        }

        private void tsMenuUser_Click(object sender, EventArgs e)
        {
            if (User?.TypeId != UserTypeHelper.AdminTypeId)
            {
                MessageBox.Show("У Вас нет прав доступа к этому разделу");
                return;
            }

            menuItemChanged(sender);
        }

        private void dgvSection_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CurrentRowIndex = dgvSection.SelectedCells[0].RowIndex;

            var id = dgvSection.Rows[(int)CurrentRowIndex].Cells[0]?.Value;
            if (id == null)
            {
                MessageBox.Show("Id этой записи не найден. Обратитесь к администратору");
                return;
            }

            OpenForm(id.ToString());
        }

        private void OpenForm(string id = null)
        {
            try
            {
                var currentSectionName = ((ToolStripMenuItem)CurrentMenuItem)?.Name;
                var form = Forms[currentSectionName]?.Invoke(this, User, id);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgvSection.Rows[(int)CurrentRowIndex].Cells[0].Value.ToString();
                OpenForm(id);
            }
            catch (ArgumentOutOfRangeException iEx)
            {
                MessageBox.Show("Выберите запись для редактирования");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btcDeleteRecord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var tsMenuName = ((ToolStripMenuItem)CurrentMenuItem)?.Name;
                    var id = dgvSection.Rows[(int)CurrentRowIndex].Cells[0].Value.ToString();

                    DeleteMethods[tsMenuName]?.Invoke(id);
                    UpdateGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvSection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRowIndex = dgvSection.SelectedCells[0].RowIndex;
        }
    }
}
