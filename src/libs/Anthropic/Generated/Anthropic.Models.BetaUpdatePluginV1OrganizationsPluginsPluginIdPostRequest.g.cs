
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Serve one of the Plugin's stored versions and pin the served version to<br/>
    /// it. `served_version_id` is required and cannot be `null`.
    /// </summary>
    public sealed partial class BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest
    {
        /// <summary>
        /// Serve this version of the Plugin (prefixed `pluginver_`) and pin the served version to it; `latest` is not accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("served_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServedVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest" /> class.
        /// </summary>
        /// <param name="servedVersionId">
        /// Serve this version of the Plugin (prefixed `pluginver_`) and pin the served version to it; `latest` is not accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest(
            string servedVersionId)
        {
            this.ServedVersionId = servedVersionId ?? throw new global::System.ArgumentNullException(nameof(servedVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest" /> class.
        /// </summary>
        public BetaUpdatePluginV1OrganizationsPluginsPluginIdPostRequest()
        {
        }

    }
}