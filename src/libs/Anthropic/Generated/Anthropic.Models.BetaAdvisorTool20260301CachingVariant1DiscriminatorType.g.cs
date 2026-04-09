
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAdvisorTool20260301CachingVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAdvisorTool20260301CachingVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAdvisorTool20260301CachingVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaAdvisorTool20260301CachingVariant1DiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAdvisorTool20260301CachingVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaAdvisorTool20260301CachingVariant1DiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}