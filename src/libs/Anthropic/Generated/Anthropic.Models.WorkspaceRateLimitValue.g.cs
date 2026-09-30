
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspaceRateLimitValue
    {
        /// <summary>
        /// The organization-level value for the same limiter type, for reference. `null` when the organization has no limit configured for this limiter type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_limit")]
        public int? OrgLimit { get; set; }

        /// <summary>
        /// Where `value` comes from. `organization` values are listed only when `include_inherited` is `true`, and then `value` equals `org_limit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Source9JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Source9 Source { get; set; }

        /// <summary>
        /// The limiter type (for example, `requests_per_minute` or `input_tokens_per_minute`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The workspace's value for this limiter type: the workspace-level override when `source.type` is `workspace`, otherwise the organization's value.
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
        /// Initializes a new instance of the <see cref="WorkspaceRateLimitValue" /> class.
        /// </summary>
        /// <param name="source">
        /// Where `value` comes from. `organization` values are listed only when `include_inherited` is `true`, and then `value` equals `org_limit`.
        /// </param>
        /// <param name="type">
        /// The limiter type (for example, `requests_per_minute` or `input_tokens_per_minute`).
        /// </param>
        /// <param name="value">
        /// The workspace's value for this limiter type: the workspace-level override when `source.type` is `workspace`, otherwise the organization's value.
        /// </param>
        /// <param name="orgLimit">
        /// The organization-level value for the same limiter type, for reference. `null` when the organization has no limit configured for this limiter type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceRateLimitValue(
            global::Anthropic.Source9 source,
            string type,
            int value,
            int? orgLimit)
        {
            this.OrgLimit = orgLimit;
            this.Source = source;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceRateLimitValue" /> class.
        /// </summary>
        public WorkspaceRateLimitValue()
        {
        }

    }
}