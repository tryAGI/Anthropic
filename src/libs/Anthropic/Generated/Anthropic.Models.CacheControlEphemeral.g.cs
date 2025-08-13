
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CacheControlEphemeral
    {
        /// <summary>
        /// The time-to-live for the cache control breakpoint.<br/>
        /// This may be one the following values:<br/>
        /// - `5m`: 5 minutes<br/>
        /// - `1h`: 1 hour<br/>
        /// Defaults to `5m`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CacheControlEphemeralTtlJsonConverter))]
        public global::Anthropic.CacheControlEphemeralTtl? Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CacheControlEphemeralTypeJsonConverter))]
        public global::Anthropic.CacheControlEphemeralType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheControlEphemeral" /> class.
        /// </summary>
        /// <param name="ttl">
        /// The time-to-live for the cache control breakpoint.<br/>
        /// This may be one the following values:<br/>
        /// - `5m`: 5 minutes<br/>
        /// - `1h`: 1 hour<br/>
        /// Defaults to `5m`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheControlEphemeral(
            global::Anthropic.CacheControlEphemeralTtl? ttl,
            global::Anthropic.CacheControlEphemeralType type)
        {
            this.Ttl = ttl;
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