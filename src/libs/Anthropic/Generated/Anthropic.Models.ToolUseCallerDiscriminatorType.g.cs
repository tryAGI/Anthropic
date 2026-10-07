
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolUseCallerDiscriminatorType
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
    public static class ToolUseCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolUseCallerDiscriminatorType value)
        {
            return value switch
            {
                ToolUseCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                ToolUseCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                ToolUseCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolUseCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => ToolUseCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => ToolUseCallerDiscriminatorType.CodeExecution20260120,
                "direct" => ToolUseCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}