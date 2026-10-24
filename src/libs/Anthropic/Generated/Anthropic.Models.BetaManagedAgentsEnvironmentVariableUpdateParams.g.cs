
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
        /// <default>"environment_variable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "environment_variable";

        /// <summary>
        /// The new secret value to replace the stored one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_value")]
        public string? SecretValue { get; set; }

        /// <summary>
        /// The new networking scope, which replaces the stored one as a whole.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
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
        /// <param name="secretValue">
        /// The new secret value to replace the stored one.
        /// </param>
        /// <param name="networking">
        /// The new networking scope, which replaces the stored one as a whole.
        /// </param>
        /// <param name="injectionLocation">
        /// Updated injection location.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEnvironmentVariableUpdateParams(
            string? secretValue,
            global::Anthropic.BetaManagedAgentsCredentialNetworkingParams? networking,
            global::Anthropic.BetaManagedAgentsInjectionLocationUpdateParams? injectionLocation,
            string type = "environment_variable")
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