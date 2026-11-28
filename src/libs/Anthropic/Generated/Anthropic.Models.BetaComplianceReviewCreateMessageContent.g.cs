
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A request to create a message, and its response.
    /// </summary>
    public sealed partial class BetaComplianceReviewCreateMessageContent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"create_message"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "create_message";

        /// <summary>
        /// The `POST /v1/messages` request body, without thinking blocks or unpublished fields. For a user's message from an Anthropic app, such as Claude Code, `system` is a placeholder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaStruct Request { get; set; }

        /// <summary>
        /// The model's `Message`, without thinking blocks or unpublished fields. Null when no response was stored, for example because the client disconnected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Anthropic.BetaMessage? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCreateMessageContent" /> class.
        /// </summary>
        /// <param name="request">
        /// The `POST /v1/messages` request body, without thinking blocks or unpublished fields. For a user's message from an Anthropic app, such as Claude Code, `system` is a placeholder.
        /// </param>
        /// <param name="response">
        /// The model's `Message`, without thinking blocks or unpublished fields. Null when no response was stored, for example because the client disconnected.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewCreateMessageContent(
            global::Anthropic.BetaStruct request,
            global::Anthropic.BetaMessage? response,
            string type = "create_message")
        {
            this.Type = type;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCreateMessageContent" /> class.
        /// </summary>
        public BetaComplianceReviewCreateMessageContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaComplianceReviewCreateMessageContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaComplianceReviewCreateMessageContent FromRequest(global::Anthropic.BetaStruct request)
        {
            return new BetaComplianceReviewCreateMessageContent
            {
                Request = request,
            };
        }

    }
}