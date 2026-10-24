
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A human user, for example acting through the Anthropic Console.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserActor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_actor";

        /// <summary>
        /// ID of the user (a `user_...` value).
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserActor" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the user (a `user_...` value).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserActor(
            string userId,
            string type = "user_actor")
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserActor" /> class.
        /// </summary>
        public BetaManagedAgentsUserActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsUserActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsUserActor FromUserId(string userId)
        {
            return new BetaManagedAgentsUserActor
            {
                UserId = userId,
            };
        }

    }
}