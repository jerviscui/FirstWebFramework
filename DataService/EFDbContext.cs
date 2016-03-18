using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataService.Maps;

namespace DataService
{
    /// <summary>
    /// 
    /// </summary>
    public  class EfDbContext : DbContext, IDbContext
    {
        public EfDbContext() : base("defaultDB")
        {
            //启动程序初始化数据库
            //Database.SetInitializer(new CreateDatabaseIfNotExists<EFDbContext>());
        }

        /// <summary>
        /// 在完成对派生上下文的模型的初始化后，并在该模型已锁定并用于初始化上下文之前，将调用此方法。虽然此方法的默认实现不执行任何操作，但可在派生类中重写此方法，这样便能在锁定模型之前对其进行进一步的配置。
        /// </summary>
        /// <param name="modelBuilder">定义要创建的上下文的模型的生成器。</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new BaseMap())

            base.OnModelCreating(modelBuilder);
        }
    }
}
