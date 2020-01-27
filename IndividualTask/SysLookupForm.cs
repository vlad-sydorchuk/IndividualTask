using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTask
{
    public partial class SysLookupForm : Form
    {
        Form Form { get; set; }
        User User { get; set; }
        string LookupId { get; set; }
        string Table { get; set; }
        int CurrentRowIndex { get; set; } = -1;

        Dictionary<string, Action<object>> Mapping { get;  set; }

        public SysLookupForm(Form form, User user, object id)
        {
            InitializeComponent();
            Form = form;
            User = user;
            LookupId = id.ToString();

            Mapping = new Dictionary<string, Action<object>>()
            {
                { "InvoiceStatusAdd", (data) => new InvoiceStatus().Add((DataGridViewCustomRow)data) },
                { "InvoiceStatusUpdate", (data) => new InvoiceStatus().Update((DataGridViewCustomRow)data) },
                { "InvoiceStatusDelete", (data) => new InvoiceStatus().Delete(new Guid(data.ToString())) },

                { "UserTypeAdd", (data) => new UserType().Add((DataGridViewCustomRow)data) },
                { "UserTypeUpdate", (data) => new UserType().Update((DataGridViewCustomRow)data) },
                { "UserTypeDelete", (data) => new UserType().Delete(new Guid(data.ToString())) },

                { "CityAdd", (data) => new City().Add((DataGridViewCustomRow)data) },
                { "CityUpdate", (data) => new City().Update((DataGridViewCustomRow)data) },
                { "CityDelete", (data) => new City().Delete(new Guid(data.ToString())) },

                { "JobAdd", (data) => new Job().Add((DataGridViewCustomRow)data) },
                { "JobUpdate", (data) => new Job().Update((DataGridViewCustomRow)data) },
                { "JobDelete", (data) => new Job().Delete(new Guid(data.ToString())) },
            };
        }

        private void SysLookupForm_Load(object sender, EventArgs e)
        {
            dgvLookup.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var record = db.SysLookup.Where(x => x.Id == new Guid(LookupId)).FirstOrDefault();
                Table = record?.DbName;

                var collection = db.GetType().GetProperty(Table).GetValue(db);
                var data = ((IEnumerable<IDataGridViewReflection>)collection).Select(x => x.GetCustomData()).ToList();
                dgvLookup.DataSource = data;
                this.Text = string.Format("Справочник: {0}", record.Name);

                if (data.Count > 0)
                {
                    SetDataToFieldsFromRow(data[0]);
                }
                CurrentRowIndex = data.Count > 0 ? 0 : -1;
            }
        }

        private void dgvLookup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dgvLookup.SelectedCells[0]?.RowIndex;
            if (rowIndex != null && CurrentRowIndex != (int)rowIndex)
            {
                CurrentRowIndex = (int)rowIndex;
                var id = dgvLookup.Rows[(int)rowIndex].Cells[0].Value.ToString();
                var row = ((List<DataGridViewCustomRow>)dgvLookup.DataSource).Where(x => x.Id == new Guid(id)).FirstOrDefault();

                if (row != null)
                {
                    SetDataToFieldsFromRow(row);
                }
            }
        }

        private void SetDataToFieldsFromRow(DataGridViewCustomRow row)
        {
            // Заполняем поля слева значениями из строки
            txtName.Text = row?.Name;
            dtCreatedOn.Value = (DateTime)row?.CreatedOn;
            dtModifiedOn.Value = (DateTime)row?.ModifiedOn;
            rtxtDescription.Text = row?.Description;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var o = new DataGridViewCustomRow();
            o.Id = Guid.NewGuid();
            o.Name = txtName.Text;
            o.CreatedOn = dtCreatedOn.Value;
            o.ModifiedOn = dtModifiedOn.Value;
            o.Description = rtxtDescription.Text;

            Mapping[Table + "Add"]?.Invoke(o);
            SysLookupForm_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны, что хотите обновить запись?", "Обновление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvLookup.Rows[(int)CurrentRowIndex].Cells[0].Value.ToString();

                var o = new DataGridViewCustomRow();
                o.Id = new Guid(id);
                o.CreatedOn = dtCreatedOn.Value;
                o.ModifiedOn = dtModifiedOn.Value;
                o.Name = txtName.Text;
                o.Description = rtxtDescription.Text;

                Mapping[Table + "Update"]?.Invoke(o);
                SysLookupForm_Load(null, null);
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvLookup.Rows[(int)CurrentRowIndex].Cells[0].Value.ToString();

                Mapping[Table + "Delete"]?.Invoke(id);
                SysLookupForm_Load(null, null);
            }
        }
    }
}
