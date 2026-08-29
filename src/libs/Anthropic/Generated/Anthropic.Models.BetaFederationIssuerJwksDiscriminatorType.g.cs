
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFederationIssuerJwksDiscriminatorType
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
    public static class BetaFederationIssuerJwksDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFederationIssuerJwksDiscriminatorType value)
        {
            return value switch
            {
                BetaFederationIssuerJwksDiscriminatorType.Discovery => "discovery",
                BetaFederationIssuerJwksDiscriminatorType.ExplicitUrl => "explicit_url",
                BetaFederationIssuerJwksDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFederationIssuerJwksDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => BetaFederationIssuerJwksDiscriminatorType.Discovery,
                "explicit_url" => BetaFederationIssuerJwksDiscriminatorType.ExplicitUrl,
                "inline" => BetaFederationIssuerJwksDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}