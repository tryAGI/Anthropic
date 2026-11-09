
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        CacheControl,
        /// <summary>
        ///
        /// </summary>
        ContextManagement,
        /// <summary>
        ///
        /// </summary>
        Fallbacks,
        /// <summary>
        ///
        /// </summary>
        Hipaa,
        /// <summary>
        ///
        /// </summary>
        InferenceHooks,
        /// <summary>
        ///
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item value)
        {
            return value switch
            {
                ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.CacheControl => "cache_control",
                ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.ContextManagement => "context_management",
                ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Fallbacks => "fallbacks",
                ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Hipaa => "hipaa",
                ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.InferenceHooks => "inference_hooks",
                ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "cache_control" => ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.CacheControl,
                "context_management" => ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.ContextManagement,
                "fallbacks" => ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Fallbacks,
                "hipaa" => ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Hipaa,
                "inference_hooks" => ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.InferenceHooks,
                "thinking" => ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Thinking,
                _ => null,
            };
        }
    }
}