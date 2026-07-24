
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsManualDeploymentPausedReasonType
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsManualDeploymentPausedReasonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsManualDeploymentPausedReasonType value)
        {
            return value switch
            {
                BetaManagedAgentsManualDeploymentPausedReasonType.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsManualDeploymentPausedReasonType? ToEnum(string value)
        {
            return value switch
            {
                "manual" => BetaManagedAgentsManualDeploymentPausedReasonType.Manual,
                _ => null,
            };
        }
    }
}