
#nullable enable

namespace Anthropic
{
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
    public sealed partial class BetaRefusalStopDetailsFallbackHasPrefillClaim
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}