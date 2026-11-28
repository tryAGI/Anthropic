
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has stopped waiting for a response. A closed case stays closed.
    /// </summary>
    public sealed partial class BetaComplianceReviewCaseClosed
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"closed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "closed";

        /// <summary>
        /// Why the case closed. It doesn't change afterwards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewCaseCloseReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCaseClosed" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why the case closed. It doesn't change afterwards.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewCaseClosed(
            global::Anthropic.BetaComplianceReviewCaseCloseReason reason,
            string type = "closed")
        {
            this.Type = type;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCaseClosed" /> class.
        /// </summary>
        public BetaComplianceReviewCaseClosed()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaComplianceReviewCaseClosed"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaComplianceReviewCaseClosed FromReason(global::Anthropic.BetaComplianceReviewCaseCloseReason reason)
        {
            return new BetaComplianceReviewCaseClosed
            {
                Reason = reason,
            };
        }

    }
}