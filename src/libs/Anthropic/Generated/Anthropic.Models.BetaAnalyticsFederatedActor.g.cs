
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsFederatedActor
    {
        /// <summary>
        /// The trusted provider that asserted the caller's identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaAnalyticsFederatedActorProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsFederatedActorProvider Provider { get; set; }

        /// <summary>
        /// The provider's identifier for the caller: on `aws`, the IAM principal ARN (one role is one actor across its sessions); on `gcp`, the caller's IAM principal identifier as Google Cloud reports it, such as `serviceAccount:&lt;email&gt;`, `user:&lt;email&gt;`, or a `principal://...` URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"federated_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "federated_actor";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActor" /> class.
        /// </summary>
        /// <param name="provider">
        /// The trusted provider that asserted the caller's identity.
        /// </param>
        /// <param name="subject">
        /// The provider's identifier for the caller: on `aws`, the IAM principal ARN (one role is one actor across its sessions); on `gcp`, the caller's IAM principal identifier as Google Cloud reports it, such as `serviceAccount:&lt;email&gt;`, `user:&lt;email&gt;`, or a `principal://...` URI.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFederatedActor(
            global::Anthropic.BetaAnalyticsFederatedActorProvider provider,
            string? subject,
            string type = "federated_actor")
        {
            this.Provider = provider;
            this.Subject = subject;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActor" /> class.
        /// </summary>
        public BetaAnalyticsFederatedActor()
        {
        }

    }
}