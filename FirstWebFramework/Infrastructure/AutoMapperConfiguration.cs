using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Data;
using FirstWebFramework.Models;

namespace FirstWebFramework.Infrastructure
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterAutoMapperConfig()
        {
            Mapper.CreateMap<Entity, EntityModel>()
                .ForMember(o => o.Like, opt => opt.MapFrom(source => "don't be " + source.Sex));
            Mapper.CreateMap<EntityModel, Entity>();
        }
    }
}
