
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Bind to a fixed service account by ID.
    /// </summary>
    public sealed partial class BetaServiceAccountTarget
    {
        /// <summary>
        /// Tagged ID of the service account to mint tokens for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Service account's display name at read time. Ignored on writes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_name")]
        public string? ServiceAccountName { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"service_account"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "service_account";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountTarget" /> class.
        /// </summary>
        /// <param name="serviceAccountId">
        /// Tagged ID of the service account to mint tokens for.
        /// </param>
        /// <param name="serviceAccountName">
        /// Service account's display name at read time. Ignored on writes.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServiceAccountTarget(
            string serviceAccountId,
            string? serviceAccountName,
            string type = "service_account")
        {
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.ServiceAccountName = serviceAccountName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServiceAccountTarget" /> class.
        /// </summary>
        public BetaServiceAccountTarget()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaServiceAccountTarget"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaServiceAccountTarget FromServiceAccountId(string serviceAccountId)
        {
            return new BetaServiceAccountTarget
            {
                ServiceAccountId = serviceAccountId,
            };
        }

    }
}