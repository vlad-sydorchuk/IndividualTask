using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask
{
    public partial class Job : BaseLookup, IDataGridViewReflection, IDataBaseAction
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
            };

            return item;
        }

        public void Add(DataGridViewCustomRow o)
        {
            using (DBEntities db = new DBEntities())
            {
                var record = new Job()
                {
                    CreatedOn = o.CreatedOn,
                    ModifiedOn = o.ModifiedOn,
                    Name = o.Name,
                    Description = o.Description
                };

                db.Job.Add(record);
                db.SaveChanges();
            }
        }

        public void Update(DataGridViewCustomRow o)
        {
            using (DBEntities db = new DBEntities())
            {
                var entity = db.Job.Where(x => x.Id == o.Id).FirstOrDefault();
                if (entity != null)
                {
                    entity.Name = o.Name;
                    entity.Description = o.Description;
                    entity.CreatedOn = o.CreatedOn;
                    entity.ModifiedOn = o.ModifiedOn;

                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void Delete(Guid id)
        {
            using (DBEntities db = new DBEntities())
            {
                var entity = db.Job.Where(x => x.Id == id).FirstOrDefault();
                if (entity != null)
                {
                    db.Job.Attach(entity);
                    db.Job.Remove(entity);
                    db.SaveChanges();
                }
            }
        }
    }
}
