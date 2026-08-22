
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSkillNotFoundDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SkillNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSkillNotFoundDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSkillNotFoundDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSkillNotFoundDeploymentPausedReasonErrorType.SkillNotFoundError => "skill_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSkillNotFoundDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "skill_not_found_error" => BetaManagedAgentsSkillNotFoundDeploymentPausedReasonErrorType.SkillNotFoundError,
                _ => null,
            };
        }
    }
}