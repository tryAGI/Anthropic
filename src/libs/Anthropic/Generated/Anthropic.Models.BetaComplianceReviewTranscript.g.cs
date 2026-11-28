
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One flagged message of a review case.
    /// </summary>
    public sealed partial class BetaComplianceReviewTranscript
    {
        /// <summary>
        /// The ID of the flagged message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The ID of the user profile that the message belongs to. Null when the message belongs to none, or when the profile can no longer be looked up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewTranscript" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the flagged message.
        /// </param>
        /// <param name="userProfileId">
        /// The ID of the user profile that the message belongs to. Null when the message belongs to none, or when the profile can no longer be looked up.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewTranscript(
            string itemId,
            string? userProfileId)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.UserProfileId = userProfileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewTranscript" /> class.
        /// </summary>
        public BetaComplianceReviewTranscript()
        {
        }

    }
}