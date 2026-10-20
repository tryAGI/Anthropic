
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One tier of the Cyber Verification Program.<br/>
    /// Example: {"status":"active"}
    /// </summary>
    public sealed partial class UserProfileCyberTier
    {
        /// <summary>
        /// `active` when the tier applies to the profile, otherwise `inactive`. The response does not say why a tier is `inactive`: it can be in review, declined, withdrawn, never applied for, or approved but not applied to this profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileCyberTierStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileCyberTierStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileCyberTier" /> class.
        /// </summary>
        /// <param name="status">
        /// `active` when the tier applies to the profile, otherwise `inactive`. The response does not say why a tier is `inactive`: it can be in review, declined, withdrawn, never applied for, or approved but not applied to this profile.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileCyberTier(
            global::Anthropic.UserProfileCyberTierStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileCyberTier" /> class.
        /// </summary>
        public UserProfileCyberTier()
        {
        }

    }
}