
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseServerToolUseBlockCallerDiscriminatorType
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
    public static class BetaResponseServerToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseServerToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                BetaResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                BetaResponseServerToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseServerToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => BetaResponseServerToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => BetaResponseServerToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}