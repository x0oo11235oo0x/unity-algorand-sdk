//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    
    
    public partial struct BlockTransaction
    {
        
        private static bool @__generated__IsValid = BlockTransaction.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.BlockTransaction>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.BlockTransaction>().Assign("txn", "txn", (AlgoSdk.BlockTransaction x) => x.Transaction, (ref AlgoSdk.BlockTransaction x, AlgoSdk.Transaction value) => x.Transaction = value, false).Assign("hgi", "hgi", (AlgoSdk.BlockTransaction x) => x.Hgi, (ref AlgoSdk.BlockTransaction x, AlgoSdk.Optional<System.Boolean> value) => x.Hgi = value, false).Assign("rr", "rr", (AlgoSdk.BlockTransaction x) => x.ReceiverRewards, (ref AlgoSdk.BlockTransaction x, System.UInt64 value) => x.ReceiverRewards = value, false).Assign("rs", "rs", (AlgoSdk.BlockTransaction x) => x.SenderRewards, (ref AlgoSdk.BlockTransaction x, System.UInt64 value) => x.SenderRewards = value, false).Assign("rc", "rc", (AlgoSdk.BlockTransaction x) => x.CloseRewards, (ref AlgoSdk.BlockTransaction x, System.UInt64 value) => x.CloseRewards = value, false).Assign("dt", "dt", (AlgoSdk.BlockTransaction x) => x.EvalDelta, (ref AlgoSdk.BlockTransaction x, AlgoSdk.EvalDelta value) => x.EvalDelta = value, false).Assign("sig", "sig", (AlgoSdk.BlockTransaction x) => x.Sig, (ref AlgoSdk.BlockTransaction x, AlgoSdk.Sig value) => x.Sig = value, false).Assign("msig", "msig", (AlgoSdk.BlockTransaction x) => x.Multisig, (ref AlgoSdk.BlockTransaction x, AlgoSdk.Multisig value) => x.Multisig = value, false).Assign("lsig", "lsig", (AlgoSdk.BlockTransaction x) => x.LogicSig, (ref AlgoSdk.BlockTransaction x, AlgoSdk.LogicSig value) => x.LogicSig = value, false));
            return true;
        }
    }
}