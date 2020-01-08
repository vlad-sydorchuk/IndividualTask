using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTask.DataGridViewHelper
{
    public static class ColumnHelper
    {
        public static void ChangeDataGridViewColumnVisible(DataGridView dgv, string condition = null)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.Visible = (condition == null)
                    ? col.Name.Contains("All")
                    : col.Name.Contains("All") || col.Name.Contains(condition);
            }

            
        }
    }
}
