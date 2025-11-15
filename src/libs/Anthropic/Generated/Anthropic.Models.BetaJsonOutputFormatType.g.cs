
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaJsonOutputFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaJsonOutputFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaJsonOutputFormatType value)
        {
            return value switch
            {
                BetaJsonOutputFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaJsonOutputFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => BetaJsonOutputFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}