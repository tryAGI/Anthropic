
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestMCPServerURLDefinitionType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestMCPServerURLDefinitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestMCPServerURLDefinitionType value)
        {
            return value switch
            {
                BetaRequestMCPServerURLDefinitionType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestMCPServerURLDefinitionType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaRequestMCPServerURLDefinitionType.Url,
                _ => null,
            };
        }
    }
}