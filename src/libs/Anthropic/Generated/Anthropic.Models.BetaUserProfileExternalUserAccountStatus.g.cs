
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The status of the entity's account on the platform, as the platform states it: `active`; `suspended`, when the platform has restricted the account and may restore it; or `blocked`, when the platform has barred it. It records the platform's decision only; the statuses in `trust_grants` are Anthropic's and do not follow it.
    /// </summary>
    public enum BetaUserProfileExternalUserAccountStatus
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
    public static class BetaUserProfileExternalUserAccountStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileExternalUserAccountStatus value)
        {
            return value switch
            {
                BetaUserProfileExternalUserAccountStatus.Active => "active",
                BetaUserProfileExternalUserAccountStatus.Blocked => "blocked",
                BetaUserProfileExternalUserAccountStatus.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileExternalUserAccountStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaUserProfileExternalUserAccountStatus.Active,
                "blocked" => BetaUserProfileExternalUserAccountStatus.Blocked,
                "suspended" => BetaUserProfileExternalUserAccountStatus.Suspended,
                _ => null,
            };
        }
    }
}