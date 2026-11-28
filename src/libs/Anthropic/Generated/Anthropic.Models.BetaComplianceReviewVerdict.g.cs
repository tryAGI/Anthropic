
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Your conclusion on one message of a review case.
    /// </summary>
    public sealed partial class BetaComplianceReviewVerdict
    {
        /// <summary>
        /// The `item_id` of one of the case's `transcripts`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Your conclusion on this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("determination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceReviewDeterminationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewDetermination Determination { get; set; }

        /// <summary>
        /// The policy category that this message violated, from the values that the request's `policy_categories` accepts. Optional with `violation`. Leave it out with `no_violation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_category")]
        public global::Anthropic.BetaComplianceReviewViolatedPolicyCategory? PolicyCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewVerdict" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The `item_id` of one of the case's `transcripts`.
        /// </param>
        /// <param name="determination">
        /// Your conclusion on this message.
        /// </param>
        /// <param name="policyCategory">
        /// The policy category that this message violated, from the values that the request's `policy_categories` accepts. Optional with `violation`. Leave it out with `no_violation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewVerdict(
            string itemId,
            global::Anthropic.BetaComplianceReviewDetermination determination,
            global::Anthropic.BetaComplianceReviewViolatedPolicyCategory? policyCategory)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Determination = determination;
            this.PolicyCategory = policyCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewVerdict" /> class.
        /// </summary>
        public BetaComplianceReviewVerdict()
        {
        }

    }
}