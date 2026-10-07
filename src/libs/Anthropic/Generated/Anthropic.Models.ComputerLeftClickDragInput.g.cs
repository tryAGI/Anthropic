
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Click and drag the cursor from `start_coordinate` to `coordinate`.
    /// </summary>
    public sealed partial class ComputerLeftClickDragInput
    {
        /// <summary>
        /// (x, y): x pixels from the left edge, y pixels from the top edge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Coordinate { get; set; }

        /// <summary>
        /// (x, y): x pixels from the left edge, y pixels from the top edge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_coordinate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> StartCoordinate { get; set; }

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
        /// Initializes a new instance of the <see cref="ComputerLeftClickDragInput" /> class.
        /// </summary>
        /// <param name="coordinate">
        /// (x, y): x pixels from the left edge, y pixels from the top edge.
        /// </param>
        /// <param name="startCoordinate">
        /// (x, y): x pixels from the left edge, y pixels from the top edge.
        /// </param>
        /// <param name="text">
        /// Optional key combination to hold down during this action (e.g. "ctrl", "shift", "ctrl+shift").<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerLeftClickDragInput(
            global::System.Collections.Generic.IList<int> coordinate,
            global::System.Collections.Generic.IList<int> startCoordinate,
            string? text)
        {
            this.Coordinate = coordinate ?? throw new global::System.ArgumentNullException(nameof(coordinate));
            this.StartCoordinate = startCoordinate ?? throw new global::System.ArgumentNullException(nameof(startCoordinate));
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerLeftClickDragInput" /> class.
        /// </summary>
        public ComputerLeftClickDragInput()
        {
        }

    }
}