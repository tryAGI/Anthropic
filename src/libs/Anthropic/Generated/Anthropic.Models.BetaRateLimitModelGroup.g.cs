
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRateLimitModelGroup
    {
        /// <summary>
        /// Human-readable name of the model group (for example, `Claude Sonnet 4.x`). For display only; it may change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Opaque identifier of the rate-limit group (for example, `rlg_01VPTCmyiu5ZLsWkcxYG2pY8`). It is the same in every organization and never changes, unlike the entry's own identifier, which differs per organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Always `model_group`: a family of models.<br/>
        /// Default Value: model_group
        /// </summary>
        /// <default>"model_group"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "model_group";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRateLimitModelGroup" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable name of the model group (for example, `Claude Sonnet 4.x`). For display only; it may change.
        /// </param>
        /// <param name="id">
        /// Opaque identifier of the rate-limit group (for example, `rlg_01VPTCmyiu5ZLsWkcxYG2pY8`). It is the same in every organization and never changes, unlike the entry's own identifier, which differs per organization.
        /// </param>
        /// <param name="type">
        /// Always `model_group`: a family of models.<br/>
        /// Default Value: model_group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRateLimitModelGroup(
            string displayName,
            string id,
            string type = "model_group")
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRateLimitModelGroup" /> class.
        /// </summary>
        public BetaRateLimitModelGroup()
        {
        }

    }
}