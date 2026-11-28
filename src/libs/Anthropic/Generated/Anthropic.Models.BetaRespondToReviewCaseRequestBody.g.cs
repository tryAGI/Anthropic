
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"determination":"no_violation"}
    /// </summary>
    public sealed partial class BetaRespondToReviewCaseRequestBody
    {
        /// <summary>
        /// Your conclusion on the case as a whole. Anthropic doesn't check it against `verdicts`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("determination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceReviewDeterminationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewDetermination Determination { get; set; }

        /// <summary>
        /// The policy categories that you found were violated. Send one to four with `violation`, and none with `no_violation`. They need not match the case's own. Each value is one of `cyber`, `bio`, `chem`, `radnuc` (radiological or nuclear weapons), `cgw` (conventional weapons), `mgw` (military-grade weapons systems), `io` (influence operations), `fraud`, `violent_extremism`, `surveillance`, `human_exploitation`, `self_harm`, `adult_content`, `reasoning_extraction`, `frontier_llm` (use of the model to accelerate frontier AI research and development in restricted ways), `compromised_key` or `other`, and can appear once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_categories")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewViolatedPolicyCategory>? PolicyCategories { get; set; }

        /// <summary>
        /// Your conclusions on individual messages of the case. They need not cover every message, and each `item_id` can appear once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdicts")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewVerdict>? Verdicts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRespondToReviewCaseRequestBody" /> class.
        /// </summary>
        /// <param name="determination">
        /// Your conclusion on the case as a whole. Anthropic doesn't check it against `verdicts`.
        /// </param>
        /// <param name="policyCategories">
        /// The policy categories that you found were violated. Send one to four with `violation`, and none with `no_violation`. They need not match the case's own. Each value is one of `cyber`, `bio`, `chem`, `radnuc` (radiological or nuclear weapons), `cgw` (conventional weapons), `mgw` (military-grade weapons systems), `io` (influence operations), `fraud`, `violent_extremism`, `surveillance`, `human_exploitation`, `self_harm`, `adult_content`, `reasoning_extraction`, `frontier_llm` (use of the model to accelerate frontier AI research and development in restricted ways), `compromised_key` or `other`, and can appear once.
        /// </param>
        /// <param name="verdicts">
        /// Your conclusions on individual messages of the case. They need not cover every message, and each `item_id` can appear once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRespondToReviewCaseRequestBody(
            global::Anthropic.BetaComplianceReviewDetermination determination,
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewViolatedPolicyCategory>? policyCategories,
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewVerdict>? verdicts)
        {
            this.Determination = determination;
            this.PolicyCategories = policyCategories;
            this.Verdicts = verdicts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRespondToReviewCaseRequestBody" /> class.
        /// </summary>
        public BetaRespondToReviewCaseRequestBody()
        {
        }

    }
}