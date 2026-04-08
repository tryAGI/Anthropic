
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Tool calls are automatically approved without user confirmation.
    /// </summary>
    public sealed partial class BetaManagedAgentsAlwaysAllowPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAlwaysAllowPolicyTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicyType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAlwaysAllowPolicy" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAlwaysAllowPolicy(
            global::Anthropic.BetaManagedAgentsAlwaysAllowPolicyType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAlwaysAllowPolicy" /> class.
        /// </summary>
        public BetaManagedAgentsAlwaysAllowPolicy()
        {
        }
    }
}