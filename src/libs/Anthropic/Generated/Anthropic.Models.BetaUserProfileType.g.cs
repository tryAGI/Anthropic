
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Object type. Always `user_profile`.
    /// </summary>
    public enum BetaUserProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        UserProfile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserProfileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileType value)
        {
            return value switch
            {
                BetaUserProfileType.UserProfile => "user_profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileType? ToEnum(string value)
        {
            return value switch
            {
                "user_profile" => BetaUserProfileType.UserProfile,
                _ => null,
            };
        }
    }
}