
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A hard spend ceiling. The session stops issuing new model requests once the tracked list cost reaches `max_list_cost`.
    /// </summary>
    public sealed partial class BetaManagedAgentsBudgetLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBudgetLimitTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsBudgetLimitType Type { get; set; }

        /// <summary>
        /// Maximum list cost the session may accrue. List price is used regardless of any negotiated discount, so the cap fires at or before the actual charge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_list_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaMonetaryAmount MaxListCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBudgetLimit" /> class.
        /// </summary>
        /// <param name="maxListCost">
        /// Maximum list cost the session may accrue. List price is used regardless of any negotiated discount, so the cap fires at or before the actual charge.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsBudgetLimit(
            global::Anthropic.BetaMonetaryAmount maxListCost,
            global::Anthropic.BetaManagedAgentsBudgetLimitType type)
        {
            this.Type = type;
            this.MaxListCost = maxListCost ?? throw new global::System.ArgumentNullException(nameof(maxListCost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBudgetLimit" /> class.
        /// </summary>
        public BetaManagedAgentsBudgetLimit()
        {
        }

    }
}