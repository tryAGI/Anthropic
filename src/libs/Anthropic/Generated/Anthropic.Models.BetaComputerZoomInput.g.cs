
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Take a screenshot of a rectangular region. Region coordinates are in the<br/>
    /// full-screenshot space (not physical display pixels). The crop is scaled up to<br/>
    /// fill the image budget so fine details become legible.
    /// </summary>
    public sealed partial class BetaComputerZoomInput
    {
        /// <summary>
        /// (x0, y0, x1, y1): The region to capture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerZoomInput" /> class.
        /// </summary>
        /// <param name="region">
        /// (x0, y0, x1, y1): The region to capture.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerZoomInput(
            global::System.Collections.Generic.IList<int> region)
        {
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerZoomInput" /> class.
        /// </summary>
        public BetaComputerZoomInput()
        {
        }

    }
}