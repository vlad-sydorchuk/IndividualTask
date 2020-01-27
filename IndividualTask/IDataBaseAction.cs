using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTask
{
    public interface IDataBaseAction
    {
        void Add(DataGridViewCustomRow o);
        void Update(DataGridViewCustomRow o);
        void Delete(Guid id);
    }
}
