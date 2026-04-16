
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// ListOrder enum
    /// </summary>
    public enum BetaUserProfileListOrder
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
    public static class BetaUserProfileListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileListOrder value)
        {
            return value switch
            {
                BetaUserProfileListOrder.Asc => "asc",
                BetaUserProfileListOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileListOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaUserProfileListOrder.Asc,
                "desc" => BetaUserProfileListOrder.Desc,
                _ => null,
            };
        }
    }
}