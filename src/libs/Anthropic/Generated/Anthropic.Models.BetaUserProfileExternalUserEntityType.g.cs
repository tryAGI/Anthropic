
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What kind of entity the profile represents, as the platform states it: `individual`, `business`, `non_profit` or `government`.
    /// </summary>
    public enum BetaUserProfileExternalUserEntityType
    {
        /// <summary>
        /// `individual`, `business`, `non_profit` or `government`.
        /// </summary>
        Business,
        /// <summary>
        /// `individual`, `business`, `non_profit` or `government`.
        /// </summary>
        Government,
        /// <summary>
        /// `individual`, `business`, `non_profit` or `government`.
        /// </summary>
        Individual,
        /// <summary>
        /// `individual`, `business`, `non_profit` or `government`.
        /// </summary>
        NonProfit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserProfileExternalUserEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileExternalUserEntityType value)
        {
            return value switch
            {
                BetaUserProfileExternalUserEntityType.Business => "business",
                BetaUserProfileExternalUserEntityType.Government => "government",
                BetaUserProfileExternalUserEntityType.Individual => "individual",
                BetaUserProfileExternalUserEntityType.NonProfit => "non_profit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileExternalUserEntityType? ToEnum(string value)
        {
            return value switch
            {
                "business" => BetaUserProfileExternalUserEntityType.Business,
                "government" => BetaUserProfileExternalUserEntityType.Government,
                "individual" => BetaUserProfileExternalUserEntityType.Individual,
                "non_profit" => BetaUserProfileExternalUserEntityType.NonProfit,
                _ => null,
            };
        }
    }
}