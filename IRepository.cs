using EmployeRecord.Data.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeRecord.Repository.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        bool Insert(T Entity);
    }
}
