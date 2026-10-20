
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum UserProfileActionDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        EnrollEndUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileActionDiscriminatorType value)
        {
            return value switch
            {
                UserProfileActionDiscriminatorType.EnrollEndUser => "enroll_end_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "enroll_end_user" => UserProfileActionDiscriminatorType.EnrollEndUser,
                _ => null,
            };
        }
    }
}