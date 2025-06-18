// ReSharper disable once CheckNamespace
namespace Anthropic;

/// <summary>
/// According to https://anthropic.com/pricing#anthropic-api
/// </summary>
public static partial class ModelMetadata
{
    /// <summary>
    /// Just a constant for 1e-3.
    /// </summary>
    public const double UsdPerThousandTokens = 1e-3;
    
    /// <summary>
    /// Just a constant for 1e-6.
    /// </summary>
    public const double UsdPerMillionTokens = 1e-6;
    
    /// <summary>
    /// Just a constant for 1e-9.
    /// </summary>
    public const double UsdPerBillionTokens = 1e-9;
}