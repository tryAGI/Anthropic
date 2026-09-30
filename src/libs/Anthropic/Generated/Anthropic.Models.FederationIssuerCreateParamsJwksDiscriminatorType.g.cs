
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum FederationIssuerCreateParamsJwksDiscriminatorType
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
    public static class FederationIssuerCreateParamsJwksDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FederationIssuerCreateParamsJwksDiscriminatorType value)
        {
            return value switch
            {
                FederationIssuerCreateParamsJwksDiscriminatorType.Discovery => "discovery",
                FederationIssuerCreateParamsJwksDiscriminatorType.ExplicitUrl => "explicit_url",
                FederationIssuerCreateParamsJwksDiscriminatorType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FederationIssuerCreateParamsJwksDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => FederationIssuerCreateParamsJwksDiscriminatorType.Discovery,
                "explicit_url" => FederationIssuerCreateParamsJwksDiscriminatorType.ExplicitUrl,
                "inline" => FederationIssuerCreateParamsJwksDiscriminatorType.Inline,
                _ => null,
            };
        }
    }
}