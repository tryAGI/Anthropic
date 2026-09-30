
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The outcome of validating plugin marketplace content: a report, not a<br/>
    /// stored object, so nothing in it can be retrieved afterwards.
    /// </summary>
    public sealed partial class BetaPluginMarketplaceValidationReport
    {
        /// <summary>
        /// The full SHA of the commit that was validated: for a repository, the commit that was read; for an uploaded archive, the commit recorded in the archive's comment (as a Git host's download writes it; not verified), else null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// Set when nothing could be validated: the repository or archive could not be read, or marketplace.json is missing, malformed or over a limit. Null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_error")]
        public string? ManifestError { get; set; }

        /// <summary>
        /// A stable identifier for `manifest_error`; null when that is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_error_code")]
        public string? ManifestErrorCode { get; set; }

        /// <summary>
        /// One entry per plugin a synchronization would skip entirely, keyed by the plugin's name in marketplace.json.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginError> PluginErrors { get; set; }

        /// <summary>
        /// One entry per plugin that would synchronize with some of its contents left out, keyed by the plugin's name in marketplace.json.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings> PluginWarnings { get; set; }

        /// <summary>
        /// For a repository, the branch that was read by name: the one requested, or else the branch a synchronization of this repository is set to read. Null when no branch is named or set and the repository's default branch was read, for a request by commit SHA, and for an uploaded archive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// How many plugins marketplace.json declares; 0 when it could not be read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_plugin_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPluginCount { get; set; }

        /// <summary>
        /// Always `plugin_marketplace_validation_report`.<br/>
        /// Default Value: plugin_marketplace_validation_report
        /// </summary>
        /// <default>"plugin_marketplace_validation_report"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "plugin_marketplace_validation_report";

        /// <summary>
        /// True when marketplace.json is well-formed and no plugin would be skipped; warnings never make it false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationReport" /> class.
        /// </summary>
        /// <param name="pluginErrors">
        /// One entry per plugin a synchronization would skip entirely, keyed by the plugin's name in marketplace.json.
        /// </param>
        /// <param name="pluginWarnings">
        /// One entry per plugin that would synchronize with some of its contents left out, keyed by the plugin's name in marketplace.json.
        /// </param>
        /// <param name="totalPluginCount">
        /// How many plugins marketplace.json declares; 0 when it could not be read.
        /// </param>
        /// <param name="valid">
        /// True when marketplace.json is well-formed and no plugin would be skipped; warnings never make it false.
        /// </param>
        /// <param name="commitSha">
        /// The full SHA of the commit that was validated: for a repository, the commit that was read; for an uploaded archive, the commit recorded in the archive's comment (as a Git host's download writes it; not verified), else null.
        /// </param>
        /// <param name="manifestError">
        /// Set when nothing could be validated: the repository or archive could not be read, or marketplace.json is missing, malformed or over a limit. Null otherwise.
        /// </param>
        /// <param name="manifestErrorCode">
        /// A stable identifier for `manifest_error`; null when that is.
        /// </param>
        /// <param name="ref">
        /// For a repository, the branch that was read by name: the one requested, or else the branch a synchronization of this repository is set to read. Null when no branch is named or set and the repository's default branch was read, for a request by commit SHA, and for an uploaded archive.
        /// </param>
        /// <param name="type">
        /// Always `plugin_marketplace_validation_report`.<br/>
        /// Default Value: plugin_marketplace_validation_report
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginMarketplaceValidationReport(
            global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginError> pluginErrors,
            global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarnings> pluginWarnings,
            int totalPluginCount,
            bool valid,
            string? commitSha,
            string? manifestError,
            string? manifestErrorCode,
            string? @ref,
            string type = "plugin_marketplace_validation_report")
        {
            this.CommitSha = commitSha;
            this.ManifestError = manifestError;
            this.ManifestErrorCode = manifestErrorCode;
            this.PluginErrors = pluginErrors ?? throw new global::System.ArgumentNullException(nameof(pluginErrors));
            this.PluginWarnings = pluginWarnings ?? throw new global::System.ArgumentNullException(nameof(pluginWarnings));
            this.Ref = @ref;
            this.TotalPluginCount = totalPluginCount;
            this.Type = type;
            this.Valid = valid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationReport" /> class.
        /// </summary>
        public BetaPluginMarketplaceValidationReport()
        {
        }

    }
}