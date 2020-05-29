using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWP.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll { get; }
        T Get(T item);
        void Create(T item);
        void Update(T item, T item2);
        void Delete(T item);
    }

}
