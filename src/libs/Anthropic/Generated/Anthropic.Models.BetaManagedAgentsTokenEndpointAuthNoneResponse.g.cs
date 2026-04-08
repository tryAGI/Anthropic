
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Token endpoint requires no client authentication.
    /// </summary>
    public sealed partial class BetaManagedAgentsTokenEndpointAuthNoneResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthNoneResponseTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponseType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthNoneResponse" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTokenEndpointAuthNoneResponse(
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponseType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthNoneResponse" /> class.
        /// </summary>
        public BetaManagedAgentsTokenEndpointAuthNoneResponse()
        {
        }
    }
}