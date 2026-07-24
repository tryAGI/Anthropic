
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for updating an environment variable credential. `secret_name` is immutable.
    /// </summary>
    public sealed partial class BetaManagedAgentsEnvironmentVariableUpdateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEnvironmentVariableUpdateParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParamsType Type { get; set; }

        /// <summary>
        /// Updated secret value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        public string? SecretValue { get; set; }

        /// <summary>
        /// Updated networking scope. Full replacement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialNetworkingParamsJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? Networking { get; set; }

        /// <summary>
        /// Updated injection location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("injection_location")]
        public global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? InjectionLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentVariableUpdateParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="secretValue">
        /// Updated secret value.
        /// </param>
        /// <param name="networking">
        /// Updated networking scope. Full replacement.
        /// </param>
        /// <param name="injectionLocation">
        /// Updated injection location.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEnvironmentVariableUpdateParams(
            global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParamsType type,
            string? secretValue,
            global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? networking,
            global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? injectionLocation)
        {
            this.Type = type;
            this.SecretValue = secretValue;
            this.Networking = networking;
            this.InjectionLocation = injectionLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEnvironmentVariableUpdateParams" /> class.
        /// </summary>
        public BetaManagedAgentsEnvironmentVariableUpdateParams()
        {
        }

    }
}