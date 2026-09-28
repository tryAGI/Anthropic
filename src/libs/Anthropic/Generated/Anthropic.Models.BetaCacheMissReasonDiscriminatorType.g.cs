
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCacheMissReasonDiscriminatorType
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
    public static class BetaCacheMissReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCacheMissReasonDiscriminatorType value)
        {
            return value switch
            {
                BetaCacheMissReasonDiscriminatorType.MessagesChanged => "messages_changed",
                BetaCacheMissReasonDiscriminatorType.ModelChanged => "model_changed",
                BetaCacheMissReasonDiscriminatorType.PreviousMessageNotFound => "previous_message_not_found",
                BetaCacheMissReasonDiscriminatorType.SystemChanged => "system_changed",
                BetaCacheMissReasonDiscriminatorType.ToolsChanged => "tools_changed",
                BetaCacheMissReasonDiscriminatorType.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCacheMissReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "messages_changed" => BetaCacheMissReasonDiscriminatorType.MessagesChanged,
                "model_changed" => BetaCacheMissReasonDiscriminatorType.ModelChanged,
                "previous_message_not_found" => BetaCacheMissReasonDiscriminatorType.PreviousMessageNotFound,
                "system_changed" => BetaCacheMissReasonDiscriminatorType.SystemChanged,
                "tools_changed" => BetaCacheMissReasonDiscriminatorType.ToolsChanged,
                "unavailable" => BetaCacheMissReasonDiscriminatorType.Unavailable,
                _ => null,
            };
        }
    }
}