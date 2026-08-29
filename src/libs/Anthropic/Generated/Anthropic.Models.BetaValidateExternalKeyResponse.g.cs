
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Result of a validation roundtrip against the customer's KMS.<br/>
    /// HTTP 200 for both outcomes — the operation completed; `status` says<br/>
    /// whether the key works.
    /// </summary>
    public sealed partial class BetaValidateExternalKeyResponse
    {
        /// <summary>
        /// Error message when status is `failure`. Null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// `success` — encrypt/decrypt roundtrip succeeded. `failure` — the roundtrip failed or timed out; see `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaValidateExternalKeyResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaValidateExternalKeyResponseStatus Status { get; set; }

        /// <summary>
        /// Default Value: external_key_validation
        /// </summary>
        /// <default>"external_key_validation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "external_key_validation";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaValidateExternalKeyResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// `success` — encrypt/decrypt roundtrip succeeded. `failure` — the roundtrip failed or timed out; see `error`.
        /// </param>
        /// <param name="error">
        /// Error message when status is `failure`. Null otherwise.
        /// </param>
        /// <param name="type">
        /// Default Value: external_key_validation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaValidateExternalKeyResponse(
            global::Anthropic.BetaValidateExternalKeyResponseStatus status,
            string? error,
            string type = "external_key_validation")
        {
            this.Error = error;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaValidateExternalKeyResponse" /> class.
        /// </summary>
        public BetaValidateExternalKeyResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaValidateExternalKeyResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaValidateExternalKeyResponse FromStatus(global::Anthropic.BetaValidateExternalKeyResponseStatus status)
        {
            return new BetaValidateExternalKeyResponse
            {
                Status = status,
            };
        }

    }
}