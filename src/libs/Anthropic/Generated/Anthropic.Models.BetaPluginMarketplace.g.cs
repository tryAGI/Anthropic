
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginMarketplace
    {
        /// <summary>
        /// RFC 3339.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Organization plugin marketplace: the organization-wide setting every Plugin in it with no setting of its own gets. Null for a member's personal plugin marketplace. One of `required`, `auto_install`, `available`, `not_available`; a value this API does not yet name is returned as stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_installation_preference")]
        public global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference? DefaultInstallationPreference { get; set; }

        /// <summary>
        /// The plugin marketplace's ID, prefixed `marketplace_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// RFC 3339. When the most recent synchronization attempt to finish did so, whatever its outcome; for a repository plugin marketplace no synchronization has run on yet, when it was created. Null for a plugin marketplace that is not synchronized from a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_ended_at")]
        public global::System.DateTime? LastSyncEndedAt { get; set; }

        /// <summary>
        /// The commit the last synchronization attempt that reached the repository read, whether or not its content was then accepted (see `sync_status`); an attempt that ends `failed_auth` or `failed_transient` leaves it unchanged. Null until an attempt has first read the repository, and for a plugin marketplace that is not synchronized from a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_sync_read_sha")]
        public string? LastSyncReadSha { get; set; }

        /// <summary>
        /// Fixed for the plugin marketplace's lifetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The organization, or the member whose personal plugin marketplace it is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Owner2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Owner2 Owner { get; set; }

        /// <summary>
        /// Where the plugin marketplace's Plugins come from: `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaPluginMarketplaceSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaPluginMarketplaceSource Source { get; set; }

        /// <summary>
        /// Outcome of the plugin marketplace's most recent synchronization: one of `success`, `in_progress`, `failed_content`, `failed_transient`, `failed_auth`, `failed_limits`; a value this API does not yet name is returned as stored. Null until a synchronization is first attempted — so always for a `manual` plugin marketplace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_status")]
        public global::Anthropic.BetaPluginMarketplaceSyncStatus? SyncStatus { get; set; }

        /// <summary>
        /// Always `plugin_marketplace`.<br/>
        /// Default Value: plugin_marketplace
        /// </summary>
        /// <default>"plugin_marketplace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin_marketplace";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplace" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339.
        /// </param>
        /// <param name="id">
        /// The plugin marketplace's ID, prefixed `marketplace_`.
        /// </param>
        /// <param name="name">
        /// Fixed for the plugin marketplace's lifetime.
        /// </param>
        /// <param name="owner">
        /// The organization, or the member whose personal plugin marketplace it is.
        /// </param>
        /// <param name="source">
        /// Where the plugin marketplace's Plugins come from: `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
        /// </param>
        /// <param name="defaultInstallationPreference">
        /// Organization plugin marketplace: the organization-wide setting every Plugin in it with no setting of its own gets. Null for a member's personal plugin marketplace. One of `required`, `auto_install`, `available`, `not_available`; a value this API does not yet name is returned as stored.
        /// </param>
        /// <param name="lastSyncEndedAt">
        /// RFC 3339. When the most recent synchronization attempt to finish did so, whatever its outcome; for a repository plugin marketplace no synchronization has run on yet, when it was created. Null for a plugin marketplace that is not synchronized from a repository.
        /// </param>
        /// <param name="lastSyncReadSha">
        /// The commit the last synchronization attempt that reached the repository read, whether or not its content was then accepted (see `sync_status`); an attempt that ends `failed_auth` or `failed_transient` leaves it unchanged. Null until an attempt has first read the repository, and for a plugin marketplace that is not synchronized from a repository.
        /// </param>
        /// <param name="syncStatus">
        /// Outcome of the plugin marketplace's most recent synchronization: one of `success`, `in_progress`, `failed_content`, `failed_transient`, `failed_auth`, `failed_limits`; a value this API does not yet name is returned as stored. Null until a synchronization is first attempted — so always for a `manual` plugin marketplace.
        /// </param>
        /// <param name="type">
        /// Always `plugin_marketplace`.<br/>
        /// Default Value: plugin_marketplace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginMarketplace(
            global::System.DateTime createdAt,
            string id,
            string name,
            global::Anthropic.Owner2 owner,
            global::Anthropic.BetaPluginMarketplaceSource source,
            global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference? defaultInstallationPreference,
            global::System.DateTime? lastSyncEndedAt,
            string? lastSyncReadSha,
            global::Anthropic.BetaPluginMarketplaceSyncStatus? syncStatus,
            string type = "plugin_marketplace")
        {
            this.CreatedAt = createdAt;
            this.DefaultInstallationPreference = defaultInstallationPreference;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastSyncEndedAt = lastSyncEndedAt;
            this.LastSyncReadSha = lastSyncReadSha;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner;
            this.Source = source;
            this.SyncStatus = syncStatus;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplace" /> class.
        /// </summary>
        public BetaPluginMarketplace()
        {
        }

    }
}