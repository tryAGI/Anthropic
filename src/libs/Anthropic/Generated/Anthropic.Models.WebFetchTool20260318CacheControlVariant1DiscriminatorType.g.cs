
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebFetchTool20260318CacheControlVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchTool20260318CacheControlVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchTool20260318CacheControlVariant1DiscriminatorType value)
        {
            return value switch
            {
                WebFetchTool20260318CacheControlVariant1DiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchTool20260318CacheControlVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => WebFetchTool20260318CacheControlVariant1DiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}