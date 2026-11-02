
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item
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
        /// <summary>
        ///
        /// </summary>
        Zdr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item value)
        {
            return value switch
            {
                BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.CacheControl => "cache_control",
                BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.ContextManagement => "context_management",
                BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Fallbacks => "fallbacks",
                BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Hipaa => "hipaa",
                BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.InferenceHooks => "inference_hooks",
                BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Thinking => "thinking",
                BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Zdr => "zdr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "cache_control" => BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.CacheControl,
                "context_management" => BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.ContextManagement,
                "fallbacks" => BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Fallbacks,
                "hipaa" => BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Hipaa,
                "inference_hooks" => BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.InferenceHooks,
                "thinking" => BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Thinking,
                "zdr" => BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item.Zdr,
                _ => null,
            };
        }
    }
}