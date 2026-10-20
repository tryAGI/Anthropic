
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What kind of entity the profile represents, as the platform states it: `individual`, `business`, `non_profit` or `government`.
    /// </summary>
    public enum UserProfileExternalUserEntityType
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
    public static class UserProfileExternalUserEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileExternalUserEntityType value)
        {
            return value switch
            {
                UserProfileExternalUserEntityType.Business => "business",
                UserProfileExternalUserEntityType.Government => "government",
                UserProfileExternalUserEntityType.Individual => "individual",
                UserProfileExternalUserEntityType.NonProfit => "non_profit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileExternalUserEntityType? ToEnum(string value)
        {
            return value switch
            {
                "business" => UserProfileExternalUserEntityType.Business,
                "government" => UserProfileExternalUserEntityType.Government,
                "individual" => UserProfileExternalUserEntityType.Individual,
                "non_profit" => UserProfileExternalUserEntityType.NonProfit,
                _ => null,
            };
        }
    }
}