using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public static class UserTypeHelper
    {
        public static Guid AdminTypeId = new Guid("B296EFA8-371F-EA11-BBBB-80C5F27910B6");       // Администратор
        public static Guid CustomerTypeId = new Guid("B396EFA8-371F-EA11-BBBB-80C5F27910B6");    // Сотрудник
        public static Guid ClientTypeId = new Guid("F9B5E2B1-371F-EA11-BBBB-80C5F27910B6");      // Клиент
    }
}
