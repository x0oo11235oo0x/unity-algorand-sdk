using System;
using UnityEngine;

namespace AlgoSdk.Abi
{
    [Serializable]
    public class FixedArrayType : IAbiType
    {
        [SerializeField, SerializeReference]
        IAbiType elementType;

        [SerializeField, Min(0)]
        int length;

        public FixedArrayType(IAbiType elementType, int length)
        {
            this.elementType = elementType;

            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length));
            this.length = length;
        }

        public string Name => $"{elementType?.Name ?? "void"}[{length}]";

        public AbiValueType ValueType => AbiValueType.Array;

        public bool IsStatic => elementType?.IsStatic ?? true;

        public int StaticLength => length * (elementType?.StaticLength ?? 0);

        public int N => length;

        public int M => throw new System.NotImplementedException();

        public IAbiType[] NestedTypes => new IAbiType[] { elementType };

        public IAbiType ElementType => elementType;

        public int ArrayLength => length;

        public bool IsFixedArray => true;

        public AbiTransactionType TransactionType => default;

        public AbiReferenceType ReferenceType => default;
    }
}
