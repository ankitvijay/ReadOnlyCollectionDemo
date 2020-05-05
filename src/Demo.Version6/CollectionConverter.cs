using System.Collections.Generic;
using System.Collections.Immutable;
using AutoMapper;

namespace Demo.Version6
{
    internal class CollectionConverter<TDomain, TDocument>
        : IValueConverter<ImmutableHashSet<TDomain>, ICollection<TDocument>>
    {
        public ICollection<TDocument> Convert(ImmutableHashSet<TDomain> sourceMember,
            ResolutionContext context)
        {
            var collection = new List<TDocument>();
            foreach (var domain in sourceMember)
            {
                collection.Add(context.Mapper.Map<TDocument>(domain));
            }

            return collection;
        }
    }
}