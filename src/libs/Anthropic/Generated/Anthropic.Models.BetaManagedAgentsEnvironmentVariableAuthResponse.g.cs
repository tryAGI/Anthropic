
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Environment variable credential details. The secret value is never returned.
    /// </summary>
    public sealed partial class BetaManagedAgentsEnvironmentVariableAuthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEnvironmentVariableAuthResponseTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponseType Type { get; set; }

        /// <summary>
        /// Name of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Outbound hosts the secret value is substituted on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialNetworkingResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse Networking { get; set; }

        /// <summary>
        /// Where in the outbound request the secret value is substituted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("injection_location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsInjectionLocationResponse InjectionLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentVariableAuthResponse" /> class.
        /// </summary>
        /// <param name="secretName">
        /// Name of the environment variable.
        /// </param>
        /// <param name="networking">
        /// Outbound hosts the secret value is substituted on.
        /// </param>
        /// <param name="injectionLocation">
        /// Where in the outbound request the secret value is substituted.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEnvironmentVariableAuthResponse(
            string secretName,
            global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse networking,
            global::Anthropic.BetaManagedAgentsInjectionLocationResponse injectionLocation,
            global::Anthropic.BetaManagedAgentsEnvironmentVariableAuthResponseType type)
        {
            this.Type = type;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.Networking = networking;
            this.InjectionLocation = injectionLocation ?? throw new global::System.ArgumentNullException(nameof(injectionLocation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentVariableAuthResponse" /> class.
        /// </summary>
        public BetaManagedAgentsEnvironmentVariableAuthResponse()
        {
        }

    }
}