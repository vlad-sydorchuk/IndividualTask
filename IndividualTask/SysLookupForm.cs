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

        public SysLookupForm(Form form, User user, object id)
        {
            InitializeComponent();
            Form = form;
            User = user;
            LookupId = id.ToString();
        }

        private void SysLookupForm_Load(object sender, EventArgs e)
        {
            dgvLookup.AutoGenerateColumns = false;

            using (DBEntities db = new DBEntities())
            {
                var record = db.SysLookup.Where(x => x.Id == new Guid(LookupId)).FirstOrDefault();
                Table = record?.DbName;

                if (Table == "InvoiceStatus")
                {
                    dgvLookup.DataSource = db.InvoiceStatus.ToList();
                    this.Text = "Справочники: " + record.Name;
                }
                else if (Table == "UserType")
                {
                    dgvLookup.DataSource = db.UserType.ToList();
                    this.Text = "Справочники: " + record.Name;
                }
                else if (Table == "City")
                {
                    dgvLookup.DataSource = db.City.ToList();
                    this.Text = "Справочники: " + record.Name;
                }
                else if (Table == "Job")
                {
                    dgvLookup.DataSource = db.Job.ToList();
                    this.Text = "Справочники: " + record.Name;
                }

                dgvLookup_CellClick(null, null);
            }
        }

        
        private void dgvLookup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dgvLookup.SelectedCells[0]?.RowIndex;
            if (rowIndex != null && CurrentRowIndex != (int)rowIndex)
            {
                CurrentRowIndex = (int)rowIndex;
                var id = dgvLookup.Rows[(int)rowIndex].Cells[0].Value.ToString();

                using (DBEntities db = new DBEntities())
                {
                    var table = "Account";
                    var tt = db.GetType().GetProperty(table).GetValue(db);
                    var ss = ((IEnumerable<IDataGridViewReflection>)tt).Select(x => x.GetCustomData()).ToList();
                    
                    


                    if (Table == "InvoiceStatus")
                    {
                        var s = db.InvoiceStatus.Where(x => x.Id == new Guid(id)).First();
                        txtName.Text = s.Name;
                        dtCreatedOn.Value = (DateTime)s.CreatedOn;
                        dtModifiedOn.Value = (DateTime)s.ModifiedOn;
                        rtxtDescription.Text = s.Description;
                    }
                    else if (Table == "UserType")
                    {
                        dgvLookup.DataSource = db.UserType.ToList();
                    }
                    else if (Table == "City")
                    {
                        dgvLookup.DataSource = db.City.ToList();
                    }
                    else if (Table == "Job")
                    {
                        dgvLookup.DataSource = db.Job.ToList();
                    }
                }
            }
        }
    }
}
