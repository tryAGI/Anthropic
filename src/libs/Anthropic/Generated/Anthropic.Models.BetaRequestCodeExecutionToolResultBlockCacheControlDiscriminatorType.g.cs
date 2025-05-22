
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}