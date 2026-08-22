
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDreamSessionsInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Sessions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamSessionsInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamSessionsInputType value)
        {
            return value switch
            {
                BetaDreamSessionsInputType.Sessions => "sessions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamSessionsInputType? ToEnum(string value)
        {
            return value switch
            {
                "sessions" => BetaDreamSessionsInputType.Sessions,
                _ => null,
            };
        }
    }
}