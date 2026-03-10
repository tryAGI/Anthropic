
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebSearchToolResultBlockCallerDiscriminatorType
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
    public static class ResponseWebSearchToolResultBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebSearchToolResultBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                ResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                ResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                ResponseWebSearchToolResultBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebSearchToolResultBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => ResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => ResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => ResponseWebSearchToolResultBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}