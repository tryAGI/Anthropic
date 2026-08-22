
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType
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
    public static class BetaDiagnosticsCacheMissReasonVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.MessagesChanged => "messages_changed",
                BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.ModelChanged => "model_changed",
                BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.PreviousMessageNotFound => "previous_message_not_found",
                BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.SystemChanged => "system_changed",
                BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.ToolsChanged => "tools_changed",
                BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "messages_changed" => BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.MessagesChanged,
                "model_changed" => BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.ModelChanged,
                "previous_message_not_found" => BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.PreviousMessageNotFound,
                "system_changed" => BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.SystemChanged,
                "tools_changed" => BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.ToolsChanged,
                "unavailable" => BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.Unavailable,
                _ => null,
            };
        }
    }
}