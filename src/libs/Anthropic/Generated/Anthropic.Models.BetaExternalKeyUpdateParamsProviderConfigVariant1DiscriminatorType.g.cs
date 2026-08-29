
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType
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
    public static class BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Aws => "aws",
                BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Azure => "azure",
                BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Aws,
                "azure" => BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Azure,
                "gcp" => BetaExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}