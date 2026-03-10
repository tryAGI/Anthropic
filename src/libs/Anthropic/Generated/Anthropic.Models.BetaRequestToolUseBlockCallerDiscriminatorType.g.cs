
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestToolUseBlockCallerDiscriminatorType
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
    public static class BetaRequestToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                BetaRequestToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                BetaRequestToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaRequestToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => BetaRequestToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => BetaRequestToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}