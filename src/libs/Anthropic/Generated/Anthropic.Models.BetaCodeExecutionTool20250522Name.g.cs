
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in `tool_use` blocks.
    /// </summary>
    public enum BetaCodeExecutionTool20250522Name
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeExecutionTool20250522NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeExecutionTool20250522Name value)
        {
            return value switch
            {
                BetaCodeExecutionTool20250522Name.CodeExecution => "code_execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeExecutionTool20250522Name? ToEnum(string value)
        {
            return value switch
            {
                "code_execution" => BetaCodeExecutionTool20250522Name.CodeExecution,
                _ => null,
            };
        }
    }
}