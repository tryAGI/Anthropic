
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A service account.
    /// </summary>
    public sealed partial class BetaComplianceReviewServiceAccountActor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"service_account_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account_actor";

        /// <summary>
        /// The ID of the service account (`svac_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewServiceAccountActor" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// The ID of the service account (`svac_...`).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewServiceAccountActor(
            string serviceAccountId,
            string type = "service_account_actor")
        {
            this.Type = type;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewServiceAccountActor" /> class.
        /// </summary>
        public BetaComplianceReviewServiceAccountActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaComplianceReviewServiceAccountActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaComplianceReviewServiceAccountActor FromServiceAccountId(string serviceAccountId)
        {
            return new BetaComplianceReviewServiceAccountActor
            {
                ServiceAccountId = serviceAccountId,
            };
        }

    }
}