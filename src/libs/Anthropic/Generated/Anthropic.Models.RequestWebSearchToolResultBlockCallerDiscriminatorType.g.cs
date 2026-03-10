
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestWebSearchToolResultBlockCallerDiscriminatorType
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
    public static class RequestWebSearchToolResultBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestWebSearchToolResultBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                RequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                RequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                RequestWebSearchToolResultBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestWebSearchToolResultBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => RequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => RequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => RequestWebSearchToolResultBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}