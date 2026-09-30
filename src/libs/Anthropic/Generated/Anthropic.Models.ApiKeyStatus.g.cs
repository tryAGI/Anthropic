
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Status of the API key.
    /// </summary>
    public enum ApiKeyStatus
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
    public static class ApiKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyStatus value)
        {
            return value switch
            {
                ApiKeyStatus.Active => "active",
                ApiKeyStatus.Archived => "archived",
                ApiKeyStatus.Expired => "expired",
                ApiKeyStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ApiKeyStatus.Active,
                "archived" => ApiKeyStatus.Archived,
                "expired" => ApiKeyStatus.Expired,
                "inactive" => ApiKeyStatus.Inactive,
                _ => null,
            };
        }
    }
}