
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response envelope for request-level diagnostics. Present (possibly<br/>
    /// null) whenever the caller supplied `diagnostics` on the request.
    /// </summary>
    public sealed partial class BetaDiagnostics
    {
        /// <summary>
        /// Explains why the prompt cache could not fully reuse the prefix from the request identified by `diagnostics.previous_message_id`. `null` means diagnosis is still pending — the response was serialized before the background comparison completed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_miss_reason")]
        public global::Anthropic.CacheMissReasonVariant1? CacheMissReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDiagnostics" /> class.
        /// </summary>
        /// <param name="cacheMissReason">
        /// Explains why the prompt cache could not fully reuse the prefix from the request identified by `diagnostics.previous_message_id`. `null` means diagnosis is still pending — the response was serialized before the background comparison completed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDiagnostics(
            global::Anthropic.CacheMissReasonVariant1? cacheMissReason)
        {
            this.CacheMissReason = cacheMissReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDiagnostics" /> class.
        /// </summary>
        public BetaDiagnostics()
        {
        }

    }
}