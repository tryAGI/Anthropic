
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Token endpoint uses HTTP Basic authentication with client credentials.
    /// </summary>
    public sealed partial class BetaManagedAgentsTokenEndpointAuthBasicParam
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"client_secret_basic"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "client_secret_basic";

        /// <summary>
        /// The OAuth client secret, sent to `token_endpoint` with HTTP Basic authentication.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthBasicParam" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// The OAuth client secret, sent to `token_endpoint` with HTTP Basic authentication.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTokenEndpointAuthBasicParam(
            string clientSecret,
            string type = "client_secret_basic")
        {
            this.Type = type;
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTokenEndpointAuthBasicParam" /> class.
        /// </summary>
        public BetaManagedAgentsTokenEndpointAuthBasicParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsTokenEndpointAuthBasicParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsTokenEndpointAuthBasicParam FromClientSecret(string clientSecret)
        {
            return new BetaManagedAgentsTokenEndpointAuthBasicParam
            {
                ClientSecret = clientSecret,
            };
        }

    }
}