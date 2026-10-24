
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
        /// <default>"client_secret_post"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "client_secret_post";

        /// <summary>
        /// The OAuth client secret, sent to `token_endpoint` in the POST body.
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
        /// The OAuth client secret, sent to `token_endpoint` in the POST body.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTokenEndpointAuthPostParam(
            string clientSecret,
            string type = "client_secret_post")
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

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsTokenEndpointAuthPostParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsTokenEndpointAuthPostParam FromClientSecret(string clientSecret)
        {
            return new BetaManagedAgentsTokenEndpointAuthPostParam
            {
                ClientSecret = clientSecret,
            };
        }

    }
}