using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.AppRoles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUserProfiles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUserRoles;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUsers;
using Softbreak.OnionArch.APPLICATION.Dtos.Categories;
using Softbreak.OnionArch.APPLICATION.Dtos.OrderDetails;
using Softbreak.OnionArch.APPLICATION.Dtos.Orders;
using Softbreak.OnionArch.APPLICATION.Dtos.Products;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AppRole, AppRoleDto>().ReverseMap();
            CreateMap<AppUserProfile, AppUserProfileDto>().ReverseMap();
            CreateMap<AppUserRole, AppUserRoleDto>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
