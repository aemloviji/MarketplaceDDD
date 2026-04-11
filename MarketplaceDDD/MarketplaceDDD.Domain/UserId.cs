using MarketplaceDDD.Framework;
using System;

namespace MarketplaceDDD.Domain
{
    public class UserId : Value<UserId>
    {
        private readonly Guid _value;

        public UserId(Guid value)
        {
            _value = value;
        }

        public static implicit operator Guid(UserId self) => self._value;
    }
}
