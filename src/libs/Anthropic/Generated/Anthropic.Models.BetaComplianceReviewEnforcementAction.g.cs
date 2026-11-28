
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An action that Anthropic took on the flagged traffic.
    /// </summary>
    public sealed partial class BetaComplianceReviewEnforcementAction
    {
        /// <summary>
        /// The kind of action. New values can appear, so accept a value that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewEnforcementAction" /> class.
        /// </summary>
        /// <param name="type">
        /// The kind of action. New values can appear, so accept a value that you don't know.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewEnforcementAction(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewEnforcementAction" /> class.
        /// </summary>
        public BetaComplianceReviewEnforcementAction()
        {
        }

    }
}