
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteSlackChannelResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDeleteSlackChannelResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteSlackChannelResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteSlackChannelResponse(
            global::Anthropic.BetaDeleteSlackChannelResponseError error,
            string? requestId,
            string type = "error")
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteSlackChannelResponse" /> class.
        /// </summary>
        public BetaDeleteSlackChannelResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeleteSlackChannelResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeleteSlackChannelResponse FromError(global::Anthropic.BetaDeleteSlackChannelResponseError error)
        {
            return new BetaDeleteSlackChannelResponse
            {
                Error = error,
            };
        }

    }
}