
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How a failing token affects the retry. `strict` (the default, and the bare-string behavior): a failing redemption is a 400 and the retry is not served. `best_effort`: the retry is served either way — a token-layer failure no longer rejects the request; the retry proceeds at normal price and the outcome is reported on the response's `usage.fallback_credit`. Two failures stay hard in both modes: a malformed token, and combining `fallback_credit_token` with `fallbacks`.
    /// </summary>
    public enum BetaFallbackCreditTokenParamMode
    {
        /// <summary>
        /// a failing redemption is a 400 and the retry is not served. `best_effort`: the retry is served either way — a token-layer failure no longer rejects the request; the retry proceeds at normal price and the outcome is reported on the response's `usage.fallback_credit`. Two failures stay hard in both modes: a malformed token, and combining `fallback_credit_token` with `fallbacks`.
        /// </summary>
        BestEffort,
        /// <summary>
        /// a failing redemption is a 400 and the retry is not served. `best_effort`: the retry is served either way — a token-layer failure no longer rejects the request; the retry proceeds at normal price and the outcome is reported on the response's `usage.fallback_credit`. Two failures stay hard in both modes: a malformed token, and combining `fallback_credit_token` with `fallbacks`.
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFallbackCreditTokenParamModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFallbackCreditTokenParamMode value)
        {
            return value switch
            {
                BetaFallbackCreditTokenParamMode.BestEffort => "best_effort",
                BetaFallbackCreditTokenParamMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFallbackCreditTokenParamMode? ToEnum(string value)
        {
            return value switch
            {
                "best_effort" => BetaFallbackCreditTokenParamMode.BestEffort,
                "strict" => BetaFallbackCreditTokenParamMode.Strict,
                _ => null,
            };
        }
    }
}