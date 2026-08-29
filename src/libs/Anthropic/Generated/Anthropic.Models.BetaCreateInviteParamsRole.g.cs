
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Role for the invited User.<br/>
    /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`.
    /// </summary>
    public enum BetaCreateInviteParamsRole
    {
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
        Managed,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCreateInviteParamsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCreateInviteParamsRole value)
        {
            return value switch
            {
                BetaCreateInviteParamsRole.Billing => "billing",
                BetaCreateInviteParamsRole.ClaudeCodeUser => "claude_code_user",
                BetaCreateInviteParamsRole.Developer => "developer",
                BetaCreateInviteParamsRole.Managed => "managed",
                BetaCreateInviteParamsRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCreateInviteParamsRole? ToEnum(string value)
        {
            return value switch
            {
                "billing" => BetaCreateInviteParamsRole.Billing,
                "claude_code_user" => BetaCreateInviteParamsRole.ClaudeCodeUser,
                "developer" => BetaCreateInviteParamsRole.Developer,
                "managed" => BetaCreateInviteParamsRole.Managed,
                "user" => BetaCreateInviteParamsRole.User,
                _ => null,
            };
        }
    }
}