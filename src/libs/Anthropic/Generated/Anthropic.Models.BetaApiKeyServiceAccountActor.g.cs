
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApiKeyServiceAccountActor
    {
        /// <summary>
        /// ID of the Service Account the API key acts as.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Principal type. Always `"service_account_actor"` for a Service Account.<br/>
        /// Default Value: service_account_actor
        /// </summary>
        /// <default>"service_account_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account_actor";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyServiceAccountActor" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the Service Account the API key acts as.
        /// </param>
        /// <param name="type">
        /// Principal type. Always `"service_account_actor"` for a Service Account.<br/>
        /// Default Value: service_account_actor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApiKeyServiceAccountActor(
            string serviceAccountId,
            string type = "service_account_actor")
        {
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyServiceAccountActor" /> class.
        /// </summary>
        public BetaApiKeyServiceAccountActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaApiKeyServiceAccountActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaApiKeyServiceAccountActor FromServiceAccountId(string serviceAccountId)
        {
            return new BetaApiKeyServiceAccountActor
            {
                ServiceAccountId = serviceAccountId,
            };
        }

    }
}