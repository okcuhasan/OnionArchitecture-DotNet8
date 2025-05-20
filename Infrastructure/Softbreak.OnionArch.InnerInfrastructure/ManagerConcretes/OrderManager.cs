using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.Orders;
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
    public class OrderManager : BaseManager<Order, OrderDto>, IOrderManager
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }
    }
}
