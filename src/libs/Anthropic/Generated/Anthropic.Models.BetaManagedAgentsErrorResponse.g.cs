
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaManagedAgentsErrorResponse
    {
        /// <summary>
        /// Always "error" for error responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsErrorResponseTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsErrorResponseType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsError Error { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsErrorResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type">
        /// Always "error" for error responses
        /// </param>
        /// <param name="requestId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsErrorResponse(
            global::Anthropic.BetaManagedAgentsError error,
            global::Anthropic.BetaManagedAgentsErrorResponseType type,
            string? requestId)
        {
            this.Type = type;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsErrorResponse" /> class.
        /// </summary>
        public BetaManagedAgentsErrorResponse()
        {
        }

    }
}