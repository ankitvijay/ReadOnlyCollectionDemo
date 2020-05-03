using System.Collections.Generic;
using System.Collections.Immutable;
using AutoMapper;

namespace Demo.Version5
{
    internal class HashMapConverter<TCollection, TImmutableHashSet> 
        : ITypeConverter<ICollection<TCollection>, ImmutableHashSet<TImmutableHashSet>>
    {
        public ImmutableHashSet< TImmutableHashSet> Convert(
            ICollection<TCollection> source,
            ImmutableHashSet< TImmutableHashSet> destination,
            ResolutionContext context)
        {
            return ImmutableHashSet<TImmutableHashSet>.Empty;
        }
    }
}