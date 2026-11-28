
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A signed-in user.
    /// </summary>
    public sealed partial class BetaComplianceReviewUserActor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_actor";

        /// <summary>
        /// The ID of the user (`user_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The user's email address. Set only for a current member of an organization that the API key can read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewUserActor" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user (`user_...`).
        /// </param>
        /// <param name="emailAddress">
        /// The user's email address. Set only for a current member of an organization that the API key can read.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewUserActor(
            string userId,
            string? emailAddress,
            string type = "user_actor")
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewUserActor" /> class.
        /// </summary>
        public BetaComplianceReviewUserActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaComplianceReviewUserActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaComplianceReviewUserActor FromUserId(string userId)
        {
            return new BetaComplianceReviewUserActor
            {
                UserId = userId,
            };
        }

    }
}