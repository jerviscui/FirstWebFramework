using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataService
{
    public interface IRespository<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }

        void Add(T model);

        void Update(T model);

        void Delete(T model);
    }
}
