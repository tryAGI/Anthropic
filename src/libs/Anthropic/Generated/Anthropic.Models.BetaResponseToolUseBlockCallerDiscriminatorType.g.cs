
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseToolUseBlockCallerDiscriminatorType
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
    public static class BetaResponseToolUseBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseToolUseBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseToolUseBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                BetaResponseToolUseBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                BetaResponseToolUseBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseToolUseBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaResponseToolUseBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => BetaResponseToolUseBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => BetaResponseToolUseBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}