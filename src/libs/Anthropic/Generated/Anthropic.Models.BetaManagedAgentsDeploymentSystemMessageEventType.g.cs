
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeploymentSystemMessageEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeploymentSystemMessageEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentSystemMessageEventType value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentSystemMessageEventType.SystemMessage => "system.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentSystemMessageEventType? ToEnum(string value)
        {
            return value switch
            {
                "system.message" => BetaManagedAgentsDeploymentSystemMessageEventType.SystemMessage,
                _ => null,
            };
        }
    }
}