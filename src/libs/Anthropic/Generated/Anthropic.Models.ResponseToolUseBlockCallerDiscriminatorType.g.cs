
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseToolUseBlockCallerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250825,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20260120,
        /// <summary>
        /// 
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                ResponseToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                ResponseToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                ResponseToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => ResponseToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => ResponseToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => ResponseToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}