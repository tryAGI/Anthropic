
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: code_execution_output
    /// </summary>
    public enum BetaResponseCodeExecutionOutputBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeExecutionOutputBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeExecutionOutputBlockType value)
        {
            return value switch
            {
                BetaResponseCodeExecutionOutputBlockType.CodeExecutionOutput => "code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeExecutionOutputBlockType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_output" => BetaResponseCodeExecutionOutputBlockType.CodeExecutionOutput,
                _ => null,
            };
        }
    }
}