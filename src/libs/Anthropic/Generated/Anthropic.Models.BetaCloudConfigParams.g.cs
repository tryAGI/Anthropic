
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request params for `cloud` environment configuration.<br/>
    /// Fields default to null; on update, omitted fields preserve the<br/>
    /// existing value.<br/>
    /// Example: {"type":"cloud","networking":{"type":"limited","allowed_hosts":["api.example.com"],"allow_package_managers":true},"packages":{"pip":["pandas","numpy"]}}
    /// </summary>
    public sealed partial class BetaCloudConfigParams
    {
        /// <summary>
        /// Network configuration policy. Omit on update to preserve the existing value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networking")]
        public global::Anthropic.NetworkingVariant1? Networking { get; set; }

        /// <summary>
        /// Package manager configuration. Omit on update to preserve the existing value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::Anthropic.BetaPackagesParams? Packages { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaCloudConfigParams" /> class.
        /// </summary>
        /// <param name="networking">
        /// Network configuration policy. Omit on update to preserve the existing value.
        /// </param>
        /// <param name="packages">
        /// Package manager configuration. Omit on update to preserve the existing value.
        /// </param>
        /// <param name="type">
        /// Environment type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCloudConfigParams(
            global::Anthropic.NetworkingVariant1? networking,
            global::Anthropic.BetaPackagesParams? packages,
            string type = "cloud")
        {
            this.Networking = networking;
            this.Packages = packages;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCloudConfigParams" /> class.
        /// </summary>
        public BetaCloudConfigParams()
        {
        }
    }
}