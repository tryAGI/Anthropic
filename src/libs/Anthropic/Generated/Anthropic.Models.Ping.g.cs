
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Ping
    {
        /// <summary>
        /// Default Value: ping
        /// </summary>
        /// <default>global::Anthropic.PingType.Ping</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.PingTypeJsonConverter))]
        public global::Anthropic.PingType Type { get; set; } = global::Anthropic.PingType.Ping;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Ping" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: ping
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Ping(
            global::Anthropic.PingType type = global::Anthropic.PingType.Ping)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ping" /> class.
        /// </summary>
        public Ping()
        {
        }
    }
}