
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for sending a user message to the session.<br/>
    /// Example: {"type":"user.message","content":[{"type":"text","text":"Where is my order #1234?"}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsUserMessageEventParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserMessageEventParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserMessageEventParamsType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserMessageEventParams" /> class.
        /// </summary>
        /// <param name="content">
        /// Array of content blocks for the user message.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserMessageEventParams(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsUserContentBlock> content,
            global::Anthropic.BetaManagedAgentsUserMessageEventParamsType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserMessageEventParams" /> class.
        /// </summary>
        public BetaManagedAgentsUserMessageEventParams()
        {
        }
    }
}