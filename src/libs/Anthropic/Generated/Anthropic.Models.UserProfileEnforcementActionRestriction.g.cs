
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has limited how it serves the end user until the action is resolved. The end user may still be served in part.<br/>
    /// Example: {"type":"restriction","id":"enac_011CZkZCu8hGbp5mYRQgUmz9","reason":"fraud_or_abuse","action":"verify","opened_at":"2026-10-02T19:30:00Z","expires_at":null}
    /// </summary>
    public sealed partial class UserProfileEnforcementActionRestriction
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"restriction"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "restriction";

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
        /// The next step on the action: `verify` or `null`. `verify`: the end user can clear it now by passing an identity check. `null`: there is nothing the end user can do now to clear it, including while Anthropic reviews an identity check the end user submitted.
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
        /// When the action ends on its own, in RFC 3339 format; it stops showing once this time has passed. `null` when it has no end date, and always `null` when `reason` is `account_compromise`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEnforcementActionRestriction" /> class.
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
        /// The next step on the action: `verify` or `null`. `verify`: the end user can clear it now by passing an identity check. `null`: there is nothing the end user can do now to clear it, including while Anthropic reviews an identity check the end user submitted.
        /// </param>
        /// <param name="expiresAt">
        /// When the action ends on its own, in RFC 3339 format; it stops showing once this time has passed. `null` when it has no end date, and always `null` when `reason` is `account_compromise`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileEnforcementActionRestriction(
            string id,
            global::Anthropic.UserProfileEnforcementActionReason reason,
            global::System.DateTime openedAt,
            global::Anthropic.UserProfileEnforcementActionNextStep? action,
            global::System.DateTime? expiresAt,
            string type = "restriction")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Reason = reason;
            this.Action = action;
            this.OpenedAt = openedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEnforcementActionRestriction" /> class.
        /// </summary>
        public UserProfileEnforcementActionRestriction()
        {
        }

    }
}