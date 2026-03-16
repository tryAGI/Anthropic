
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaIterationsUsageVariant1ItemDiscriminatorType
    {
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
    public static class BetaIterationsUsageVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaIterationsUsageVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaIterationsUsageVariant1ItemDiscriminatorType.Compaction => "compaction",
                BetaIterationsUsageVariant1ItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaIterationsUsageVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => BetaIterationsUsageVariant1ItemDiscriminatorType.Compaction,
                "message" => BetaIterationsUsageVariant1ItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}