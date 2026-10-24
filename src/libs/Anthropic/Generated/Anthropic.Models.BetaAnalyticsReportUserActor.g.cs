
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsReportUserActor
    {
        /// <summary>
        /// True when the account has been deleted, or when the user is no longer a member of the organization or its associated organizations (for example, their membership was removed or they were deprovisioned via your identity provider). `email_address` stays populated for removed users and is null when the account has been deleted. `name` follows the rules described on that field. The `user_id` is still populated for reconciliation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The user's current email address, including for users who are no longer members of the organization. Null when the account has been deleted and for system-minted service accounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// The user's current full name. Null when the user has not set one. `"Deleted User"` when the account has been deleted, or when the user is no longer a member and the organization hides removed users' names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Actor type. Always `"user_actor"`.
        /// </summary>
        /// <default>"user_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_actor";

        /// <summary>
        /// Tagged user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsReportUserActor" /> class.
        /// </summary>
        /// <param name="deleted">
        /// True when the account has been deleted, or when the user is no longer a member of the organization or its associated organizations (for example, their membership was removed or they were deprovisioned via your identity provider). `email_address` stays populated for removed users and is null when the account has been deleted. `name` follows the rules described on that field. The `user_id` is still populated for reconciliation.
        /// </param>
        /// <param name="userId">
        /// Tagged user ID.
        /// </param>
        /// <param name="emailAddress">
        /// The user's current email address, including for users who are no longer members of the organization. Null when the account has been deleted and for system-minted service accounts.
        /// </param>
        /// <param name="name">
        /// The user's current full name. Null when the user has not set one. `"Deleted User"` when the account has been deleted, or when the user is no longer a member and the organization hides removed users' names.
        /// </param>
        /// <param name="type">
        /// Actor type. Always `"user_actor"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsReportUserActor(
            bool deleted,
            string userId,
            string? emailAddress,
            string? name,
            string type = "user_actor")
        {
            this.Deleted = deleted;
            this.EmailAddress = emailAddress;
            this.Name = name;
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsReportUserActor" /> class.
        /// </summary>
        public BetaAnalyticsReportUserActor()
        {
        }

    }
}