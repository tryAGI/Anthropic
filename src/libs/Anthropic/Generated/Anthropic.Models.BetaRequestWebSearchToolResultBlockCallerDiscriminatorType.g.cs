
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebSearchToolResultBlockCallerDiscriminatorType
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
    public static class BetaRequestWebSearchToolResultBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebSearchToolResultBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                BetaRequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                BetaRequestWebSearchToolResultBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebSearchToolResultBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaRequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => BetaRequestWebSearchToolResultBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => BetaRequestWebSearchToolResultBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}