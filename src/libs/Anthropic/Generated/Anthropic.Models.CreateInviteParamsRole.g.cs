
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Role for the invited User.<br/>
    /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`.
    /// </summary>
    public enum CreateInviteParamsRole
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
    public static class CreateInviteParamsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInviteParamsRole value)
        {
            return value switch
            {
                CreateInviteParamsRole.Billing => "billing",
                CreateInviteParamsRole.ClaudeCodeUser => "claude_code_user",
                CreateInviteParamsRole.Developer => "developer",
                CreateInviteParamsRole.Managed => "managed",
                CreateInviteParamsRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInviteParamsRole? ToEnum(string value)
        {
            return value switch
            {
                "billing" => CreateInviteParamsRole.Billing,
                "claude_code_user" => CreateInviteParamsRole.ClaudeCodeUser,
                "developer" => CreateInviteParamsRole.Developer,
                "managed" => CreateInviteParamsRole.Managed,
                "user" => CreateInviteParamsRole.User,
                _ => null,
            };
        }
    }
}