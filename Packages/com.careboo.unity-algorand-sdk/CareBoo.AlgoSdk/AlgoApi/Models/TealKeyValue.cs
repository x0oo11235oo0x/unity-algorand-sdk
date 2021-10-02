using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public struct TealKeyValue
        : IEquatable<TealKeyValue>
    {
        [AlgoApiField("key", null)]
        public FixedString128Bytes Key;

        [AlgoApiField("value", null)]
        public TealValue Value;

        public bool Equals(TealKeyValue other)
        {
            return Key.Equals(other.Key)
                && Value.Equals(other.Value)
                ;
        }
    }
}
