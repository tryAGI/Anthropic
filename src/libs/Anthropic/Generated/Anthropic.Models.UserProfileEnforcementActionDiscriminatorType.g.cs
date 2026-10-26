
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum UserProfileEnforcementActionDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Ban,
        /// <summary>
        ///
        /// </summary>
        Restriction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileEnforcementActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileEnforcementActionDiscriminatorType value)
        {
            return value switch
            {
                UserProfileEnforcementActionDiscriminatorType.Ban => "ban",
                UserProfileEnforcementActionDiscriminatorType.Restriction => "restriction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileEnforcementActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ban" => UserProfileEnforcementActionDiscriminatorType.Ban,
                "restriction" => UserProfileEnforcementActionDiscriminatorType.Restriction,
                _ => null,
            };
        }
    }
}