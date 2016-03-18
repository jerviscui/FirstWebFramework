using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataService
{
    public class Respository<T> : IRespository<T> where T : BaseEntity
    {
        private readonly IDbContext _dbContext;

        /// <summary>
        /// 初始化 <see cref="T:System.Object"/> 类的新实例。
        /// </summary>
        public Respository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Table
        {
            get { return _dbContext.Set<T>(); }
        }

        public void Add(T model)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete(T model)
        {
            throw new NotImplementedException();
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }

        private async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
