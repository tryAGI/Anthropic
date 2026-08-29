
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkspaceRateLimitValue
    {
        /// <summary>
        /// The organization-level value for the same limiter type, for reference. `null` when the organization has no limit configured for this limiter type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_limit")]
        public int? OrgLimit { get; set; }

        /// <summary>
        /// The limiter type (for example, `requests_per_minute` or `input_tokens_per_minute`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The workspace-level override value for this limiter type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimitValue" /> class.
        /// </summary>
        /// <param name="type">
        /// The limiter type (for example, `requests_per_minute` or `input_tokens_per_minute`).
        /// </param>
        /// <param name="value">
        /// The workspace-level override value for this limiter type.
        /// </param>
        /// <param name="orgLimit">
        /// The organization-level value for the same limiter type, for reference. `null` when the organization has no limit configured for this limiter type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceRateLimitValue(
            string type,
            int value,
            int? orgLimit)
        {
            this.OrgLimit = orgLimit;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimitValue" /> class.
        /// </summary>
        public BetaWorkspaceRateLimitValue()
        {
        }

    }
}