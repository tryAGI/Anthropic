
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}