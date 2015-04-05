using HayfordTechnologies.Integration.DTO;
using HayfordTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HayfordTechnologies
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<ApplicationModel, Application>();
        }  
    }
}