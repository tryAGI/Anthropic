
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Scope selecting a single member of the organization.
    /// </summary>
    public sealed partial class BetaUserScope
    {
        /// <summary>
        /// Scope type. Always `user` for this scope.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

        /// <summary>
        /// Tagged ID of the member the spend limit applies to.
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
        /// Initializes a new instance of the <see cref="BetaUserScope" /> class.
        /// </summary>
        /// <param name="userId">
        /// Tagged ID of the member the spend limit applies to.
        /// </param>
        /// <param name="type">
        /// Scope type. Always `user` for this scope.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserScope(
            string userId,
            string type = "user")
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserScope" /> class.
        /// </summary>
        public BetaUserScope()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaUserScope"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaUserScope FromUserId(string userId)
        {
            return new BetaUserScope
            {
                UserId = userId,
            };
        }

    }
}