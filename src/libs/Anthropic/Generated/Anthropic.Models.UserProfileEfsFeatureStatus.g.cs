
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `active` when Anthropic has approved the entity the profile represents to use the feature, otherwise `inactive`. `active` does not mean that the feature is set up or switched on, which is a separate step.
    /// </summary>
    public enum UserProfileEfsFeatureStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileEfsFeatureStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileEfsFeatureStatus value)
        {
            return value switch
            {
                UserProfileEfsFeatureStatus.Active => "active",
                UserProfileEfsFeatureStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileEfsFeatureStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UserProfileEfsFeatureStatus.Active,
                "inactive" => UserProfileEfsFeatureStatus.Inactive,
                _ => null,
            };
        }
    }
}