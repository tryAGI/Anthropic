
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsEventDeltaEventContentDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsEventDeltaEventContentDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsEventDeltaEventContentDeltaType value)
        {
            return value switch
            {
                BetaManagedAgentsEventDeltaEventContentDeltaType.ContentDelta => "content_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsEventDeltaEventContentDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "content_delta" => BetaManagedAgentsEventDeltaEventContentDeltaType.ContentDelta,
                _ => null,
            };
        }
    }
}