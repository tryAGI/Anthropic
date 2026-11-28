
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaInferenceDataPrivacy
    {
        /// <summary>
        /// The Workspace's human review setting. Human review is off only while this is `disabled` and Anthropic's approval stands.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_review")]
        public global::Anthropic.BetaHumanReview? HumanReview { get; set; }

        /// <summary>
        /// Where the data Anthropic's safeguards systems retain for the Workspace goes. `external` sends it to the External Storage that `external_storage_id` names. `internal` means no External Storage: it goes to Anthropic's storage or, on a cloud provider's platform, to that provider's storage. A recent change may not have taken effect yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safeguards_storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaStorageMemberJsonConverter))]
        public global::Anthropic.BetaStorageMember? SafeguardsStorage { get; set; }

        /// <summary>
        /// Where copies of the Workspace's transcripts and its cases (Anthropic's safety findings about those transcripts) go. `external` sends them to the External Storage that `external_storage_id` names. `internal` means no External Storage, so no copies are made. A recent change may not have taken effect yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcripts_storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaStorageMemberJsonConverter))]
        public global::Anthropic.BetaStorageMember? TranscriptsStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInferenceDataPrivacy" /> class.
        /// </summary>
        /// <param name="humanReview">
        /// The Workspace's human review setting. Human review is off only while this is `disabled` and Anthropic's approval stands.
        /// </param>
        /// <param name="safeguardsStorage">
        /// Where the data Anthropic's safeguards systems retain for the Workspace goes. `external` sends it to the External Storage that `external_storage_id` names. `internal` means no External Storage: it goes to Anthropic's storage or, on a cloud provider's platform, to that provider's storage. A recent change may not have taken effect yet.
        /// </param>
        /// <param name="transcriptsStorage">
        /// Where copies of the Workspace's transcripts and its cases (Anthropic's safety findings about those transcripts) go. `external` sends them to the External Storage that `external_storage_id` names. `internal` means no External Storage, so no copies are made. A recent change may not have taken effect yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInferenceDataPrivacy(
            global::Anthropic.BetaHumanReview? humanReview,
            global::Anthropic.BetaStorageMember? safeguardsStorage,
            global::Anthropic.BetaStorageMember? transcriptsStorage)
        {
            this.HumanReview = humanReview;
            this.SafeguardsStorage = safeguardsStorage;
            this.TranscriptsStorage = transcriptsStorage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInferenceDataPrivacy" /> class.
        /// </summary>
        public BetaInferenceDataPrivacy()
        {
        }

    }
}