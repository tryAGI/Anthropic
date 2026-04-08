
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Image content specified directly as base64 data or as a reference via a URL.
    /// </summary>
    public sealed partial class BetaManagedAgentsImageBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsImageBlockTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsImageBlockType Type { get; set; }

        /// <summary>
        /// The source of the image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsImageSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsImageSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsImageBlock" /> class.
        /// </summary>
        /// <param name="source">
        /// The source of the image data.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsImageBlock(
            global::Anthropic.BetaManagedAgentsImageSource source,
            global::Anthropic.BetaManagedAgentsImageBlockType type)
        {
            this.Type = type;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsImageBlock" /> class.
        /// </summary>
        public BetaManagedAgentsImageBlock()
        {
        }
    }
}