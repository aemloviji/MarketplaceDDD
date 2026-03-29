using System;

namespace MarketplaceDDD.Domain
{
    public class ClassifiedAdId
    {
        private readonly Guid _value;

        public ClassifiedAdId(Guid value)
        {
            if (value == default)
            {
                throw new ArgumentNullException(nameof(value), "Classified Ad Id cannot be empty");
            }

            _value = value;
        }
    }
}
