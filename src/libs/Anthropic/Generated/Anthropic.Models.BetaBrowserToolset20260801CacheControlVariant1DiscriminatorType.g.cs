
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBrowserToolset20260801CacheControlVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaBrowserToolset20260801CacheControlVariant1DiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}