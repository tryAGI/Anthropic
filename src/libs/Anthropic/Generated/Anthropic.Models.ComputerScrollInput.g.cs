
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Scroll the screen at the specified (x, y) pixel coordinate, or the current cursor<br/>
    /// position if `coordinate` is omitted. Do NOT use PageUp/PageDown to scroll.
    /// </summary>
    public sealed partial class ComputerScrollInput
    {
        /// <summary>
        /// (x, y): x pixels from the left edge, y pixels from the top edge.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinate")]
        public global::System.Collections.Generic.IList<int>? Coordinate { get; set; }

        /// <summary>
        /// Number of 'clicks' of the scroll wheel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScrollAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ComputerScrollDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ComputerScrollDirection ScrollDirection { get; set; }

        /// <summary>
        /// Optional key combination to hold down during this action (e.g. "ctrl", "shift", "ctrl+shift").<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScrollInput" /> class.
        /// </summary>
        /// <param name="scrollAmount">
        /// Number of 'clicks' of the scroll wheel.
        /// </param>
        /// <param name="scrollDirection"></param>
        /// <param name="coordinate">
        /// (x, y): x pixels from the left edge, y pixels from the top edge.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="text">
        /// Optional key combination to hold down during this action (e.g. "ctrl", "shift", "ctrl+shift").<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerScrollInput(
            int scrollAmount,
            global::Anthropic.ComputerScrollDirection scrollDirection,
            global::System.Collections.Generic.IList<int>? coordinate,
            string? text)
        {
            this.Coordinate = coordinate;
            this.ScrollAmount = scrollAmount;
            this.ScrollDirection = scrollDirection;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScrollInput" /> class.
        /// </summary>
        public ComputerScrollInput()
        {
        }

    }
}