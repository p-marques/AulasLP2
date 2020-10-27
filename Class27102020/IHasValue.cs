using System;

namespace Class27102020
{
    public interface IHasValue : IEquatable<IHasValue>
    {
        float Value { get; }
    }
}