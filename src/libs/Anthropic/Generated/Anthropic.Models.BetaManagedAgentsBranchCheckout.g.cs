
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"type":"branch","name":"main"}
    /// </summary>
    public sealed partial class BetaManagedAgentsBranchCheckout
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsBranchCheckoutTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsBranchCheckoutType Type { get; set; }

        /// <summary>
        /// Branch name to check out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBranchCheckout" /> class.
        /// </summary>
        /// <param name="name">
        /// Branch name to check out.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsBranchCheckout(
            string name,
            global::Anthropic.BetaManagedAgentsBranchCheckoutType type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsBranchCheckout" /> class.
        /// </summary>
        public BetaManagedAgentsBranchCheckout()
        {
        }
    }
}