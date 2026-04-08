
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Cloud,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType.Cloud => "cloud",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cloud" => BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType.Cloud,
                _ => null,
            };
        }
    }
}