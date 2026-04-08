
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for updating a session resource.<br/>
    /// Example: {"authorization_token":"ghp_exampletoken"}
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateSessionResourceParams
    {
        /// <summary>
        /// New authorization token for the resource. Currently only `github_repository` resources support token rotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorizationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateSessionResourceParams" /> class.
        /// </summary>
        /// <param name="authorizationToken">
        /// New authorization token for the resource. Currently only `github_repository` resources support token rotation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateSessionResourceParams(
            string authorizationToken)
        {
            this.AuthorizationToken = authorizationToken ?? throw new global::System.ArgumentNullException(nameof(authorizationToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateSessionResourceParams" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateSessionResourceParams()
        {
        }
    }
}