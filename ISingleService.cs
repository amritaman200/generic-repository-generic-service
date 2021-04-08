using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeRecord.Service.Interface
{
    
        public interface ISingleService<T>
        {
            IEnumerable<T> GetSample1s();
            object GetSample1(int id);
            bool Insert(T item);
            void DeleteSample1(int id);
            void SaveSample1();
        }
    
}
