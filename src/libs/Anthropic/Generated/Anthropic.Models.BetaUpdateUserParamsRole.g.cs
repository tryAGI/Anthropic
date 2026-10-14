
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// New role for the User.<br/>
    /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`; changing a User's role to `managed` requires the `write:rbac_groups` scope in addition to `write:members`.
    /// </summary>
    public enum BetaUpdateUserParamsRole
    {
        /// <summary>
        /// rbac_groups` scope in addition to `write:members`.
        /// </summary>
        Billing,
        /// <summary>
        /// rbac_groups` scope in addition to `write:members`.
        /// </summary>
        ClaudeCodeUser,
        /// <summary>
        /// rbac_groups` scope in addition to `write:members`.
        /// </summary>
        Developer,
        /// <summary>
        /// rbac_groups` scope in addition to `write:members`.
        /// </summary>
        Managed,
        /// <summary>
        /// rbac_groups` scope in addition to `write:members`.
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUpdateUserParamsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUpdateUserParamsRole value)
        {
            return value switch
            {
                BetaUpdateUserParamsRole.Billing => "billing",
                BetaUpdateUserParamsRole.ClaudeCodeUser => "claude_code_user",
                BetaUpdateUserParamsRole.Developer => "developer",
                BetaUpdateUserParamsRole.Managed => "managed",
                BetaUpdateUserParamsRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUpdateUserParamsRole? ToEnum(string value)
        {
            return value switch
            {
                "billing" => BetaUpdateUserParamsRole.Billing,
                "claude_code_user" => BetaUpdateUserParamsRole.ClaudeCodeUser,
                "developer" => BetaUpdateUserParamsRole.Developer,
                "managed" => BetaUpdateUserParamsRole.Managed,
                "user" => BetaUpdateUserParamsRole.User,
                _ => null,
            };
        }
    }
}