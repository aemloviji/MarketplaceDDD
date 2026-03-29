using System;
using System.Collections.Generic;

namespace MarketplaceDDD.Domain
{
    public class Money : IEquatable<Money?>
    {
        private decimal Amount { get; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Money);
        }

        public bool Equals(Money? other)
        {
            return !(other is null) &&
                   Amount == other.Amount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount);
        }

        public static bool operator ==(Money? left, Money? right)
        {
            return EqualityComparer<Money>.Default.Equals(left, right);
        }

        public static bool operator !=(Money? left, Money? right)
        {
            return !(left == right);
        }
    }
}
