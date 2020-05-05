using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoMapper;

namespace Demo.Version6
{
    internal class HashMapConverter<TDocument, TDomain>
        : IValueConverter<ICollection<TDocument>, HashSet<TDomain>>
    {
        public HashSet<TDomain> Convert(ICollection<TDocument> sourceMember,
            ResolutionContext context)
        {
            var hashSet = new HashSet<TDomain>();
            foreach (var document in sourceMember)
            {
                hashSet.Add(context.Mapper.Map<TDomain>(document));
            }

            return hashSet.ToHashSet();
        }
    }
}