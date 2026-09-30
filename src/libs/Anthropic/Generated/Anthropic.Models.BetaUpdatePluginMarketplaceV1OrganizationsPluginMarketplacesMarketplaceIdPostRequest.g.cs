
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The plugin marketplace's default installation setting: its one settable<br/>
    /// field. Once a marketplace has a default it keeps one, so `null` is<br/>
    /// refused.
    /// </summary>
    public sealed partial class BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest
    {
        /// <summary>
        /// The organization-wide installation setting every Plugin in the marketplace without one of its own gets: one of `required`, `auto_install`, `available`, `not_available`. Once set it can be changed but not removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_installation_preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference DefaultInstallationPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest" /> class.
        /// </summary>
        /// <param name="defaultInstallationPreference">
        /// The organization-wide installation setting every Plugin in the marketplace without one of its own gets: one of `required`, `auto_install`, `available`, `not_available`. Once set it can be changed but not removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest(
            global::Anthropic.BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequestDefaultInstallationPreference defaultInstallationPreference)
        {
            this.DefaultInstallationPreference = defaultInstallationPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest" /> class.
        /// </summary>
        public BetaUpdatePluginMarketplaceV1OrganizationsPluginMarketplacesMarketplaceIdPostRequest()
        {
        }

    }
}