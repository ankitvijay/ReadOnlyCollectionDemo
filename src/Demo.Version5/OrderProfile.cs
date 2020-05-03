using System.Collections.Immutable;
using AutoMapper;
using Demo.Helper;

namespace Demo.Version5
{
    public class OrderProfile : Profile
    {
        private IValueConverter<ImmutableHashSet<OrderItem>, object> tet;

        public OrderProfile()
        {
            CreateMap<Order, OrderDto>()
                .ReverseMap();
                

            CreateMap<OrderItem, OrderItemDto>()
                .ReverseMap();
        }
    }
}
