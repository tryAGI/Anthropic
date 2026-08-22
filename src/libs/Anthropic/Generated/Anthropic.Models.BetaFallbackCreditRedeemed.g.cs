
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The reprice was applied: the retry is billed as if the conversation<br/>
    /// had been on the retry model all along.
    /// </summary>
    public sealed partial class BetaFallbackCreditRedeemed
    {
        /// <summary>
        /// Default Value: redeemed
        /// </summary>
        /// <default>"redeemed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "redeemed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditRedeemed" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: redeemed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFallbackCreditRedeemed(
            string type = "redeemed")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackCreditRedeemed" /> class.
        /// </summary>
        public BetaFallbackCreditRedeemed()
        {
        }

    }
}