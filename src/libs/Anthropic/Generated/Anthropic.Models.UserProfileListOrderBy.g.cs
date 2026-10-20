
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Sort field for listing user profiles: `created_at` (default) or `name` (case-insensitive; profiles without a name sort last).
    /// </summary>
    public enum UserProfileListOrderBy
    {
        /// <summary>
        /// Sort by when each user profile was created. This is the default.
        /// </summary>
        CreatedAt,
        /// <summary>
        /// Sort by `name`, ignoring the case of ASCII letters. Profiles without a name come last in either direction.
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileListOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileListOrderBy value)
        {
            return value switch
            {
                UserProfileListOrderBy.CreatedAt => "created_at",
                UserProfileListOrderBy.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileListOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => UserProfileListOrderBy.CreatedAt,
                "name" => UserProfileListOrderBy.Name,
                _ => null,
            };
        }
    }
}