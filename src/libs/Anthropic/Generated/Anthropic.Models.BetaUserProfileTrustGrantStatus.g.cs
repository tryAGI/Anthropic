
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Status of the trust grant.
    /// </summary>
    public enum BetaUserProfileTrustGrantStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserProfileTrustGrantStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileTrustGrantStatus value)
        {
            return value switch
            {
                BetaUserProfileTrustGrantStatus.Active => "active",
                BetaUserProfileTrustGrantStatus.Pending => "pending",
                BetaUserProfileTrustGrantStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileTrustGrantStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaUserProfileTrustGrantStatus.Active,
                "pending" => BetaUserProfileTrustGrantStatus.Pending,
                "rejected" => BetaUserProfileTrustGrantStatus.Rejected,
                _ => null,
            };
        }
    }
}