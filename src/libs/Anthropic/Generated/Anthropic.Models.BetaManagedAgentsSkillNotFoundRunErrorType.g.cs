
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSkillNotFoundRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SkillNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSkillNotFoundRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSkillNotFoundRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSkillNotFoundRunErrorType.SkillNotFoundError => "skill_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSkillNotFoundRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "skill_not_found_error" => BetaManagedAgentsSkillNotFoundRunErrorType.SkillNotFoundError,
                _ => null,
            };
        }
    }
}