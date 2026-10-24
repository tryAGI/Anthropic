
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
        /// <default>"url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "url";

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
            string type = "url")
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

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsURLImageSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsURLImageSource FromUrl(string url)
        {
            return new BetaManagedAgentsURLImageSource
            {
                Url = url,
            };
        }

    }
}