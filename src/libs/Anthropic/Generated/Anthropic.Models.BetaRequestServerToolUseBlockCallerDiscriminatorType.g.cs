
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestServerToolUseBlockCallerDiscriminatorType
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
    public static class BetaRequestServerToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestServerToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                BetaRequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                BetaRequestServerToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestServerToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaRequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => BetaRequestServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => BetaRequestServerToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}