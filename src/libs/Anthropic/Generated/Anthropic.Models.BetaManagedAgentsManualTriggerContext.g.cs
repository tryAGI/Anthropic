
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The run was started manually by creating a session directly against the deployment.
    /// </summary>
    public sealed partial class BetaManagedAgentsManualTriggerContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsManualTriggerContextTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsManualTriggerContextType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsManualTriggerContext" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsManualTriggerContext(
            global::Anthropic.BetaManagedAgentsManualTriggerContextType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsManualTriggerContext" /> class.
        /// </summary>
        public BetaManagedAgentsManualTriggerContext()
        {
        }

    }
}