
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaInputMessage
    {
        /// <summary>
        /// How long this system message's text stays in front of the model. `"never"` (the default) renders it on every request that includes it. `"next_user_message"` renders it only for the user turn it follows: once a later `role: "user"` message exists in `messages` the message stays in the array (send it unchanged) but is no longer shown to the model. Only permitted on `role: "system"` messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_at")]
        public global::Anthropic.BetaInputMessageClearAt2? ClearAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::Anthropic.BetaSystemMessageOutputConfig? OutputConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaInputMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaInputMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="clearAt">
        /// How long this system message's text stays in front of the model. `"never"` (the default) renders it on every request that includes it. `"next_user_message"` renders it only for the user turn it follows: once a later `role: "user"` message exists in `messages` the message stays in the array (send it unchanged) but is no longer shown to the model. Only permitted on `role: "system"` messages.
        /// </param>
        /// <param name="outputConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInputMessage(
            global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>> content,
            global::Anthropic.BetaInputMessageRole role,
            global::Anthropic.BetaInputMessageClearAt2? clearAt,
            global::Anthropic.BetaSystemMessageOutputConfig? outputConfig)
        {
            this.ClearAt = clearAt;
            this.Content = content;
            this.OutputConfig = outputConfig;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputMessage" /> class.
        /// </summary>
        public BetaInputMessage()
        {
        }

    }
}