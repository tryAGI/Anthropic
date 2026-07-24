
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Privileged context for the accompanying turn and all subsequent turns, appended to the session's system context as a `role: "system"` turn rather than replacing the top-level system prompt. At most one per request: it must be the final event and immediately follow the `user.message`, `user.tool_result`, or `user.custom_tool_result` it accompanies. Only supported on models that accept mid-conversation system messages.
    /// </summary>
    public sealed partial class BetaManagedAgentsSystemMessageEventParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSystemMessageEventParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParamsType Type { get; set; }

        /// <summary>
        /// System content blocks to append. Text-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSystemMessageEventParams" /> class.
        /// </summary>
        /// <param name="content">
        /// System content blocks to append. Text-only.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSystemMessageEventParams(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock> content,
            global::Anthropic.BetaManagedAgentsSystemMessageEventParamsType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSystemMessageEventParams" /> class.
        /// </summary>
        public BetaManagedAgentsSystemMessageEventParams()
        {
        }

    }
}