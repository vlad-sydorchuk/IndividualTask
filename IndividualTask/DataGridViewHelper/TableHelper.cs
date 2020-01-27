using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTask.DataGridViewHelper
{
    public static class TableHelper
    {
        private static string PrefMenuItem { get; set; } = "tsMenu";

        public static string GetTableName(object sender)
        {
            var menuItemName = ((ToolStripItem)sender)?.Name;
            return menuItemName?.Substring(PrefMenuItem.Length, menuItemName.Length - PrefMenuItem.Length);
        }

        public static void UpdateDataGridView(DBEntities db, object sender, DataGridView dataGridView)
        {
            var tableName = GetTableName(sender);
            var collection = db.GetType().GetProperty(tableName).GetValue(db);
            dataGridView.DataSource = ((IEnumerable<IDataGridViewReflection>)collection).Select(x => x.GetCustomData()).ToList(); ;

            ColumnHelper.ChangeDataGridViewColumnVisible(dataGridView, string.Format("In{0}", tableName));
        }
    }
}
