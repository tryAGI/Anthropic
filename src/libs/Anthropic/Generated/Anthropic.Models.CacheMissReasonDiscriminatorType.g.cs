
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum CacheMissReasonDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        MessagesChanged,
        /// <summary>
        ///
        /// </summary>
        ModelChanged,
        /// <summary>
        ///
        /// </summary>
        PreviousMessageNotFound,
        /// <summary>
        ///
        /// </summary>
        SystemChanged,
        /// <summary>
        ///
        /// </summary>
        ToolsChanged,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CacheMissReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CacheMissReasonDiscriminatorType value)
        {
            return value switch
            {
                CacheMissReasonDiscriminatorType.MessagesChanged => "messages_changed",
                CacheMissReasonDiscriminatorType.ModelChanged => "model_changed",
                CacheMissReasonDiscriminatorType.PreviousMessageNotFound => "previous_message_not_found",
                CacheMissReasonDiscriminatorType.SystemChanged => "system_changed",
                CacheMissReasonDiscriminatorType.ToolsChanged => "tools_changed",
                CacheMissReasonDiscriminatorType.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CacheMissReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "messages_changed" => CacheMissReasonDiscriminatorType.MessagesChanged,
                "model_changed" => CacheMissReasonDiscriminatorType.ModelChanged,
                "previous_message_not_found" => CacheMissReasonDiscriminatorType.PreviousMessageNotFound,
                "system_changed" => CacheMissReasonDiscriminatorType.SystemChanged,
                "tools_changed" => CacheMissReasonDiscriminatorType.ToolsChanged,
                "unavailable" => CacheMissReasonDiscriminatorType.Unavailable,
                _ => null,
            };
        }
    }
}