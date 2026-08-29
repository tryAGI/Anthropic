
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Attribution for a write made by a workload authenticated as a service account, for example via Workload Identity Federation.
    /// </summary>
    public sealed partial class BetaManagedAgentsServiceAccountActor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"service_account_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account_actor";

        /// <summary>
        /// ID of the service account that performed the write (a `svac_...` value).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsServiceAccountActor" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// ID of the service account that performed the write (a `svac_...` value).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsServiceAccountActor(
            string serviceAccountId,
            string type = "service_account_actor")
        {
            this.Type = type;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsServiceAccountActor" /> class.
        /// </summary>
        public BetaManagedAgentsServiceAccountActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsServiceAccountActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsServiceAccountActor FromServiceAccountId(string serviceAccountId)
        {
            return new BetaManagedAgentsServiceAccountActor
            {
                ServiceAccountId = serviceAccountId,
            };
        }

    }
}