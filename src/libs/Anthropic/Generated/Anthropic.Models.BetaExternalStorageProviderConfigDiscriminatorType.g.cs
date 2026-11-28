
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalStorageProviderConfigDiscriminatorType
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
    public static class BetaExternalStorageProviderConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalStorageProviderConfigDiscriminatorType value)
        {
            return value switch
            {
                BetaExternalStorageProviderConfigDiscriminatorType.Aws => "aws",
                BetaExternalStorageProviderConfigDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalStorageProviderConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => BetaExternalStorageProviderConfigDiscriminatorType.Aws,
                "gcp" => BetaExternalStorageProviderConfigDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}