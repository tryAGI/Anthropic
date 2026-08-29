
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeUserActor
    {
        /// <summary>
        /// Email address of the user who performed Claude Code actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// Actor type. Always `"user_actor"` for a user.
        /// </summary>
        /// <default>"user_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_actor";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeUserActor" /> class.
        /// </summary>
        /// <param name="emailAddress">
        /// Email address of the user who performed Claude Code actions.
        /// </param>
        /// <param name="type">
        /// Actor type. Always `"user_actor"` for a user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeUserActor(
            string emailAddress,
            string type = "user_actor")
        {
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeUserActor" /> class.
        /// </summary>
        public BetaClaudeCodeUserActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeCodeUserActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeCodeUserActor FromEmailAddress(string emailAddress)
        {
            return new BetaClaudeCodeUserActor
            {
                EmailAddress = emailAddress,
            };
        }

    }
}