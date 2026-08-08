
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Privileged context for the accompanying turn and all subsequent turns, appended to the session's system context as a `role: "system"` turn rather than replacing the top-level system prompt.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeploymentSystemMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentSystemMessageEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEventType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentSystemMessageEvent" /> class.
        /// </summary>
        /// <param name="content">
        /// System content blocks to append. Text-only.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeploymentSystemMessageEvent(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSystemContentBlock> content,
            global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEventType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentSystemMessageEvent" /> class.
        /// </summary>
        public BetaManagedAgentsDeploymentSystemMessageEvent()
        {
        }

    }
}