using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public partial class Contact : BaseLookup, IDataGridViewReflection
    {
        DataGridViewCustomRow IDataGridViewReflection.GetCustomData()
        {
            var item = new DataGridViewCustomRow()
            {
                Id = Id,
                CreatedOn = CreatedOn,
                ModifiedOn = ModifiedOn,
                Name = Name,
                Job = Job?.Name,
                City = City?.Name,
                Phone = Phone,
                Email = Email,
                Account = Account.Where(x => x.Contact.Id == Id).FirstOrDefault()?.Name
            };

            return item;
        }
    }
}
