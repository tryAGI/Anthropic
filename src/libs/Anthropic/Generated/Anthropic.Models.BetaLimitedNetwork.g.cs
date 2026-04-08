
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Limited network access.
    /// </summary>
    public sealed partial class BetaLimitedNetwork
    {
        /// <summary>
        /// Permits outbound access to MCP server endpoints configured on the agent, beyond those listed in the `allowed_hosts` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_mcp_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowMcpServers { get; set; }

        /// <summary>
        /// Permits outbound access to public package registries (PyPI, npm, etc.) beyond those listed in the `allowed_hosts` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_package_managers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowPackageManagers { get; set; }

        /// <summary>
        /// Specifies domains the container can reach.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_hosts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedHosts { get; set; }

        /// <summary>
        /// Network policy type
        /// </summary>
        /// <default>"limited"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "limited";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLimitedNetwork" /> class.
        /// </summary>
        /// <param name="allowMcpServers">
        /// Permits outbound access to MCP server endpoints configured on the agent, beyond those listed in the `allowed_hosts` array.
        /// </param>
        /// <param name="allowPackageManagers">
        /// Permits outbound access to public package registries (PyPI, npm, etc.) beyond those listed in the `allowed_hosts` array.
        /// </param>
        /// <param name="allowedHosts">
        /// Specifies domains the container can reach.
        /// </param>
        /// <param name="type">
        /// Network policy type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaLimitedNetwork(
            bool allowMcpServers,
            bool allowPackageManagers,
            global::System.Collections.Generic.IList<string> allowedHosts,
            string type = "limited")
        {
            this.AllowMcpServers = allowMcpServers;
            this.AllowPackageManagers = allowPackageManagers;
            this.AllowedHosts = allowedHosts ?? throw new global::System.ArgumentNullException(nameof(allowedHosts));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLimitedNetwork" /> class.
        /// </summary>
        public BetaLimitedNetwork()
        {
        }
    }
}