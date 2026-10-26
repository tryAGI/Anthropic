
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has stopped serving the end user where the ban applies and does not plan to serve them there again.<br/>
    /// Example: {"type":"ban","id":"enac_011CZkZCu8hGbp5mYRQgUmz9","reason":"usage_policy_violation","action":null,"opened_at":"2026-10-02T19:30:00Z","expires_at":null}
    /// </summary>
    public sealed partial class UserProfileEnforcementActionBan
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"ban"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ban";

        /// <summary>
        /// The action's ID (`enac_...`), stable while the action is open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Why Anthropic placed the limit: `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileEnforcementActionReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileEnforcementActionReason Reason { get; set; }

        /// <summary>
        /// Always `null`: the end user cannot clear a ban.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Anthropic.UserProfileEnforcementActionNextStep? Action { get; set; }

        /// <summary>
        /// When Anthropic opened the action, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opened_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime OpenedAt { get; set; }

        /// <summary>
        /// Always `null`: a ban has no end date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEnforcementActionBan" /> class.
        /// </summary>
        /// <param name="id">
        /// The action's ID (`enac_...`), stable while the action is open.
        /// </param>
        /// <param name="reason">
        /// Why Anthropic placed the limit: `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`.
        /// </param>
        /// <param name="openedAt">
        /// When Anthropic opened the action, in RFC 3339 format.
        /// </param>
        /// <param name="action">
        /// Always `null`: the end user cannot clear a ban.
        /// </param>
        /// <param name="expiresAt">
        /// Always `null`: a ban has no end date.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileEnforcementActionBan(
            string id,
            global::Anthropic.UserProfileEnforcementActionReason reason,
            global::System.DateTime openedAt,
            global::Anthropic.UserProfileEnforcementActionNextStep? action,
            global::System.DateTime? expiresAt,
            string type = "ban")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Reason = reason;
            this.Action = action;
            this.OpenedAt = openedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEnforcementActionBan" /> class.
        /// </summary>
        public UserProfileEnforcementActionBan()
        {
        }

    }
}