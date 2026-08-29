
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApiKeyUpdateParamsStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
        /// <summary>
        ///
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApiKeyUpdateParamsStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApiKeyUpdateParamsStatus2 value)
        {
            return value switch
            {
                BetaApiKeyUpdateParamsStatus2.Active => "active",
                BetaApiKeyUpdateParamsStatus2.Archived => "archived",
                BetaApiKeyUpdateParamsStatus2.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApiKeyUpdateParamsStatus2? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaApiKeyUpdateParamsStatus2.Active,
                "archived" => BetaApiKeyUpdateParamsStatus2.Archived,
                "inactive" => BetaApiKeyUpdateParamsStatus2.Inactive,
                _ => null,
            };
        }
    }
}