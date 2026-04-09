
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseAdvisorRedactedResultBlock
    {
        /// <summary>
        /// Opaque blob containing the advisor's output. Round-trip verbatim; do not inspect or modify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedContent { get; set; }

        /// <summary>
        /// Default Value: advisor_redacted_result
        /// </summary>
        /// <default>"advisor_redacted_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "advisor_redacted_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseAdvisorRedactedResultBlock" /> class.
        /// </summary>
        /// <param name="encryptedContent">
        /// Opaque blob containing the advisor's output. Round-trip verbatim; do not inspect or modify.
        /// </param>
        /// <param name="type">
        /// Default Value: advisor_redacted_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseAdvisorRedactedResultBlock(
            string encryptedContent,
            string type = "advisor_redacted_result")
        {
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseAdvisorRedactedResultBlock" /> class.
        /// </summary>
        public BetaResponseAdvisorRedactedResultBlock()
        {
        }
    }
}