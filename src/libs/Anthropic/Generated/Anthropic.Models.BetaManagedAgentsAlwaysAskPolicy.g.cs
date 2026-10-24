
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Tool calls require user confirmation before execution.
    /// </summary>
    public sealed partial class BetaManagedAgentsAlwaysAskPolicy
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"always_ask"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "always_ask";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAlwaysAskPolicy" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAlwaysAskPolicy(
            string type = "always_ask")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAlwaysAskPolicy" /> class.
        /// </summary>
        public BetaManagedAgentsAlwaysAskPolicy()
        {
        }

    }
}