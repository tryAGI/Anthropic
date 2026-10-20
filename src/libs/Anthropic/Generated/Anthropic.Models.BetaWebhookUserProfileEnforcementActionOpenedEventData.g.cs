
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWebhookUserProfileEnforcementActionOpenedEventData
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_profile.enforcement_action_opened"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_profile.enforcement_action_opened";

        /// <summary>
        /// ID of the user profile the enforcement action is on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// ID (`enac_...`) of the enforcement action that was opened or resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement_action_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnforcementActionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookUserProfileEnforcementActionOpenedEventData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the user profile the enforcement action is on.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="enforcementActionId">
        /// ID (`enac_...`) of the enforcement action that was opened or resolved.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebhookUserProfileEnforcementActionOpenedEventData(
            string id,
            string organizationId,
            string enforcementActionId,
            string type = "user_profile.enforcement_action_opened")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.EnforcementActionId = enforcementActionId ?? throw new global::System.ArgumentNullException(nameof(enforcementActionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebhookUserProfileEnforcementActionOpenedEventData" /> class.
        /// </summary>
        public BetaWebhookUserProfileEnforcementActionOpenedEventData()
        {
        }

    }
}