
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Who is billed for a request.
    /// </summary>
    public enum BetaBillTo
    {
        /// <summary>
        ///
        /// </summary>
        Self,
        /// <summary>
        ///
        /// </summary>
        UserProfile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBillToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBillTo value)
        {
            return value switch
            {
                BetaBillTo.Self => "self",
                BetaBillTo.UserProfile => "user_profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBillTo? ToEnum(string value)
        {
            return value switch
            {
                "self" => BetaBillTo.Self,
                "user_profile" => BetaBillTo.UserProfile,
                _ => null,
            };
        }
    }
}