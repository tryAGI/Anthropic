
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// User-configurable total token budget across contexts.
    /// </summary>
    public sealed partial class BetaTokenTaskBudget
    {
        /// <summary>
        /// Remaining tokens in the budget. Use this to track usage across contexts when implementing compaction client-side. Defaults to total if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Total token budget across all contexts in the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// The budget type. Currently only 'tokens' is supported.
        /// </summary>
        /// <default>"tokens"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tokens";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTokenTaskBudget" /> class.
        /// </summary>
        /// <param name="total">
        /// Total token budget across all contexts in the session.
        /// </param>
        /// <param name="remaining">
        /// Remaining tokens in the budget. Use this to track usage across contexts when implementing compaction client-side. Defaults to total if not provided.
        /// </param>
        /// <param name="type">
        /// The budget type. Currently only 'tokens' is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTokenTaskBudget(
            int total,
            int? remaining,
            string type = "tokens")
        {
            this.Remaining = remaining;
            this.Total = total;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTokenTaskBudget" /> class.
        /// </summary>
        public BetaTokenTaskBudget()
        {
        }
    }
}