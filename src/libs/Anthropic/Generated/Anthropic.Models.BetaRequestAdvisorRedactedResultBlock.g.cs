
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestAdvisorRedactedResultBlock
    {
        /// <summary>
        /// Opaque blob produced by a prior response; must be round-tripped verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedContent { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="BetaRequestAdvisorRedactedResultBlock" /> class.
        /// </summary>
        /// <param name="encryptedContent">
        /// Opaque blob produced by a prior response; must be round-tripped verbatim.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestAdvisorRedactedResultBlock(
            string encryptedContent,
            string type = "advisor_redacted_result")
        {
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestAdvisorRedactedResultBlock" /> class.
        /// </summary>
        public BetaRequestAdvisorRedactedResultBlock()
        {
        }
    }
}