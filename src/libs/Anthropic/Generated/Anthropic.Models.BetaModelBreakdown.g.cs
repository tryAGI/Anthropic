
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaModelBreakdown
    {
        /// <summary>
        /// Estimated cost for using this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaEstimatedCost EstimatedCost { get; set; }

        /// <summary>
        /// Name of the AI model used for Claude Code interactions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Token usage breakdown for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTokenUsage Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModelBreakdown" /> class.
        /// </summary>
        /// <param name="estimatedCost">
        /// Estimated cost for using this model
        /// </param>
        /// <param name="model">
        /// Name of the AI model used for Claude Code interactions.
        /// </param>
        /// <param name="tokens">
        /// Token usage breakdown for this model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaModelBreakdown(
            global::Anthropic.BetaEstimatedCost estimatedCost,
            string model,
            global::Anthropic.BetaTokenUsage tokens)
        {
            this.EstimatedCost = estimatedCost ?? throw new global::System.ArgumentNullException(nameof(estimatedCost));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModelBreakdown" /> class.
        /// </summary>
        public BetaModelBreakdown()
        {
        }

    }
}