
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType
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
    public static class BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType.SystemMessage => "system.message",
                BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType.UserDefineOutcome => "user.define_outcome",
                BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType.UserMessage => "user.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "system.message" => BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType.SystemMessage,
                "user.define_outcome" => BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType.UserDefineOutcome,
                "user.message" => BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType.UserMessage,
                _ => null,
            };
        }
    }
}