
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Cloud,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType.Cloud => "cloud",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cloud" => BetaPublicEnvironmentUpdateRequestConfigVariant1DiscriminatorType.Cloud,
                _ => null,
            };
        }
    }
}