using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Model;

namespace InventoryManagement.Repository
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductRequestModel>().ReverseMap();
        }
    }
}
