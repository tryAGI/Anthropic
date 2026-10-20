
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The direction that a list of user profiles is sorted in.
    /// </summary>
    public enum UserProfileListOrder
    {
        /// <summary>
        /// Oldest first when `order_by` is `created_at`, or names in ascending order when `order_by` is `name`.
        /// </summary>
        Asc,
        /// <summary>
        /// Newest first when `order_by` is `created_at`, or names in descending order when `order_by` is `name`. This is the default.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileListOrder value)
        {
            return value switch
            {
                UserProfileListOrder.Asc => "asc",
                UserProfileListOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileListOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => UserProfileListOrder.Asc,
                "desc" => UserProfileListOrder.Desc,
                _ => null,
            };
        }
    }
}