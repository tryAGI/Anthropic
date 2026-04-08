
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsCommitCheckout
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCommitCheckoutTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCommitCheckoutType Type { get; set; }

        /// <summary>
        /// Full commit SHA to check out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCommitCheckout" /> class.
        /// </summary>
        /// <param name="sha">
        /// Full commit SHA to check out.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCommitCheckout(
            string sha,
            global::Anthropic.BetaManagedAgentsCommitCheckoutType type)
        {
            this.Type = type;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCommitCheckout" /> class.
        /// </summary>
        public BetaManagedAgentsCommitCheckout()
        {
        }
    }
}