
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Set the value of a form element (input, textarea, select, checkbox). Use a<br/>
    /// boolean for checkboxes, an option value or text for selects.
    /// </summary>
    public sealed partial class BetaBrowserFormInputInput
    {
        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// An element on the page, identified by a reference from a prior `read_page` or<br/>
        /// `find` result. References are scoped to the tab that produced them and become<br/>
        /// stale after navigation or a major re-render.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaBrowserRefTarget Target { get; set; }

        /// <summary>
        /// The value to set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaBrowserFormInputValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaBrowserFormInputValue Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserFormInputInput" /> class.
        /// </summary>
        /// <param name="target">
        /// An element on the page, identified by a reference from a prior `read_page` or<br/>
        /// `find` result. References are scoped to the tab that produced them and become<br/>
        /// stale after navigation or a major re-render.
        /// </param>
        /// <param name="value">
        /// The value to set.
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserFormInputInput(
            global::Anthropic.BetaBrowserRefTarget target,
            global::Anthropic.BetaBrowserFormInputValue value,
            string? tabId)
        {
            this.TabId = tabId;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserFormInputInput" /> class.
        /// </summary>
        public BetaBrowserFormInputInput()
        {
        }

    }
}