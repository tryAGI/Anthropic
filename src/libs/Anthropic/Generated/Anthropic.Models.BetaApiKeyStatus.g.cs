
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Status of the API key.
    /// </summary>
    public enum BetaApiKeyStatus
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
        Expired,
        /// <summary>
        ///
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApiKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApiKeyStatus value)
        {
            return value switch
            {
                BetaApiKeyStatus.Active => "active",
                BetaApiKeyStatus.Archived => "archived",
                BetaApiKeyStatus.Expired => "expired",
                BetaApiKeyStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApiKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaApiKeyStatus.Active,
                "archived" => BetaApiKeyStatus.Archived,
                "expired" => BetaApiKeyStatus.Expired,
                "inactive" => BetaApiKeyStatus.Inactive,
                _ => null,
            };
        }
    }
}