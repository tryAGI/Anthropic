
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Move the cursor to a specified (x, y) pixel coordinate. Use this ONLY to hover<br/>
    /// without clicking; otherwise use a click action directly.
    /// </summary>
    public sealed partial class ComputerMouseMoveInput
    {
        /// <summary>
        /// (x, y): x pixels from the left edge, y pixels from the top edge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Coordinate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerMouseMoveInput" /> class.
        /// </summary>
        /// <param name="coordinate">
        /// (x, y): x pixels from the left edge, y pixels from the top edge.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerMouseMoveInput(
            global::System.Collections.Generic.IList<int> coordinate)
        {
            this.Coordinate = coordinate ?? throw new global::System.ArgumentNullException(nameof(coordinate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerMouseMoveInput" /> class.
        /// </summary>
        public ComputerMouseMoveInput()
        {
        }

    }
}