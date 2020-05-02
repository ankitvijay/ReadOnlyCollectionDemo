using System.Collections.Generic;
using System.Collections.Immutable;
using AutoMapper;
using Demo.Helper;

namespace Demo.Version5
{
    internal class HashMapConverter : IValueConverter<ImmutableHashSet<OrderItem>, ImmutableHashSet<OrderItem>>
    {
        public ImmutableHashSet<OrderItem> Convert(ICollection<OrderItemDto> sourceMember, ResolutionContext context)
        {
            var has = ImmutableHashSet.Create<OrderItem>();
            foreach (var item in sourceMember)
            {
                has.Add(new OrderItem(item.OrderId, item.OrderName));
            }

            return has;
        }

        public ImmutableHashSet<OrderItem> Convert(ImmutableHashSet<OrderItem> sourceMember, ResolutionContext context) => throw new System.NotImplementedException();
    }
}