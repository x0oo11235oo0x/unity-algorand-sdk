//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



public partial struct StrictTestObject
{
    
    private static bool @__generated__IsValid = StrictTestObject.@__generated__InitializeAlgoApiFormatters();
    
    private static bool @__generated__InitializeAlgoApiFormatters()
    {
        AlgoSdk.AlgoApiFormatterLookup.Add<StrictTestObject>(new AlgoSdk.AlgoApiObjectFormatter<StrictTestObject>(true).Assign("field1", "field1", (StrictTestObject x) => x.field, (ref StrictTestObject x, System.Int32 value) => x.field = value, false));
        return true;
    }
}
