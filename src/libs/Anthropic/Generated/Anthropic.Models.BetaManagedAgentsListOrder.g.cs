
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// ListOrder enum
    /// </summary>
    public enum BetaManagedAgentsListOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsListOrder value)
        {
            return value switch
            {
                BetaManagedAgentsListOrder.Asc => "asc",
                BetaManagedAgentsListOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsListOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaManagedAgentsListOrder.Asc,
                "desc" => BetaManagedAgentsListOrder.Desc,
                _ => null,
            };
        }
    }
}