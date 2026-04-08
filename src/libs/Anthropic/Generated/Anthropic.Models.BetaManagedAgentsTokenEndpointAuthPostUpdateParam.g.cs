
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Updated POST body authentication parameters for the token endpoint.
    /// </summary>
    public sealed partial class BetaManagedAgentsTokenEndpointAuthPostUpdateParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostUpdateParamTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParamType Type { get; set; }

        /// <summary>
        /// Updated OAuth client secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthPostUpdateParam" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="clientSecret">
        /// Updated OAuth client secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTokenEndpointAuthPostUpdateParam(
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParamType type,
            string? clientSecret)
        {
            this.Type = type;
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthPostUpdateParam" /> class.
        /// </summary>
        public BetaManagedAgentsTokenEndpointAuthPostUpdateParam()
        {
        }
    }
}