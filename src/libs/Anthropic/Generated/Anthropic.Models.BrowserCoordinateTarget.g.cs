
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
    /// full-viewport screenshot).
    /// </summary>
    public sealed partial class BrowserCoordinateTarget
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"coordinate"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "coordinate";

        /// <summary>
        /// Pixels from the left edge of the viewport.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// Pixels from the top edge of the viewport.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserCoordinateTarget" /> class.
        /// </summary>
        /// <param name="x">
        /// Pixels from the left edge of the viewport.
        /// </param>
        /// <param name="y">
        /// Pixels from the top edge of the viewport.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserCoordinateTarget(
            int x,
            int y,
            string type = "coordinate")
        {
            this.Type = type;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserCoordinateTarget" /> class.
        /// </summary>
        public BrowserCoordinateTarget()
        {
        }

    }
}