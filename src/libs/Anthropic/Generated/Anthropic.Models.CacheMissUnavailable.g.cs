
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A `cache_miss_reason` for when the API can't give a diagnosis. The request itself was processed normally.<br/>
    /// This includes a request whose `model`, `system`, and `tools` match the previous request's but whose other prompt-affecting parameters, such as `thinking` or `tool_choice`, differ.<br/>
    /// See the [cache diagnostics guide](https://platform.claude.com/docs/en/build-with-claude/cache-diagnostics#cache-miss-reason-types) to learn what to change for each reason.
    /// </summary>
    public sealed partial class CacheMissUnavailable
    {
        /// <summary>
        /// Default Value: unavailable
        /// </summary>
        /// <default>"unavailable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "unavailable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheMissUnavailable" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheMissUnavailable(
            string type = "unavailable")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheMissUnavailable" /> class.
        /// </summary>
        public CacheMissUnavailable()
        {
        }

    }
}