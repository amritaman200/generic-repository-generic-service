using EmployeRecord.Data.Entity.BaseModel;
using EmployeRecord.Repository.Interfaces;
using EmployeRecord.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeRecord.Service.Service
{
    public class SingleService<T> : ISingleService<T> where T : BaseEntity
    {
        
        private readonly IRepository<T> repository1;
        public SingleService(IRepository<T> repository)
        {
            this.repository1 = repository;
        }

        public bool Insert(T item)
        {
            return this.repository1.Insert(item);
        }

        public void DeleteSample1(int id)
        {
            throw new NotImplementedException();
        }

        public object GetSample1(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetSample1s()
        {
            throw new NotImplementedException();
        }

        public void SaveSample1()
        {
            throw new NotImplementedException();
        }
    }
}
