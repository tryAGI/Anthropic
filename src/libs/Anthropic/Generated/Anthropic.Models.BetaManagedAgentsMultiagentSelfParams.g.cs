
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Sentinel roster entry meaning "the agent that owns this configuration". Resolved server-side to a concrete agent reference.<br/>
    /// Example: {"type":"self"}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentSelfParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"self"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "self";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentSelfParams" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentSelfParams(
            string type = "self")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentSelfParams" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentSelfParams()
        {
        }

    }
}