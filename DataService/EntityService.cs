using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataService
{
    public class EntityService : IEntityService
    {
        public Entity GetEntity()
        {
            return new Entity() { Id = 1, Name = "test" };
        }
    }
}
