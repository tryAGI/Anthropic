
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Determines whether to use priority capacity (if available) or standard capacity for this request.<br/>
    /// Anthropic offers different levels of service for your API requests. See [service-tiers](https://docs.anthropic.com/en/api/service-tiers) for details.
    /// </summary>
    public enum CreateMessageParamsServiceTier
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
    public static class CreateMessageParamsServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageParamsServiceTier value)
        {
            return value switch
            {
                CreateMessageParamsServiceTier.Auto => "auto",
                CreateMessageParamsServiceTier.StandardOnly => "standard_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageParamsServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateMessageParamsServiceTier.Auto,
                "standard_only" => CreateMessageParamsServiceTier.StandardOnly,
                _ => null,
            };
        }
    }
}