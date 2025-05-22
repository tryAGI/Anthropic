
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCodeExecutionTool20250522Type
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250522,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeExecutionTool20250522TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeExecutionTool20250522Type value)
        {
            return value switch
            {
                BetaCodeExecutionTool20250522Type.CodeExecution20250522 => "code_execution_20250522",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeExecutionTool20250522Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250522" => BetaCodeExecutionTool20250522Type.CodeExecution20250522,
                _ => null,
            };
        }
    }
}