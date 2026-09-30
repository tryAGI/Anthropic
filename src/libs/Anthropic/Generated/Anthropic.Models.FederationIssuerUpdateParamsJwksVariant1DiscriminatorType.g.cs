
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum FederationIssuerUpdateParamsJwksVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Discovery,
        /// <summary>
        ///
        /// </summary>
        ExplicitUrl,
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FederationIssuerUpdateParamsJwksVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FederationIssuerUpdateParamsJwksVariant1DiscriminatorType value)
        {
            return value switch
            {
                FederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Discovery => "discovery",
                FederationIssuerUpdateParamsJwksVariant1DiscriminatorType.ExplicitUrl => "explicit_url",
                FederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FederationIssuerUpdateParamsJwksVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => FederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Discovery,
                "explicit_url" => FederationIssuerUpdateParamsJwksVariant1DiscriminatorType.ExplicitUrl,
                "inline" => FederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}