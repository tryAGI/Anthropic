
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestServerToolUseBlockCallerDiscriminatorType
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
    public static class RequestServerToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestServerToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                RequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                RequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                RequestServerToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestServerToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => RequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => RequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => RequestServerToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}