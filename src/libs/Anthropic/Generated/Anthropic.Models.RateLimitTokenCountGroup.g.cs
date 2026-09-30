
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RateLimitTokenCountGroup
    {
        /// <summary>
        /// Opaque identifier of the rate-limit group (for example, `rlg_01VPTCmyiu5ZLsWkcxYG2pY8`). It is the same in every organization and never changes, unlike the entry's own identifier, which differs per organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `token_count`: the Token Count API.<br/>
        /// Default Value: token_count
        /// </summary>
        /// <default>"token_count"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "token_count";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitTokenCountGroup" /> class.
        /// </summary>
        /// <param name="id">
        /// Opaque identifier of the rate-limit group (for example, `rlg_01VPTCmyiu5ZLsWkcxYG2pY8`). It is the same in every organization and never changes, unlike the entry's own identifier, which differs per organization.
        /// </param>
        /// <param name="type">
        /// Always `token_count`: the Token Count API.<br/>
        /// Default Value: token_count
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitTokenCountGroup(
            string id,
            string type = "token_count")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitTokenCountGroup" /> class.
        /// </summary>
        public RateLimitTokenCountGroup()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RateLimitTokenCountGroup"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RateLimitTokenCountGroup FromId(string id)
        {
            return new RateLimitTokenCountGroup
            {
                Id = id,
            };
        }

    }
}