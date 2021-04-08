using EmployeRecord.Data.Entity;
using EmployeRecord.Data.Entity.BaseModel;
using EmployeRecord.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeRecord.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, ISample1Repository
    {
        private readonly Amrit_Test_DBEntities _amrit_Test_DBEntities;
        private DbSet<T> entities;
        public Repository(Amrit_Test_DBEntities amrit_Test_DBEntities)
        {
            this._amrit_Test_DBEntities = amrit_Test_DBEntities;
            entities = amrit_Test_DBEntities.Set<T>();
        }

        public bool Insert(T entity)
        {
            if (entity == null)
            {
                return false;
            }
            entities.Add(entity);
            _amrit_Test_DBEntities.SaveChanges();
            return true;
        }
    }

    public interface ISample1Repository
    {
    }
}
