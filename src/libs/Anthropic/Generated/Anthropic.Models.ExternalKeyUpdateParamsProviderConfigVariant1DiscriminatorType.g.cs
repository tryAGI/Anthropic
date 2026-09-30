
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType
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
    public static class ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Aws => "aws",
                ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Azure => "azure",
                ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Aws,
                "azure" => ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Azure,
                "gcp" => ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}