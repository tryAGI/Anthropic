
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Object form of ``fallback_credit_token``: the token plus a redemption<br/>
    /// mode.<br/>
    /// Requires ``anthropic-beta: fallback-credit-2026-07-01``; without that<br/>
    /// header the field accepts the bare string only. The bare string and the<br/>
    /// mode-less object are equivalent (both select ``strict``), so wrapping<br/>
    /// an existing token changes nothing by itself.
    /// </summary>
    public sealed partial class BetaFallbackCreditTokenParam
    {
        /// <summary>
        /// How a failing token affects the retry. `strict` (the default, and the bare-string behavior): a failing redemption is a 400 and the retry is not served. `best_effort`: the retry is served either way — a token-layer failure no longer rejects the request; the retry proceeds at normal price and the outcome is reported on the response's `usage.fallback_credit`. Two failures stay hard in both modes: a malformed token, and combining `fallback_credit_token` with `fallbacks`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaFallbackCreditTokenParamModeJsonConverter))]
        public global::Anthropic.BetaFallbackCreditTokenParamMode? Mode { get; set; }

        /// <summary>
        /// The opaque `fallback_credit_token` from a prior refusal's `stop_details` — the same string the bare-string form carries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditTokenParam" /> class.
        /// </summary>
        /// <param name="token">
        /// The opaque `fallback_credit_token` from a prior refusal's `stop_details` — the same string the bare-string form carries.
        /// </param>
        /// <param name="mode">
        /// How a failing token affects the retry. `strict` (the default, and the bare-string behavior): a failing redemption is a 400 and the retry is not served. `best_effort`: the retry is served either way — a token-layer failure no longer rejects the request; the retry proceeds at normal price and the outcome is reported on the response's `usage.fallback_credit`. Two failures stay hard in both modes: a malformed token, and combining `fallback_credit_token` with `fallbacks`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFallbackCreditTokenParam(
            string token,
            global::Anthropic.BetaFallbackCreditTokenParamMode? mode)
        {
            this.Mode = mode;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditTokenParam" /> class.
        /// </summary>
        public BetaFallbackCreditTokenParam()
        {
        }

    }
}