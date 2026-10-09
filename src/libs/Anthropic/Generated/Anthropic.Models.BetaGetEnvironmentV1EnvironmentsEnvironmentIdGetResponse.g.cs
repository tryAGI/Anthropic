
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="type">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse(
            global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError error,
            string? requestId,
            string type = "error")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse" /> class.
        /// </summary>
        public BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse FromError(global::Anthropic.BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponseError error)
        {
            return new BetaGetEnvironmentV1EnvironmentsEnvironmentIdGetResponse
            {
                Error = error,
            };
        }

    }
}