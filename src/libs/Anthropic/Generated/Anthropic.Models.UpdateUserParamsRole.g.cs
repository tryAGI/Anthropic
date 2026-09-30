
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// New role for the User.<br/>
    /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`.
    /// </summary>
    public enum UpdateUserParamsRole
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
    public static class UpdateUserParamsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateUserParamsRole value)
        {
            return value switch
            {
                UpdateUserParamsRole.Billing => "billing",
                UpdateUserParamsRole.ClaudeCodeUser => "claude_code_user",
                UpdateUserParamsRole.Developer => "developer",
                UpdateUserParamsRole.Managed => "managed",
                UpdateUserParamsRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateUserParamsRole? ToEnum(string value)
        {
            return value switch
            {
                "billing" => UpdateUserParamsRole.Billing,
                "claude_code_user" => UpdateUserParamsRole.ClaudeCodeUser,
                "developer" => UpdateUserParamsRole.Developer,
                "managed" => UpdateUserParamsRole.Managed,
                "user" => UpdateUserParamsRole.User,
                _ => null,
            };
        }
    }
}