
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestMidConvSystemBlockCacheControlVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestMidConvSystemBlockCacheControlVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestMidConvSystemBlockCacheControlVariant1DiscriminatorType value)
        {
            return value switch
            {
                RequestMidConvSystemBlockCacheControlVariant1DiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestMidConvSystemBlockCacheControlVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => RequestMidConvSystemBlockCacheControlVariant1DiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}