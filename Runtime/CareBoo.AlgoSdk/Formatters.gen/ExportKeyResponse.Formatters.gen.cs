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
    
    
    public partial struct ExportKeyResponse
    {
        
        private static bool @__generated__IsValid = ExportKeyResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Kmd.ExportKeyResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Kmd.ExportKeyResponse>(false).Assign("error", (AlgoSdk.Kmd.ExportKeyResponse x) => x.Error, (ref AlgoSdk.Kmd.ExportKeyResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value).Assign("message", (AlgoSdk.Kmd.ExportKeyResponse x) => x.Message, (ref AlgoSdk.Kmd.ExportKeyResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance).Assign("private_key", (AlgoSdk.Kmd.ExportKeyResponse x) => x.PrivateKey, (ref AlgoSdk.Kmd.ExportKeyResponse x, AlgoSdk.PrivateKey value) => x.PrivateKey = value));
            return true;
        }
    }
}