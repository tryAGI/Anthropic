
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Return a cropped screenshot of the given viewport region, scaled up for closer<br/>
    /// inspection — useful for small icons, buttons, or text. Coordinates are in the<br/>
    /// same viewport-pixel space as a full screenshot.
    /// </summary>
    public sealed partial class BrowserZoomInput
    {
        /// <summary>
        /// [x0, y0, x1, y1] in viewport pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Region { get; set; }

        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserZoomInput" /> class.
        /// </summary>
        /// <param name="region">
        /// [x0, y0, x1, y1] in viewport pixels.
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserZoomInput(
            global::System.Collections.Generic.IList<int> region,
            string? tabId)
        {
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.TabId = tabId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserZoomInput" /> class.
        /// </summary>
        public BrowserZoomInput()
        {
        }

    }
}