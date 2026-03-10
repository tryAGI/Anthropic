
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseServerToolUseBlockCallerDiscriminatorType
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
    public static class ResponseServerToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseServerToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                ResponseServerToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseServerToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => ResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => ResponseServerToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}