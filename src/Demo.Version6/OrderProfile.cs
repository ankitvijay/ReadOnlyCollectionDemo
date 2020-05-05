using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using AutoMapper;
using Demo.Helper;

namespace Demo.Version6
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {

            CreateMap<Order, OrderDto>()
                .ReverseMap();

            CreateMap<OrderItem, OrderItemDto>()
                .ReverseMap();
        }
    }
}
