
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaIterationsUsageItemsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AdvisorMessage,
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaIterationsUsageItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaIterationsUsageItemsDiscriminatorType value)
        {
            return value switch
            {
                BetaIterationsUsageItemsDiscriminatorType.AdvisorMessage => "advisor_message",
                BetaIterationsUsageItemsDiscriminatorType.Compaction => "compaction",
                BetaIterationsUsageItemsDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaIterationsUsageItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "advisor_message" => BetaIterationsUsageItemsDiscriminatorType.AdvisorMessage,
                "compaction" => BetaIterationsUsageItemsDiscriminatorType.Compaction,
                "message" => BetaIterationsUsageItemsDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}