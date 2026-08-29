
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalKeyCreateParamsProviderConfigDiscriminatorType
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
    public static class BetaExternalKeyCreateParamsProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalKeyCreateParamsProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Aws => "aws",
                BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Azure => "azure",
                BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Aws,
                "azure" => BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Azure,
                "gcp" => BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}