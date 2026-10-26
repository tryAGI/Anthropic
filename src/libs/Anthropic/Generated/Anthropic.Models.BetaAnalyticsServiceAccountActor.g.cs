
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsServiceAccountActor
    {
        /// <summary>
        /// Tagged service account ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="BetaAnalyticsServiceAccountActor" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// Tagged service account ID.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsServiceAccountActor(
            string serviceAccountId,
            string type = "service_account_actor")
        {
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsServiceAccountActor" /> class.
        /// </summary>
        public BetaAnalyticsServiceAccountActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaAnalyticsServiceAccountActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaAnalyticsServiceAccountActor FromServiceAccountId(string serviceAccountId)
        {
            return new BetaAnalyticsServiceAccountActor
            {
                ServiceAccountId = serviceAccountId,
            };
        }

    }
}