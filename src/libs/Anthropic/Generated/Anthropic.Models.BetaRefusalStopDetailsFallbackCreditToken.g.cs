
#nullable enable

namespace Anthropic
{
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
    public sealed partial class BetaRefusalStopDetailsFallbackCreditToken
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}