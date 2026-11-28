
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalStorageCreateParamsProviderConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
        /// <summary>
        ///
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaExternalStorageCreateParamsProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalStorageCreateParamsProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                BetaExternalStorageCreateParamsProviderConfigDiscriminatorType.Aws => "aws",
                BetaExternalStorageCreateParamsProviderConfigDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalStorageCreateParamsProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => BetaExternalStorageCreateParamsProviderConfigDiscriminatorType.Aws,
                "gcp" => BetaExternalStorageCreateParamsProviderConfigDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}