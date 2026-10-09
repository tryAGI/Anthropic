
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsWorkflowRunResultDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsWorkflowRunResultDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsWorkflowRunResultDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsWorkflowRunResultDiscriminatorType.Completed => "completed",
                BetaManagedAgentsWorkflowRunResultDiscriminatorType.Error => "error",
                BetaManagedAgentsWorkflowRunResultDiscriminatorType.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsWorkflowRunResultDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaManagedAgentsWorkflowRunResultDiscriminatorType.Completed,
                "error" => BetaManagedAgentsWorkflowRunResultDiscriminatorType.Error,
                "stopped" => BetaManagedAgentsWorkflowRunResultDiscriminatorType.Stopped,
                _ => null,
            };
        }
    }
}