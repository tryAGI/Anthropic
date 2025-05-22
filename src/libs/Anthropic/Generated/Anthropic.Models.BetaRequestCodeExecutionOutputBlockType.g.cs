
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestCodeExecutionOutputBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestCodeExecutionOutputBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestCodeExecutionOutputBlockType value)
        {
            return value switch
            {
                BetaRequestCodeExecutionOutputBlockType.CodeExecutionOutput => "code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestCodeExecutionOutputBlockType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_output" => BetaRequestCodeExecutionOutputBlockType.CodeExecutionOutput,
                _ => null,
            };
        }
    }
}