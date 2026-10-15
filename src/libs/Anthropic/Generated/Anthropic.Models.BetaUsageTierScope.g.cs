
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Scope of the monthly spend cap Anthropic sets for a Claude Console<br/>
    /// organization from its usage tier, or a higher cap Anthropic granted the<br/>
    /// organization. Read-only; its `created_at` and `updated_at` are the<br/>
    /// organization's creation time, so `amount` can change while `updated_at` stays<br/>
    /// the same.
    /// </summary>
    public sealed partial class BetaUsageTierScope
    {
        /// <summary>
        /// Scope type. Always `usage_tier` for this scope.<br/>
        /// Default Value: usage_tier
        /// </summary>
        /// <default>"usage_tier"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "usage_tier";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsageTierScope" /> class.
        /// </summary>
        /// <param name="type">
        /// Scope type. Always `usage_tier` for this scope.<br/>
        /// Default Value: usage_tier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUsageTierScope(
            string type = "usage_tier")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsageTierScope" /> class.
        /// </summary>
        public BetaUsageTierScope()
        {
        }

    }
}