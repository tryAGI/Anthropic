
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A scoped Admin API key acting on behalf of the organization.
    /// </summary>
    public sealed partial class BetaScopedApiKeyActorSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoped_api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopedApiKeyId { get; set; }

        /// <summary>
        /// Default Value: scoped_api_key_actor
        /// </summary>
        /// <default>"scoped_api_key_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "scoped_api_key_actor";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaScopedApiKeyActorSchema" /> class.
        /// </summary>
        /// <param name="scopedApiKeyId"></param>
        /// <param name="type">
        /// Default Value: scoped_api_key_actor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaScopedApiKeyActorSchema(
            string scopedApiKeyId,
            string type = "scoped_api_key_actor")
        {
            this.ScopedApiKeyId = scopedApiKeyId ?? throw new global::System.ArgumentNullException(nameof(scopedApiKeyId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaScopedApiKeyActorSchema" /> class.
        /// </summary>
        public BetaScopedApiKeyActorSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaScopedApiKeyActorSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaScopedApiKeyActorSchema FromScopedApiKeyId(string scopedApiKeyId)
        {
            return new BetaScopedApiKeyActorSchema
            {
                ScopedApiKeyId = scopedApiKeyId,
            };
        }

    }
}