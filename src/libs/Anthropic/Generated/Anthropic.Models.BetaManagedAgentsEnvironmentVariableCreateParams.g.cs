
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for creating an environment variable credential.
    /// </summary>
    public sealed partial class BetaManagedAgentsEnvironmentVariableCreateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEnvironmentVariableCreateParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParamsType Type { get; set; }

        /// <summary>
        /// Name of the environment variable. Immutable after create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Secret value. Write-only; never returned in responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretValue { get; set; }

        /// <summary>
        /// Outbound hosts the secret value is substituted on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialNetworkingParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCredentialNetworkingParams Networking { get; set; }

        /// <summary>
        /// Where in the outbound request the secret value may be substituted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("injection_location")]
        public global::Anthropic.BetaManagedAgentsInjectionLocationParams? InjectionLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentVariableCreateParams" /> class.
        /// </summary>
        /// <param name="secretName">
        /// Name of the environment variable. Immutable after create.
        /// </param>
        /// <param name="secretValue">
        /// Secret value. Write-only; never returned in responses.
        /// </param>
        /// <param name="networking">
        /// Outbound hosts the secret value is substituted on.
        /// </param>
        /// <param name="type"></param>
        /// <param name="injectionLocation">
        /// Where in the outbound request the secret value may be substituted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEnvironmentVariableCreateParams(
            string secretName,
            string secretValue,
            global::Anthropic.BetaManagedAgentsCredentialNetworkingParams networking,
            global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParamsType type,
            global::Anthropic.BetaManagedAgentsInjectionLocationParams? injectionLocation)
        {
            this.Type = type;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.SecretValue = secretValue ?? throw new global::System.ArgumentNullException(nameof(secretValue));
            this.Networking = networking;
            this.InjectionLocation = injectionLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentVariableCreateParams" /> class.
        /// </summary>
        public BetaManagedAgentsEnvironmentVariableCreateParams()
        {
        }

    }
}