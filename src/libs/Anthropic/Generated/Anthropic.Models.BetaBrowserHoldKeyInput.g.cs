
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Hold a key or key chord down for a duration, then release it. Uses the same key<br/>
    /// names and "+" chord syntax as the key action.
    /// </summary>
    public sealed partial class BetaBrowserHoldKeyInput
    {
        /// <summary>
        /// Seconds to hold the key down (maximum 30).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// The key or chord to hold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserHoldKeyInput" /> class.
        /// </summary>
        /// <param name="duration">
        /// Seconds to hold the key down (maximum 30).
        /// </param>
        /// <param name="text">
        /// The key or chord to hold.
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserHoldKeyInput(
            double duration,
            string text,
            string? tabId)
        {
            this.Duration = duration;
            this.TabId = tabId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserHoldKeyInput" /> class.
        /// </summary>
        public BetaBrowserHoldKeyInput()
        {
        }

    }
}