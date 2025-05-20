using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.Categories;
using Softbreak.OnionArch.APPLICATION.Managers;
using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.InnerInfrastructure.ManagerConcretes
{
    public class CategoryManager : BaseManager<Category, CategoryDto>, ICategoryManager
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper) : base(categoryRepository, mapper)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
    }
}
