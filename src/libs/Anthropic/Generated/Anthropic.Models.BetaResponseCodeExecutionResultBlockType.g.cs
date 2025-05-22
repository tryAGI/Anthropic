
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: code_execution_result
    /// </summary>
    public enum BetaResponseCodeExecutionResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeExecutionResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeExecutionResultBlockType value)
        {
            return value switch
            {
                BetaResponseCodeExecutionResultBlockType.CodeExecutionResult => "code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeExecutionResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_result" => BetaResponseCodeExecutionResultBlockType.CodeExecutionResult,
                _ => null,
            };
        }
    }
}