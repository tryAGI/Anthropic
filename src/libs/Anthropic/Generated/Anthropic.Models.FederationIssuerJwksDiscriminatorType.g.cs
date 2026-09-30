
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum FederationIssuerJwksDiscriminatorType
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
    public static class FederationIssuerJwksDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FederationIssuerJwksDiscriminatorType value)
        {
            return value switch
            {
                FederationIssuerJwksDiscriminatorType.Discovery => "discovery",
                FederationIssuerJwksDiscriminatorType.ExplicitUrl => "explicit_url",
                FederationIssuerJwksDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FederationIssuerJwksDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => FederationIssuerJwksDiscriminatorType.Discovery,
                "explicit_url" => FederationIssuerJwksDiscriminatorType.ExplicitUrl,
                "inline" => FederationIssuerJwksDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}