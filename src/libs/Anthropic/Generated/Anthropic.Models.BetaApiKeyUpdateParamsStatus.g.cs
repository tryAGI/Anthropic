
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApiKeyUpdateParamsStatus
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
    public static class BetaApiKeyUpdateParamsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApiKeyUpdateParamsStatus value)
        {
            return value switch
            {
                BetaApiKeyUpdateParamsStatus.Active => "active",
                BetaApiKeyUpdateParamsStatus.Archived => "archived",
                BetaApiKeyUpdateParamsStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApiKeyUpdateParamsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaApiKeyUpdateParamsStatus.Active,
                "archived" => BetaApiKeyUpdateParamsStatus.Archived,
                "inactive" => BetaApiKeyUpdateParamsStatus.Inactive,
                _ => null,
            };
        }
    }
}