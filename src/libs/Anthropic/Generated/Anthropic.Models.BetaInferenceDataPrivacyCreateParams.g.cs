
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where the Workspace's retained inference data and transcript copies go, and<br/>
    /// whether Anthropic's human review applies. A member cannot be null; omit it<br/>
    /// instead.
    /// </summary>
    public sealed partial class BetaInferenceDataPrivacyCreateParams
    {
        /// <summary>
        /// Whether Anthropic's human review applies to the Workspace. `disabled` needs Anthropic's approval. When omitted, `enabled`. Cannot be null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_review")]
        public global::Anthropic.BetaHumanReviewParams? HumanReview { get; set; }

        /// <summary>
        /// Where the data Anthropic's safeguards systems retain for the Workspace goes. `external` sends it, once the attach takes effect, to the External Storage that `external_storage_id` names. `internal` means no External Storage: it goes to Anthropic's storage or, on a cloud provider's platform, to that provider's storage. When omitted, `internal`. Cannot be null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safeguards_storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaStorageMemberParamsJsonConverter))]
        public global::Anthropic.BetaStorageMemberParams? SafeguardsStorage { get; set; }

        /// <summary>
        /// Where copies of the Workspace's transcripts and its cases (Anthropic's safety findings about those transcripts) go. `external` sends them, once the attach takes effect, to the External Storage that `external_storage_id` names. `internal` means no External Storage, so no copies are made. When omitted, `internal`. Cannot be null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcripts_storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaStorageMemberParamsJsonConverter))]
        public global::Anthropic.BetaStorageMemberParams? TranscriptsStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInferenceDataPrivacyCreateParams" /> class.
        /// </summary>
        /// <param name="humanReview">
        /// Whether Anthropic's human review applies to the Workspace. `disabled` needs Anthropic's approval. When omitted, `enabled`. Cannot be null.
        /// </param>
        /// <param name="safeguardsStorage">
        /// Where the data Anthropic's safeguards systems retain for the Workspace goes. `external` sends it, once the attach takes effect, to the External Storage that `external_storage_id` names. `internal` means no External Storage: it goes to Anthropic's storage or, on a cloud provider's platform, to that provider's storage. When omitted, `internal`. Cannot be null.
        /// </param>
        /// <param name="transcriptsStorage">
        /// Where copies of the Workspace's transcripts and its cases (Anthropic's safety findings about those transcripts) go. `external` sends them, once the attach takes effect, to the External Storage that `external_storage_id` names. `internal` means no External Storage, so no copies are made. When omitted, `internal`. Cannot be null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInferenceDataPrivacyCreateParams(
            global::Anthropic.BetaHumanReviewParams? humanReview,
            global::Anthropic.BetaStorageMemberParams? safeguardsStorage,
            global::Anthropic.BetaStorageMemberParams? transcriptsStorage)
        {
            this.HumanReview = humanReview;
            this.SafeguardsStorage = safeguardsStorage;
            this.TranscriptsStorage = transcriptsStorage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInferenceDataPrivacyCreateParams" /> class.
        /// </summary>
        public BetaInferenceDataPrivacyCreateParams()
        {
        }

    }
}