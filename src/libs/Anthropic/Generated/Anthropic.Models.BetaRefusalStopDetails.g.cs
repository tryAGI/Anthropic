
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Structured information about a refusal.
    /// </summary>
    public sealed partial class BetaRefusalStopDetails
    {
        /// <summary>
        /// The policy category that triggered the refusal.<br/>
        /// `null` when the refusal doesn't map to a named category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Anthropic.BetaRefusalCategory? Category { get; set; }

        /// <summary>
        /// Human-readable explanation of the refusal.<br/>
        /// This text is not guaranteed to be stable. `null` when no explanation is available for the category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// Opaque code that refunds the cache-miss cost when retrying this refused<br/>
        /// request on the fallback model. Pass it as `fallback_credit_token` on the<br/>
        /// retry request. Expires 5 minutes after the refusal.<br/>
        /// The retry is sent either with the same request body (`system`, `messages`,<br/>
        /// `tools`, and other render-shaping fields), or with the same body plus one<br/>
        /// appended `assistant` message whose content is the partial text (with any<br/>
        /// trailing whitespace stripped from the final text block) and paired<br/>
        /// server-tool blocks from this refusal — which also authorizes that<br/>
        /// appended turn as an assistant-prefill continuation on models that otherwise<br/>
        /// disallow prefill. A token minted mid-server-tool-loop whose partial content<br/>
        /// was continuable may only be redeemed the second way — if a same-body retry<br/>
        /// is rejected with a 400 saying the token must be redeemed by continuing the<br/>
        /// partial response, retry the second way instead. Either way: same workspace,<br/>
        /// same platform; a mismatch is a 400. Resending a token for an already-warm<br/>
        /// prefix is permitted but yields no additional credit.<br/>
        /// `null` when the refused model isn't eligible for a fallback credit.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_credit_token")]
        public string? FallbackCreditToken { get; set; }

        /// <summary>
        /// Whether the accompanying `fallback_credit_token` may be redeemed with the<br/>
        /// appended-assistant retry form. Only set when `fallback_credit_token` is<br/>
        /// present.<br/>
        /// `true`: retry by resending the same request body plus one appended<br/>
        /// `assistant` message whose content is this response's `content` with any<br/>
        /// trailing whitespace stripped from the final text block and unpaired<br/>
        /// `tool_use` blocks omitted (the same appended-turn shape described on<br/>
        /// `fallback_credit_token`), with the token attached. `false`: retry by<br/>
        /// resending the original request body unchanged, with the token attached —<br/>
        /// the appended-assistant form is not available for this refusal (no<br/>
        /// continuable partial content, or the request uses `output_format` or a<br/>
        /// `tool_choice` that forces tool use). One exception: when the request used<br/>
        /// `output_format` or a forced `tool_choice` and the refusal arrived after<br/>
        /// server tools (including MCP connector tools) had already executed, the<br/>
        /// token may not be redeemable by either retry form; if the exact-body retry<br/>
        /// is then rejected with a 400 saying the token must be redeemed by<br/>
        /// continuing the partial response, discard the token and retry without it.<br/>
        /// Advisory: if an appended-assistant retry is rejected with a 400 despite<br/>
        /// `true`, fall back to resending the original request body with the token.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_has_prefill_claim")]
        public bool? FallbackHasPrefillClaim { get; set; }

        /// <summary>
        /// The server's suggested retry target for this refusal. Populated when a fallback attempt could not be made (the fallback model's rate limit was exhausted, or it was overloaded); names the fallback model the caller can retry directly. Null otherwise.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommended_model")]
        public string? RecommendedModel { get; set; }

        /// <summary>
        /// Default Value: refusal
        /// </summary>
        /// <default>"refusal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "refusal";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRefusalStopDetails" /> class.
        /// </summary>
        /// <param name="category">
        /// The policy category that triggered the refusal.<br/>
        /// `null` when the refusal doesn't map to a named category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="explanation">
        /// Human-readable explanation of the refusal.<br/>
        /// This text is not guaranteed to be stable. `null` when no explanation is available for the category.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fallbackCreditToken">
        /// Opaque code that refunds the cache-miss cost when retrying this refused<br/>
        /// request on the fallback model. Pass it as `fallback_credit_token` on the<br/>
        /// retry request. Expires 5 minutes after the refusal.<br/>
        /// The retry is sent either with the same request body (`system`, `messages`,<br/>
        /// `tools`, and other render-shaping fields), or with the same body plus one<br/>
        /// appended `assistant` message whose content is the partial text (with any<br/>
        /// trailing whitespace stripped from the final text block) and paired<br/>
        /// server-tool blocks from this refusal — which also authorizes that<br/>
        /// appended turn as an assistant-prefill continuation on models that otherwise<br/>
        /// disallow prefill. A token minted mid-server-tool-loop whose partial content<br/>
        /// was continuable may only be redeemed the second way — if a same-body retry<br/>
        /// is rejected with a 400 saying the token must be redeemed by continuing the<br/>
        /// partial response, retry the second way instead. Either way: same workspace,<br/>
        /// same platform; a mismatch is a 400. Resending a token for an already-warm<br/>
        /// prefix is permitted but yields no additional credit.<br/>
        /// `null` when the refused model isn't eligible for a fallback credit.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fallbackHasPrefillClaim">
        /// Whether the accompanying `fallback_credit_token` may be redeemed with the<br/>
        /// appended-assistant retry form. Only set when `fallback_credit_token` is<br/>
        /// present.<br/>
        /// `true`: retry by resending the same request body plus one appended<br/>
        /// `assistant` message whose content is this response's `content` with any<br/>
        /// trailing whitespace stripped from the final text block and unpaired<br/>
        /// `tool_use` blocks omitted (the same appended-turn shape described on<br/>
        /// `fallback_credit_token`), with the token attached. `false`: retry by<br/>
        /// resending the original request body unchanged, with the token attached —<br/>
        /// the appended-assistant form is not available for this refusal (no<br/>
        /// continuable partial content, or the request uses `output_format` or a<br/>
        /// `tool_choice` that forces tool use). One exception: when the request used<br/>
        /// `output_format` or a forced `tool_choice` and the refusal arrived after<br/>
        /// server tools (including MCP connector tools) had already executed, the<br/>
        /// token may not be redeemable by either retry form; if the exact-body retry<br/>
        /// is then rejected with a 400 saying the token must be redeemed by<br/>
        /// continuing the partial response, discard the token and retry without it.<br/>
        /// Advisory: if an appended-assistant retry is rejected with a 400 despite<br/>
        /// `true`, fall back to resending the original request body with the token.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="recommendedModel">
        /// The server's suggested retry target for this refusal. Populated when a fallback attempt could not be made (the fallback model's rate limit was exhausted, or it was overloaded); names the fallback model the caller can retry directly. Null otherwise.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: refusal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRefusalStopDetails(
            global::Anthropic.BetaRefusalCategory? category,
            string? explanation,
            string? fallbackCreditToken,
            bool? fallbackHasPrefillClaim,
            string? recommendedModel,
            string type = "refusal")
        {
            this.Category = category;
            this.Explanation = explanation;
            this.FallbackCreditToken = fallbackCreditToken;
            this.FallbackHasPrefillClaim = fallbackHasPrefillClaim;
            this.RecommendedModel = recommendedModel;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRefusalStopDetails" /> class.
        /// </summary>
        public BetaRefusalStopDetails()
        {
        }

    }
}