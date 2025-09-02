
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestBashCodeExecutionOutputBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestBashCodeExecutionOutputBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestBashCodeExecutionOutputBlockType value)
        {
            return value switch
            {
                BetaRequestBashCodeExecutionOutputBlockType.BashCodeExecutionOutput => "bash_code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestBashCodeExecutionOutputBlockType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_output" => BetaRequestBashCodeExecutionOutputBlockType.BashCodeExecutionOutput,
                _ => null,
            };
        }
    }
}