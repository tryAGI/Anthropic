
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsFederatedActorOidcProvider
    {
        /// <summary>
        /// The federation issuer's URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"oidc"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "oidc";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorOidcProvider" /> class.
        /// </summary>
        /// <param name="issuer">
        /// The federation issuer's URL.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFederatedActorOidcProvider(
            string? issuer,
            string type = "oidc")
        {
            this.Issuer = issuer;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorOidcProvider" /> class.
        /// </summary>
        public BetaAnalyticsFederatedActorOidcProvider()
        {
        }

    }
}