
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The cache control settings.
    /// </summary>
    public sealed partial class CacheControlEphemeral
    {
        /// <summary>
        /// Default Value: ephemeral
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CacheControlEphemeralTypeJsonConverter))]
        public global::Anthropic.CacheControlEphemeralType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheControlEphemeral" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: ephemeral
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CacheControlEphemeral(
            global::Anthropic.CacheControlEphemeralType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheControlEphemeral" /> class.
        /// </summary>
        public CacheControlEphemeral()
        {
        }
    }
}