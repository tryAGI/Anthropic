
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Move the pointer to a viewport coordinate without clicking.
    /// </summary>
    public sealed partial class BetaBrowserMouseMoveInput
    {
        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
        /// full-viewport screenshot).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaBrowserCoordinateTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserMouseMoveInput" /> class.
        /// </summary>
        /// <param name="target">
        /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
        /// full-viewport screenshot).
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserMouseMoveInput(
            global::Anthropic.BetaBrowserCoordinateTarget target,
            string? tabId)
        {
            this.TabId = tabId;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserMouseMoveInput" /> class.
        /// </summary>
        public BetaBrowserMouseMoveInput()
        {
        }

    }
}