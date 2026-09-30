
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalKeyProviderConfigDiscriminatorType
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
    public static class ExternalKeyProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalKeyProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                ExternalKeyProviderConfigDiscriminatorType.Aws => "aws",
                ExternalKeyProviderConfigDiscriminatorType.Azure => "azure",
                ExternalKeyProviderConfigDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalKeyProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => ExternalKeyProviderConfigDiscriminatorType.Aws,
                "azure" => ExternalKeyProviderConfigDiscriminatorType.Azure,
                "gcp" => ExternalKeyProviderConfigDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}