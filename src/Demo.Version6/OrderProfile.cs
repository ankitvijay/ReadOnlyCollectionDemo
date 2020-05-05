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
                    //.ForMember(d => d.OrderItems, opt => opt.ConvertUsing(new CollectionConverter<OrderItem, OrderItemDto>()))
                .ReverseMap()
                    .ForMember(d => d.OrderItems, opt => opt.ConvertUsing(new HashMapConverter<OrderItemDto, OrderItem>()))
                .DisableCtorValidation();

            CreateMap<OrderItem, OrderItemDto>()
                .ReverseMap();
        }
    }
}
