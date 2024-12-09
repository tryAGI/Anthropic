
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaErrorResponse
    {
        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>global::Anthropic.BetaErrorResponseType.Error</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaErrorResponseTypeJsonConverter))]
        public global::Anthropic.BetaErrorResponseType Type { get; set; } = global::Anthropic.BetaErrorResponseType.Error;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Error Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErrorResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: error
        /// </param>
        /// <param name="error"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaErrorResponse(
            global::Anthropic.Error error,
            global::Anthropic.BetaErrorResponseType type = global::Anthropic.BetaErrorResponseType.Error)
        {
            this.Error = error;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErrorResponse" /> class.
        /// </summary>
        public BetaErrorResponse()
        {
        }
    }
}