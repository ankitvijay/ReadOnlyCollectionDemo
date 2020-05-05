using System.Collections.Generic;
using System.Collections.Immutable;
using AutoMapper;

namespace Demo.Version6
{
    internal class HashMapConverter<TDocument, TDomain>
        : IValueConverter<ICollection<TDocument>, ImmutableHashSet<TDomain>>
    {
        public ImmutableHashSet<TDomain> Convert(ICollection<TDocument> sourceMember,
            ResolutionContext context)
        {
            var hashSet = new HashSet<TDomain>();
            foreach (var document in sourceMember)
            {
                hashSet.Add(context.Mapper.Map<TDomain>(document));
            }

            return hashSet.ToImmutableHashSet();
        }
    }
}