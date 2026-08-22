
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsErrorDeploymentPausedReasonType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsErrorDeploymentPausedReasonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsErrorDeploymentPausedReasonType value)
        {
            return value switch
            {
                BetaManagedAgentsErrorDeploymentPausedReasonType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsErrorDeploymentPausedReasonType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaManagedAgentsErrorDeploymentPausedReasonType.Error,
                _ => null,
            };
        }
    }
}