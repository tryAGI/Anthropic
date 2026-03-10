
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestToolUseBlockCallerDiscriminatorType
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
    public static class RequestToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                RequestToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                RequestToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                RequestToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => RequestToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => RequestToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => RequestToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}