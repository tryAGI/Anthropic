
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaRequestAdvisorToolResultBlockCacheControlVariant1DiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}