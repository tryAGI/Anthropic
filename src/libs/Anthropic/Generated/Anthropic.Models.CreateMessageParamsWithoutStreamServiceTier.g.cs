
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Determines whether to use priority capacity (if available) or standard capacity for this request.<br/>
    /// Anthropic offers different levels of service for your API requests. See [service-tiers](https://docs.claude.com/en/api/service-tiers) for details.
    /// </summary>
    public enum CreateMessageParamsWithoutStreamServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        StandardOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageParamsWithoutStreamServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageParamsWithoutStreamServiceTier value)
        {
            return value switch
            {
                CreateMessageParamsWithoutStreamServiceTier.Auto => "auto",
                CreateMessageParamsWithoutStreamServiceTier.StandardOnly => "standard_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageParamsWithoutStreamServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateMessageParamsWithoutStreamServiceTier.Auto,
                "standard_only" => CreateMessageParamsWithoutStreamServiceTier.StandardOnly,
                _ => null,
            };
        }
    }
}