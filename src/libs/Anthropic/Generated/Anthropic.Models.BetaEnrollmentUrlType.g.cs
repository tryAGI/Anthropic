
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Object type. Always `enrollment_url`.
    /// </summary>
    public enum BetaEnrollmentUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        EnrollmentUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaEnrollmentUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEnrollmentUrlType value)
        {
            return value switch
            {
                BetaEnrollmentUrlType.EnrollmentUrl => "enrollment_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEnrollmentUrlType? ToEnum(string value)
        {
            return value switch
            {
                "enrollment_url" => BetaEnrollmentUrlType.EnrollmentUrl,
                _ => null,
            };
        }
    }
}