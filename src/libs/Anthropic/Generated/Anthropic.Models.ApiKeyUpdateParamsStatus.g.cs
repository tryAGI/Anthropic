
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiKeyUpdateParamsStatus
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
    public static class ApiKeyUpdateParamsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyUpdateParamsStatus value)
        {
            return value switch
            {
                ApiKeyUpdateParamsStatus.Active => "active",
                ApiKeyUpdateParamsStatus.Archived => "archived",
                ApiKeyUpdateParamsStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyUpdateParamsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ApiKeyUpdateParamsStatus.Active,
                "archived" => ApiKeyUpdateParamsStatus.Archived,
                "inactive" => ApiKeyUpdateParamsStatus.Inactive,
                _ => null,
            };
        }
    }
}