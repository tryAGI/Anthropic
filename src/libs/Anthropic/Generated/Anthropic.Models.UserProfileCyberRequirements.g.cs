
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What a request that names the profile must allow to get the relaxed safeguards of the profile's `active` tiers. A field reads `true` when at least one of those tiers has the requirement and Anthropic has not waived it on that tier for the profile. A request that does not meet a requirement is still served, without the relaxed safeguards of the tiers that have it. The values differ between profiles and can change, so read them rather than assuming them.<br/>
    /// Example: {"data_retention":true,"human_review":true}
    /// </summary>
    public sealed partial class UserProfileCyberRequirements
    {
        /// <summary>
        /// Whether Anthropic must be able to retain the request's inference data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_retention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DataRetention { get; set; }

        /// <summary>
        /// Whether Anthropic personnel must be allowed to review the data retained from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_review")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HumanReview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileCyberRequirements" /> class.
        /// </summary>
        /// <param name="dataRetention">
        /// Whether Anthropic must be able to retain the request's inference data.
        /// </param>
        /// <param name="humanReview">
        /// Whether Anthropic personnel must be allowed to review the data retained from the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileCyberRequirements(
            bool dataRetention,
            bool humanReview)
        {
            this.DataRetention = dataRetention;
            this.HumanReview = humanReview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileCyberRequirements" /> class.
        /// </summary>
        public UserProfileCyberRequirements()
        {
        }

    }
}