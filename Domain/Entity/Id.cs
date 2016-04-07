using System;

namespace common.ddd.Domain.Entity
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