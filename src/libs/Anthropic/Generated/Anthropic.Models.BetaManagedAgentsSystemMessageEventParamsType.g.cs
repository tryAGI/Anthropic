
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSystemMessageEventParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSystemMessageEventParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSystemMessageEventParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsSystemMessageEventParamsType.SystemMessage => "system.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSystemMessageEventParamsType? ToEnum(string value)
        {
            return value switch
            {
                "system.message" => BetaManagedAgentsSystemMessageEventParamsType.SystemMessage,
                _ => null,
            };
        }
    }
}