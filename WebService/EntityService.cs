using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace WebService
{
    public class EntityService : IEntityService
    {
        private readonly IEntityService _entityService;

        /// <summary>
        /// 初始化 <see cref="T:System.Object"/> 类的新实例。
        /// </summary>
        public EntityService(IEntityService entityService)
        {
            _entityService = entityService;
        }

        public Entity GetEntity()
        {
            return _entityService.GetEntity();
        }
    }
}
