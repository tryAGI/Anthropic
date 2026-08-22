
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeploymentUserDefineOutcomeEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserDefineOutcome,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeploymentUserDefineOutcomeEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentUserDefineOutcomeEventType value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentUserDefineOutcomeEventType.UserDefineOutcome => "user.define_outcome",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentUserDefineOutcomeEventType? ToEnum(string value)
        {
            return value switch
            {
                "user.define_outcome" => BetaManagedAgentsDeploymentUserDefineOutcomeEventType.UserDefineOutcome,
                _ => null,
            };
        }
    }
}