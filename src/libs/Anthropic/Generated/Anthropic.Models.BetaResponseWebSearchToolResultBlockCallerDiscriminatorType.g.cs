
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseWebSearchToolResultBlockCallerDiscriminatorType
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
    public static class BetaResponseWebSearchToolResultBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchToolResultBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                BetaResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                BetaResponseWebSearchToolResultBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchToolResultBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => BetaResponseWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => BetaResponseWebSearchToolResultBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}