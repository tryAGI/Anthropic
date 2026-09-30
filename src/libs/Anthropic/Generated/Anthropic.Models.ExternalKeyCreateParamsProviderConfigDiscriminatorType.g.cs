
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalKeyCreateParamsProviderConfigDiscriminatorType
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
    public static class ExternalKeyCreateParamsProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalKeyCreateParamsProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                ExternalKeyCreateParamsProviderConfigDiscriminatorType.Aws => "aws",
                ExternalKeyCreateParamsProviderConfigDiscriminatorType.Azure => "azure",
                ExternalKeyCreateParamsProviderConfigDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalKeyCreateParamsProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => ExternalKeyCreateParamsProviderConfigDiscriminatorType.Aws,
                "azure" => ExternalKeyCreateParamsProviderConfigDiscriminatorType.Azure,
                "gcp" => ExternalKeyCreateParamsProviderConfigDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}