
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponseError Error { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="type">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse(
            global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponseError error,
            string? requestId,
            string type = "error")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse" /> class.
        /// </summary>
        public BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse FromError(global::Anthropic.BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponseError error)
        {
            return new BetaCreateFederationRuleV1OrganizationsFederationRulesPostResponse
            {
                Error = error,
            };
        }

    }
}