
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestBashCodeExecutionResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestBashCodeExecutionResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestBashCodeExecutionResultBlockType value)
        {
            return value switch
            {
                BetaRequestBashCodeExecutionResultBlockType.BashCodeExecutionResult => "bash_code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestBashCodeExecutionResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_result" => BetaRequestBashCodeExecutionResultBlockType.BashCodeExecutionResult,
                _ => null,
            };
        }
    }
}