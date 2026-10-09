
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsWorkflowRunErrorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        MaxWorkflowRunsError,
        /// <summary>
        ///
        /// </summary>
        ProgramError,
        /// <summary>
        ///
        /// </summary>
        ThreadLimitError,
        /// <summary>
        ///
        /// </summary>
        TimeoutError,
        /// <summary>
        ///
        /// </summary>
        UnknownError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsWorkflowRunErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsWorkflowRunErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsWorkflowRunErrorDiscriminatorType.MaxWorkflowRunsError => "max_workflow_runs_error",
                BetaManagedAgentsWorkflowRunErrorDiscriminatorType.ProgramError => "program_error",
                BetaManagedAgentsWorkflowRunErrorDiscriminatorType.ThreadLimitError => "thread_limit_error",
                BetaManagedAgentsWorkflowRunErrorDiscriminatorType.TimeoutError => "timeout_error",
                BetaManagedAgentsWorkflowRunErrorDiscriminatorType.UnknownError => "unknown_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsWorkflowRunErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "max_workflow_runs_error" => BetaManagedAgentsWorkflowRunErrorDiscriminatorType.MaxWorkflowRunsError,
                "program_error" => BetaManagedAgentsWorkflowRunErrorDiscriminatorType.ProgramError,
                "thread_limit_error" => BetaManagedAgentsWorkflowRunErrorDiscriminatorType.ThreadLimitError,
                "timeout_error" => BetaManagedAgentsWorkflowRunErrorDiscriminatorType.TimeoutError,
                "unknown_error" => BetaManagedAgentsWorkflowRunErrorDiscriminatorType.UnknownError,
                _ => null,
            };
        }
    }
}