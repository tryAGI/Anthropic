
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A URL to give to the person who takes the requested action.<br/>
    /// Example: {"type":"user_profile_action_url","url":"https://platform.claude.com/user-profiles/enrollment/M3J0bGJxZ2ppMnptbnB1","expires_at":"2026-03-15T10:15:00Z"}
    /// </summary>
    public sealed partial class BetaUserProfileActionUrl
    {
        /// <summary>
        /// Object type. Always `user_profile_action_url`.
        /// </summary>
        /// <default>"user_profile_action_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_profile_action_url";

        /// <summary>
        /// The URL to give to the person who takes the action. Anyone who holds it can open it until `expires_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// When the URL stops working, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileActionUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to give to the person who takes the action. Anyone who holds it can open it until `expires_at`.
        /// </param>
        /// <param name="expiresAt">
        /// When the URL stops working, in RFC 3339 format.
        /// </param>
        /// <param name="type">
        /// Object type. Always `user_profile_action_url`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfileActionUrl(
            string url,
            global::System.DateTime expiresAt,
            string type = "user_profile_action_url")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileActionUrl" /> class.
        /// </summary>
        public BetaUserProfileActionUrl()
        {
        }

    }
}