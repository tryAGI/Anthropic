
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `active` when the tier applies to the profile, otherwise `inactive`. The response does not say why a tier is `inactive`: it can be in review, declined, withdrawn, never applied for, or approved but not applied to this profile.
    /// </summary>
    public enum UserProfileCyberTierStatus
    {
        /// <summary>
        /// it can be in review, declined, withdrawn, never applied for, or approved but not applied to this profile.
        /// </summary>
        Active,
        /// <summary>
        /// it can be in review, declined, withdrawn, never applied for, or approved but not applied to this profile.
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileCyberTierStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileCyberTierStatus value)
        {
            return value switch
            {
                UserProfileCyberTierStatus.Active => "active",
                UserProfileCyberTierStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileCyberTierStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UserProfileCyberTierStatus.Active,
                "inactive" => UserProfileCyberTierStatus.Inactive,
                _ => null,
            };
        }
    }
}