
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestCodeExecutionResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestCodeExecutionResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestCodeExecutionResultBlockType value)
        {
            return value switch
            {
                BetaRequestCodeExecutionResultBlockType.CodeExecutionResult => "code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestCodeExecutionResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_result" => BetaRequestCodeExecutionResultBlockType.CodeExecutionResult,
                _ => null,
            };
        }
    }
}