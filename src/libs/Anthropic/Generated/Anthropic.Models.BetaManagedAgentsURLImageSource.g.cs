
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Image referenced by URL.
    /// </summary>
    public sealed partial class BetaManagedAgentsURLImageSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsURLImageSourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsURLImageSourceType Type { get; set; }

        /// <summary>
        /// URL of the image to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsURLImageSource" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the image to fetch.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsURLImageSource(
            string url,
            global::Anthropic.BetaManagedAgentsURLImageSourceType type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsURLImageSource" /> class.
        /// </summary>
        public BetaManagedAgentsURLImageSource()
        {
        }
    }
}