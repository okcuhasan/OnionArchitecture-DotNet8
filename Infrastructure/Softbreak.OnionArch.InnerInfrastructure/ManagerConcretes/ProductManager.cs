using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.Products;
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
    public class ProductManager : BaseManager<Product, ProductDto>, IProductManager
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository, IMapper mapper) : base(productRepository, mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
    }
}
