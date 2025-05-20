using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.OrderDetails;
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
    public class OrderDetailManager : BaseManager<OrderDetail, OrderDetailDto>, IOrderDetailManager
    {
        private readonly IMapper _mapper;
        private readonly IOrderDetailRepository _orderDetailRepository;
        public OrderDetailManager(IOrderDetailRepository orderDetailRepository, IMapper mapper) : base(orderDetailRepository, mapper)
        {
            _mapper = mapper;
            _orderDetailRepository = orderDetailRepository;
        }
    }
}
