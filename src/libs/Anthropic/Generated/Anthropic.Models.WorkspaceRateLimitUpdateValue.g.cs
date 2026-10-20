
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspaceRateLimitUpdateValue
    {
        /// <summary>
        /// Rate limiter type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.WorkspaceRateLimitUpdateValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.WorkspaceRateLimitUpdateValueType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkspaceRateLimitUpdateValue" /> class.
        /// </summary>
        /// <param name="type">
        /// Rate limiter type.
        /// </param>
        /// <param name="value">
        /// New limit value. Set to null to clear the workspace override and fall back to the organization limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceRateLimitUpdateValue(
            global::Anthropic.WorkspaceRateLimitUpdateValueType type,
            long? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceRateLimitUpdateValue" /> class.
        /// </summary>
        public WorkspaceRateLimitUpdateValue()
        {
        }

    }
}