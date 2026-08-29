
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFederationIssuerCreateParamsJwksDiscriminatorType
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
    public static class BetaFederationIssuerCreateParamsJwksDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFederationIssuerCreateParamsJwksDiscriminatorType value)
        {
            return value switch
            {
                BetaFederationIssuerCreateParamsJwksDiscriminatorType.Discovery => "discovery",
                BetaFederationIssuerCreateParamsJwksDiscriminatorType.ExplicitUrl => "explicit_url",
                BetaFederationIssuerCreateParamsJwksDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFederationIssuerCreateParamsJwksDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => BetaFederationIssuerCreateParamsJwksDiscriminatorType.Discovery,
                "explicit_url" => BetaFederationIssuerCreateParamsJwksDiscriminatorType.ExplicitUrl,
                "inline" => BetaFederationIssuerCreateParamsJwksDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}