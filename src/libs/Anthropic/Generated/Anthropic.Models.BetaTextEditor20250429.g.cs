
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTextEditor20250429
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTextEditor20250429NameJsonConverter))]
        public global::Anthropic.BetaTextEditor20250429Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTextEditor20250429TypeJsonConverter))]
        public global::Anthropic.BetaTextEditor20250429Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextEditor20250429" /> class.
        /// </summary>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in `tool_use` blocks.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTextEditor20250429(
            global::Anthropic.BetaCacheControlEphemeral? cacheControl,
            global::Anthropic.BetaTextEditor20250429Name name,
            global::Anthropic.BetaTextEditor20250429Type type)
        {
            this.CacheControl = cacheControl;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextEditor20250429" /> class.
        /// </summary>
        public BetaTextEditor20250429()
        {
        }
    }
}