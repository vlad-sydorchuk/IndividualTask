using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public partial class Invoice : BaseLookup, IDataGridViewReflection
    {
        DataGridViewCustomRow IDataGridViewReflection.GetCustomData()
        {
            var item = new DataGridViewCustomRow()
            {
                Id = Id,
                CreatedOn = CreatedOn,
                ModifiedOn = ModifiedOn,
                Name = Name,
                Account = Account?.Name,
                Contact = Contact?.Name,
                Amount = Amount,
                Status = InvoiceStatus?.Name,
                Owner = ContactOwner?.Name
            };

            return item;
        }
    }
}
