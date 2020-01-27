using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public partial class Product : BaseLookup, IDataGridViewReflection
    {
        DataGridViewCustomRow IDataGridViewReflection.GetCustomData()
        {
            var item = new DataGridViewCustomRow()
            {
                Id = Id,
                CreatedOn = CreatedOn,
                ModifiedOn = ModifiedOn,
                Name = Name,
                Description = Description,
                Price = Price
            };

            return item;
        }
    }
}
