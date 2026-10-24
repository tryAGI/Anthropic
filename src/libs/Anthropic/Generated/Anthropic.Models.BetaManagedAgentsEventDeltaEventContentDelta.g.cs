
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaManagedAgentsEventDeltaEventContentDelta
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"content_delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "content_delta";

        /// <summary>
        /// Which entry in the previewed event's content array this fragment lands in. Insert content as that entry when the index is new; append to the existing entry otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// A partial element of the content array at index, typed like the element itself — the same shape the buffered agent.message carries in content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsTextBlock Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventDeltaEventContentDelta" /> class.
        /// </summary>
        /// <param name="content">
        /// A partial element of the content array at index, typed like the element itself — the same shape the buffered agent.message carries in content.
        /// </param>
        /// <param name="index">
        /// Which entry in the previewed event's content array this fragment lands in. Insert content as that entry when the index is new; append to the existing entry otherwise.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEventDeltaEventContentDelta(
            global::Anthropic.BetaManagedAgentsTextBlock content,
            int? index,
            string type = "content_delta")
        {
            this.Type = type;
            this.Index = index;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventDeltaEventContentDelta" /> class.
        /// </summary>
        public BetaManagedAgentsEventDeltaEventContentDelta()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsEventDeltaEventContentDelta"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsEventDeltaEventContentDelta FromContent(global::Anthropic.BetaManagedAgentsTextBlock content)
        {
            return new BetaManagedAgentsEventDeltaEventContentDelta
            {
                Content = content,
            };
        }

    }
}