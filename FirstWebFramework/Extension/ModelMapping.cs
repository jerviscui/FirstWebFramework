using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Web.Models;

namespace Web.Extension
{
    public static class ModelMapping
    {
        public static EntityModel ToModel(this Entity entity)
        {
            return Mapper.Map<Entity, EntityModel>(entity);
        }

        public static Entity ToEntity(this EntityModel model)
        {
            return Mapper.Map<EntityModel, Entity>(model);
        }
    }
}
