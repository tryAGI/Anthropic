
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Sort field for listing user profiles: `created_at` (default) or `name` (case-insensitive; profiles without a name sort last).
    /// </summary>
    public enum BetaUserProfileListOrderBy
    {
        /// <summary>
        /// `created_at` (default) or `name` (case-insensitive; profiles without a name sort last).
        /// </summary>
        CreatedAt,
        /// <summary>
        /// `created_at` (default) or `name` (case-insensitive; profiles without a name sort last).
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserProfileListOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileListOrderBy value)
        {
            return value switch
            {
                BetaUserProfileListOrderBy.CreatedAt => "created_at",
                BetaUserProfileListOrderBy.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileListOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => BetaUserProfileListOrderBy.CreatedAt,
                "name" => BetaUserProfileListOrderBy.Name,
                _ => null,
            };
        }
    }
}