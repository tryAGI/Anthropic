
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeploymentInitialEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemMessage,
        /// <summary>
        /// 
        /// </summary>
        UserDefineOutcome,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeploymentInitialEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentInitialEventDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentInitialEventDiscriminatorType.SystemMessage => "system.message",
                BetaManagedAgentsDeploymentInitialEventDiscriminatorType.UserDefineOutcome => "user.define_outcome",
                BetaManagedAgentsDeploymentInitialEventDiscriminatorType.UserMessage => "user.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "system.message" => BetaManagedAgentsDeploymentInitialEventDiscriminatorType.SystemMessage,
                "user.define_outcome" => BetaManagedAgentsDeploymentInitialEventDiscriminatorType.UserDefineOutcome,
                "user.message" => BetaManagedAgentsDeploymentInitialEventDiscriminatorType.UserMessage,
                _ => null,
            };
        }
    }
}