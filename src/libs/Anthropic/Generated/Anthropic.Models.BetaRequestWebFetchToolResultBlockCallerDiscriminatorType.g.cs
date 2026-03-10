
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestWebFetchToolResultBlockCallerDiscriminatorType
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
    public static class BetaRequestWebFetchToolResultBlockCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestWebFetchToolResultBlockCallerDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestWebFetchToolResultBlockCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                BetaRequestWebFetchToolResultBlockCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                BetaRequestWebFetchToolResultBlockCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestWebFetchToolResultBlockCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => BetaRequestWebFetchToolResultBlockCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => BetaRequestWebFetchToolResultBlockCallerDiscriminatorType.CodeExecution20260120,
                "direct" => BetaRequestWebFetchToolResultBlockCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}