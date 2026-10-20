
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaUserProfileActionDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        EnrollEndUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserProfileActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileActionDiscriminatorType value)
        {
            return value switch
            {
                BetaUserProfileActionDiscriminatorType.EnrollEndUser => "enroll_end_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "enroll_end_user" => BetaUserProfileActionDiscriminatorType.EnrollEndUser,
                _ => null,
            };
        }
    }
}