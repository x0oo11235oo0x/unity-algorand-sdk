//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk.Kmd
{
    
    
    public partial struct ImportKeyRequest
    {
        
        private static bool @__generated__IsValid = ImportKeyRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Kmd.ImportKeyRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Kmd.ImportKeyRequest>(false).Assign("private_key", (AlgoSdk.Kmd.ImportKeyRequest x) => x.PrivateKey, (ref AlgoSdk.Kmd.ImportKeyRequest x, AlgoSdk.PrivateKey value) => x.PrivateKey = value).Assign("wallet_handle_token", (AlgoSdk.Kmd.ImportKeyRequest x) => x.WalletHandleToken, (ref AlgoSdk.Kmd.ImportKeyRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value));
            return true;
        }
    }
}