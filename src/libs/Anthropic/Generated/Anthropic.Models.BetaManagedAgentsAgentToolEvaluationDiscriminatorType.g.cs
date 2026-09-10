
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsAgentToolEvaluationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AlwaysAllow,
        /// <summary>
        ///
        /// </summary>
        AlwaysAsk,
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentToolEvaluationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolEvaluationDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolEvaluationDiscriminatorType.AlwaysAllow => "always_allow",
                BetaManagedAgentsAgentToolEvaluationDiscriminatorType.AlwaysAsk => "always_ask",
                BetaManagedAgentsAgentToolEvaluationDiscriminatorType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolEvaluationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "always_allow" => BetaManagedAgentsAgentToolEvaluationDiscriminatorType.AlwaysAllow,
                "always_ask" => BetaManagedAgentsAgentToolEvaluationDiscriminatorType.AlwaysAsk,
                "auto" => BetaManagedAgentsAgentToolEvaluationDiscriminatorType.Auto,
                _ => null,
            };
        }
    }
}