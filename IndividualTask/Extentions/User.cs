using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public partial class User : BaseLookup, IDataGridViewReflection
    {
        DataGridViewCustomRow IDataGridViewReflection.GetCustomData()
        {
            var item = new DataGridViewCustomRow()
            {
                Id = Id,
                CreatedOn = CreatedOn,
                ModifiedOn = ModifiedOn,
                Name = Login,
                Password = Password,
                Contact = Contact?.Name,
                Type = UserType?.Name
            };

            return item;
        }
    }
}
