
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
        /// <default>"client_secret_post"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "client_secret_post";

        /// <summary>
        /// A new OAuth client secret to replace the stored one.<br/>
        /// The credential must already use `client_secret_basic` or `client_secret_post`. It keeps its current `token_endpoint_auth` type, even if the `type` sent with this secret is the other one.
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
        /// <param name="clientSecret">
        /// A new OAuth client secret to replace the stored one.<br/>
        /// The credential must already use `client_secret_basic` or `client_secret_post`. It keeps its current `token_endpoint_auth` type, even if the `type` sent with this secret is the other one.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTokenEndpointAuthPostUpdateParam(
            string? clientSecret,
            string type = "client_secret_post")
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