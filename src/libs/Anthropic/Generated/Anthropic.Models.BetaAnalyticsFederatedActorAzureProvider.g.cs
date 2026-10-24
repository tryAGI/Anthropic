
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsFederatedActorAzureProvider
    {
        /// <summary>
        /// The Azure subscription the organization is bound to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"azure"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "azure";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorAzureProvider" /> class.
        /// </summary>
        /// <param name="subscriptionId">
        /// The Azure subscription the organization is bound to.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFederatedActorAzureProvider(
            string subscriptionId,
            string type = "azure")
        {
            this.SubscriptionId = subscriptionId ?? throw new global::System.ArgumentNullException(nameof(subscriptionId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorAzureProvider" /> class.
        /// </summary>
        public BetaAnalyticsFederatedActorAzureProvider()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaAnalyticsFederatedActorAzureProvider"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaAnalyticsFederatedActorAzureProvider FromSubscriptionId(string subscriptionId)
        {
            return new BetaAnalyticsFederatedActorAzureProvider
            {
                SubscriptionId = subscriptionId,
            };
        }

    }
}