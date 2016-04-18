using System;

namespace Common.Ddd.Infrastructure.Persistence
{
    public class Id : IEquatable<Id>
    {
        public string Value { get; private set; }

        public Id(string value)
        {
            Value = value;
        }

        public bool Equals(Id other)
        {
            return Value.Equals(other.Value);
        }
    }
}