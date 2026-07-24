
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFallbackConfigV2ThinkingVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Adaptive,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFallbackConfigV2ThinkingVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFallbackConfigV2ThinkingVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaFallbackConfigV2ThinkingVariant1DiscriminatorType.Adaptive => "adaptive",
                BetaFallbackConfigV2ThinkingVariant1DiscriminatorType.Disabled => "disabled",
                BetaFallbackConfigV2ThinkingVariant1DiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFallbackConfigV2ThinkingVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => BetaFallbackConfigV2ThinkingVariant1DiscriminatorType.Adaptive,
                "disabled" => BetaFallbackConfigV2ThinkingVariant1DiscriminatorType.Disabled,
                "enabled" => BetaFallbackConfigV2ThinkingVariant1DiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}