
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The secret is substituted on any host the session's Environment network policy permits egress to.
    /// </summary>
    public sealed partial class BetaManagedAgentsUnrestrictedCredentialNetworkingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUnrestrictedCredentialNetworkingResponseTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUnrestrictedCredentialNetworkingResponse" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUnrestrictedCredentialNetworkingResponse(
            global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponseType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUnrestrictedCredentialNetworkingResponse" /> class.
        /// </summary>
        public BetaManagedAgentsUnrestrictedCredentialNetworkingResponse()
        {
        }

    }
}