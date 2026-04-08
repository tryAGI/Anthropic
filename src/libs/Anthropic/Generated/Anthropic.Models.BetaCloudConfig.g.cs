
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `cloud` environment configuration.<br/>
    /// Example: {"type":"cloud","networking":{"type":"limited","allowed_hosts":["api.example.com"],"allow_package_managers":true,"allow_mcp_servers":false},"packages":{"type":"packages","pip":["pandas","numpy"],"npm":[],"apt":[],"cargo":[],"gem":[],"go":[]}}
    /// </summary>
    public sealed partial class BetaCloudConfig
    {
        /// <summary>
        /// Network configuration policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.NetworkingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Networking Networking { get; set; }

        /// <summary>
        /// Package manager configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaPackages Packages { get; set; }

        /// <summary>
        /// Environment type
        /// </summary>
        /// <default>"cloud"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "cloud";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCloudConfig" /> class.
        /// </summary>
        /// <param name="networking">
        /// Network configuration policy.
        /// </param>
        /// <param name="packages">
        /// Package manager configuration.
        /// </param>
        /// <param name="type">
        /// Environment type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCloudConfig(
            global::Anthropic.Networking networking,
            global::Anthropic.BetaPackages packages,
            string type = "cloud")
        {
            this.Networking = networking;
            this.Packages = packages ?? throw new global::System.ArgumentNullException(nameof(packages));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCloudConfig" /> class.
        /// </summary>
        public BetaCloudConfig()
        {
        }
    }
}