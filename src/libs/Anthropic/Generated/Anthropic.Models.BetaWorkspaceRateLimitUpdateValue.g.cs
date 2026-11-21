
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkspaceRateLimitUpdateValue
    {
        /// <summary>
        /// Rate limiter type. `input_tokens_per_minute` counts every input token, cache reads included. `input_tokens_per_minute_cache_aware` does not count cache reads, and on current models the organization's input-token limit usually has this type. A workspace limit of either type applies alongside the organization's limit, not in place of it. Because cache reads count toward an `input_tokens_per_minute` limit, it can reject requests that read mostly from the cache while the organization's limit still has room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWorkspaceRateLimitUpdateValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaWorkspaceRateLimitUpdateValueType Type { get; set; }

        /// <summary>
        /// New limit value. Set to null to clear the workspace override and fall back to the organization limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public long? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimitUpdateValue" /> class.
        /// </summary>
        /// <param name="type">
        /// Rate limiter type. `input_tokens_per_minute` counts every input token, cache reads included. `input_tokens_per_minute_cache_aware` does not count cache reads, and on current models the organization's input-token limit usually has this type. A workspace limit of either type applies alongside the organization's limit, not in place of it. Because cache reads count toward an `input_tokens_per_minute` limit, it can reject requests that read mostly from the cache while the organization's limit still has room.
        /// </param>
        /// <param name="value">
        /// New limit value. Set to null to clear the workspace override and fall back to the organization limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceRateLimitUpdateValue(
            global::Anthropic.BetaWorkspaceRateLimitUpdateValueType type,
            long? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimitUpdateValue" /> class.
        /// </summary>
        public BetaWorkspaceRateLimitUpdateValue()
        {
        }

    }
}