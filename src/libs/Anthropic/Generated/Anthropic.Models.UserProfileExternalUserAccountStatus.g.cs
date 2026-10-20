
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The status of the entity's account on the platform, as the platform states it: `active`; `suspended`, when the platform has restricted the account and may restore it; or `blocked`, when the platform has barred it. It records the platform's decision only. The statuses that Anthropic itself reports for the profile, such as its status in a program, are Anthropic's decisions and do not change with it.
    /// </summary>
    public enum UserProfileExternalUserAccountStatus
    {
        /// <summary>
        /// The platform has neither restricted nor barred the account of the entity that the user profile represents.
        /// </summary>
        Active,
        /// <summary>
        /// The platform has barred the account of the entity that the user profile represents.
        /// </summary>
        Blocked,
        /// <summary>
        /// The platform has restricted the account of the entity that the user profile represents and may restore it.
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileExternalUserAccountStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileExternalUserAccountStatus value)
        {
            return value switch
            {
                UserProfileExternalUserAccountStatus.Active => "active",
                UserProfileExternalUserAccountStatus.Blocked => "blocked",
                UserProfileExternalUserAccountStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileExternalUserAccountStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UserProfileExternalUserAccountStatus.Active,
                "blocked" => UserProfileExternalUserAccountStatus.Blocked,
                "suspended" => UserProfileExternalUserAccountStatus.Suspended,
                _ => null,
            };
        }
    }
}