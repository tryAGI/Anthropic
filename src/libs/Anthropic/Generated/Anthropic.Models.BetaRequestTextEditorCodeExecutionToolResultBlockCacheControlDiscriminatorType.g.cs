
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlDiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaRequestTextEditorCodeExecutionToolResultBlockCacheControlDiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}