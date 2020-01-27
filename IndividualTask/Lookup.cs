using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public class Lookup
    {
        public Guid Id { get; set; }
        public string DisplayValue { get; set; }

        public override string ToString()
        {
            return DisplayValue;
        }
    }
}
