
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Set the value of a file-input element to one or more files. The target must be an<br/>
    /// element reference; at least one of paths or document_ids is required.
    /// </summary>
    public sealed partial class BrowserFileUploadInput
    {
        /// <summary>
        /// References to files the harness has staged, for deployments where the browser executor cannot read the caller's filesystem.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        public global::System.Collections.Generic.IList<string>? DocumentIds { get; set; }

        /// <summary>
        /// File paths on the browser executor's filesystem.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        public global::System.Collections.Generic.IList<string>? Paths { get; set; }

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
        public required global::Anthropic.BrowserRefTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserFileUploadInput" /> class.
        /// </summary>
        /// <param name="target">
        /// An element on the page, identified by a reference from a prior `read_page` or<br/>
        /// `find` result. References are scoped to the tab that produced them and become<br/>
        /// stale after navigation or a major re-render.
        /// </param>
        /// <param name="documentIds">
        /// References to files the harness has staged, for deployments where the browser executor cannot read the caller's filesystem.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="paths">
        /// File paths on the browser executor's filesystem.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserFileUploadInput(
            global::Anthropic.BrowserRefTarget target,
            global::System.Collections.Generic.IList<string>? documentIds,
            global::System.Collections.Generic.IList<string>? paths,
            string? tabId)
        {
            this.DocumentIds = documentIds;
            this.Paths = paths;
            this.TabId = tabId;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserFileUploadInput" /> class.
        /// </summary>
        public BrowserFileUploadInput()
        {
        }

    }
}