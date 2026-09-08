
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user in the organization, identified by tagged id and email address.
    /// </summary>
    public sealed partial class BetaAnalyticsUser
    {
        /// <summary>
        /// Email address of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// Tagged user identifier (e.g. `user_...`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type. Always `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUser" /> class.
        /// </summary>
        /// <param name="emailAddress">
        /// Email address of the user
        /// </param>
        /// <param name="id">
        /// Tagged user identifier (e.g. `user_...`)
        /// </param>
        /// <param name="type">
        /// Object type. Always `user`.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsUser(
            string emailAddress,
            string id,
            string type = "user")
        {
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUser" /> class.
        /// </summary>
        public BetaAnalyticsUser()
        {
        }

    }
}