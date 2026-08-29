
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRoleSchema
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Billing,
        /// <summary>
        ///
        /// </summary>
        ClaudeCodeUser,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRoleSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRoleSchema value)
        {
            return value switch
            {
                BetaRoleSchema.Admin => "admin",
                BetaRoleSchema.Billing => "billing",
                BetaRoleSchema.ClaudeCodeUser => "claude_code_user",
                BetaRoleSchema.Developer => "developer",
                BetaRoleSchema.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRoleSchema? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BetaRoleSchema.Admin,
                "billing" => BetaRoleSchema.Billing,
                "claude_code_user" => BetaRoleSchema.ClaudeCodeUser,
                "developer" => BetaRoleSchema.Developer,
                "user" => BetaRoleSchema.User,
                _ => null,
            };
        }
    }
}