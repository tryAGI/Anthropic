
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEventDeltaEventDeltaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType.ContentDelta => "content_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "content_delta" => BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType.ContentDelta,
                _ => null,
            };
        }
    }
}