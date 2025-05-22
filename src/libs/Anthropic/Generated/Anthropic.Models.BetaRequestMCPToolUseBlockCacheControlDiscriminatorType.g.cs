
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestMCPToolUseBlockCacheControlDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestMCPToolUseBlockCacheControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestMCPToolUseBlockCacheControlDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestMCPToolUseBlockCacheControlDiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestMCPToolUseBlockCacheControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaRequestMCPToolUseBlockCacheControlDiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}