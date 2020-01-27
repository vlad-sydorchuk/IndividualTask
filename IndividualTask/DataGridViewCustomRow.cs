using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public class DataGridViewCustomRow : BaseLookup
    {
        public string Contact { get; set; }
        public string Account { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }
        public string DbName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
