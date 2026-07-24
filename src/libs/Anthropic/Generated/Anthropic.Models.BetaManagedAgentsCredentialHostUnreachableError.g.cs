
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An `environment_variable` credential's `auth.networking.allowed_hosts` includes a host the environment's network policy does not permit.
    /// </summary>
    public sealed partial class BetaManagedAgentsCredentialHostUnreachableError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialHostUnreachableErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableErrorType Type { get; set; }

        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// What the client should do next.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsRetryStatus RetryStatus { get; set; }

        /// <summary>
        /// ID of the vault containing the affected credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VaultId { get; set; }

        /// <summary>
        /// ID of the affected credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCredentialHostUnreachableError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="retryStatus">
        /// What the client should do next.
        /// </param>
        /// <param name="vaultId">
        /// ID of the vault containing the affected credential.
        /// </param>
        /// <param name="credentialId">
        /// ID of the affected credential.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCredentialHostUnreachableError(
            string message,
            global::Anthropic.BetaManagedAgentsRetryStatus retryStatus,
            string vaultId,
            string credentialId,
            global::Anthropic.BetaManagedAgentsCredentialHostUnreachableErrorType type)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryStatus = retryStatus;
            this.VaultId = vaultId ?? throw new global::System.ArgumentNullException(nameof(vaultId));
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCredentialHostUnreachableError" /> class.
        /// </summary>
        public BetaManagedAgentsCredentialHostUnreachableError()
        {
        }

    }
}