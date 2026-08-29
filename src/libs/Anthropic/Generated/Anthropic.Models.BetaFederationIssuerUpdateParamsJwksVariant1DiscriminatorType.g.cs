
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType
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
    public static class BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Discovery => "discovery",
                BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.ExplicitUrl => "explicit_url",
                BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Discovery,
                "explicit_url" => BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.ExplicitUrl,
                "inline" => BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}