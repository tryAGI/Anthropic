
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalKeyProviderConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
        /// <summary>
        ///
        /// </summary>
        Azure,
        /// <summary>
        ///
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaExternalKeyProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalKeyProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                BetaExternalKeyProviderConfigDiscriminatorType.Aws => "aws",
                BetaExternalKeyProviderConfigDiscriminatorType.Azure => "azure",
                BetaExternalKeyProviderConfigDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalKeyProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => BetaExternalKeyProviderConfigDiscriminatorType.Aws,
                "azure" => BetaExternalKeyProviderConfigDiscriminatorType.Azure,
                "gcp" => BetaExternalKeyProviderConfigDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}