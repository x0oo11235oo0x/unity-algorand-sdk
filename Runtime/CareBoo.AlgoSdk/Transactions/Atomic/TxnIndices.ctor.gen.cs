﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    public partial struct TxnIndices
    {
        public static TxnIndices Select(int x)
        {
            if (x < MinIndex || x > MaxIndex)
                throw new System.ArgumentOutOfRangeException(nameof(x));
            return (TxnFlags)(1 << x);
        }

        public static TxnIndices All => TxnFlags.All;

        public static TxnIndices None => TxnFlags.None;

        public static TxnIndices Select(int x0, int x1)
        {
            return Select(x0) | Select(x1);
        }

        public static TxnIndices AllBut(int x0, int x1)
        {
            return All ^ Select(x0, x1);
        }

        public static TxnIndices Select(int x0, int x1, int x2)
        {
            return Select(x0) | Select(x1) | Select(x2);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2)
        {
            return All ^ Select(x0, x1, x2);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3)
        {
            return All ^ Select(x0, x1, x2, x3);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4)
        {
            return All ^ Select(x0, x1, x2, x3, x4);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7) | Select(x8);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7, x8);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7) | Select(x8) | Select(x9);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7) | Select(x8) | Select(x9) | Select(x10);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7) | Select(x8) | Select(x9) | Select(x10) | Select(x11);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7) | Select(x8) | Select(x9) | Select(x10) | Select(x11) | Select(x12);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7) | Select(x8) | Select(x9) | Select(x10) | Select(x11) | Select(x12) | Select(x13);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);
        }

        public static TxnIndices Select(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14)
        {
            return Select(x0) | Select(x1) | Select(x2) | Select(x3) | Select(x4) | Select(x5) | Select(x6) | Select(x7) | Select(x8) | Select(x9) | Select(x10) | Select(x11) | Select(x12) | Select(x13) | Select(x14);
        }

        public static TxnIndices AllBut(int x0, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14)
        {
            return All ^ Select(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);
        }
    }
}
