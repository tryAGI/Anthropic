
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user message sent to the session.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeploymentUserMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentUserMessageEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEventType Type { get; set; }

        /// <summary>
        /// Array of content blocks for the user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentUserMessageEvent" /> class.
        /// </summary>
        /// <param name="content">
        /// Array of content blocks for the user message.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeploymentUserMessageEvent(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> content,
            global::Anthropic.BetaManagedAgentsDeploymentUserMessageEventType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeploymentUserMessageEvent" /> class.
        /// </summary>
        public BetaManagedAgentsDeploymentUserMessageEvent()
        {
        }

    }
}