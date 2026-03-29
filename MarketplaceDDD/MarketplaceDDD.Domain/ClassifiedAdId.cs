using MarketplaceDDD.Framework;
using System;

namespace MarketplaceDDD.Domain
{
    public class ClassifiedAdId : Value<ClassifiedAdId>
    {
        private readonly Guid _value;

        public ClassifiedAdId(Guid value)
        {
            _value = value;
        }
    }
}
