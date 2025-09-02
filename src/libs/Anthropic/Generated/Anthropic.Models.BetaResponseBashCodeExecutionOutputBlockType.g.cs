
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: bash_code_execution_output
    /// </summary>
    public enum BetaResponseBashCodeExecutionOutputBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseBashCodeExecutionOutputBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseBashCodeExecutionOutputBlockType value)
        {
            return value switch
            {
                BetaResponseBashCodeExecutionOutputBlockType.BashCodeExecutionOutput => "bash_code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseBashCodeExecutionOutputBlockType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_output" => BetaResponseBashCodeExecutionOutputBlockType.BashCodeExecutionOutput,
                _ => null,
            };
        }
    }
}