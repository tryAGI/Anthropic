
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Token endpoint uses POST body authentication with client credentials.
    /// </summary>
    public sealed partial class BetaManagedAgentsTokenEndpointAuthPostParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTokenEndpointAuthPostParamTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParamType Type { get; set; }

        /// <summary>
        /// OAuth client secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthPostParam" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// OAuth client secret.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTokenEndpointAuthPostParam(
            string clientSecret,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParamType type)
        {
            this.Type = type;
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthPostParam" /> class.
        /// </summary>
        public BetaManagedAgentsTokenEndpointAuthPostParam()
        {
        }
    }
}