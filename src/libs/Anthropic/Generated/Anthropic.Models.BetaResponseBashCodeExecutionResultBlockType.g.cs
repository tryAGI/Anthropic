
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: bash_code_execution_result
    /// </summary>
    public enum BetaResponseBashCodeExecutionResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseBashCodeExecutionResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseBashCodeExecutionResultBlockType value)
        {
            return value switch
            {
                BetaResponseBashCodeExecutionResultBlockType.BashCodeExecutionResult => "bash_code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseBashCodeExecutionResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_result" => BetaResponseBashCodeExecutionResultBlockType.BashCodeExecutionResult,
                _ => null,
            };
        }
    }
}