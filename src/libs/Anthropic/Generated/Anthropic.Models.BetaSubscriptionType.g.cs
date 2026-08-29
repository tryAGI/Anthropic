
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSubscriptionType
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSubscriptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSubscriptionType value)
        {
            return value switch
            {
                BetaSubscriptionType.Enterprise => "enterprise",
                BetaSubscriptionType.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSubscriptionType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => BetaSubscriptionType.Enterprise,
                "team" => BetaSubscriptionType.Team,
                _ => null,
            };
        }
    }
}