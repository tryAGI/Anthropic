
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupManagedSettingsSetParams
    {
        /// <summary>
        /// The whole settings document, a JSON object of Claude Code managed settings. It replaces any stored document. At most 1 MiB as the server stores it, which can be larger than the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsSetParams" /> class.
        /// </summary>
        /// <param name="settings">
        /// The whole settings document, a JSON object of Claude Code managed settings. It replaces any stored document. At most 1 MiB as the server stores it, which can be larger than the request body.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupManagedSettingsSetParams(
            object settings)
        {
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsSetParams" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupManagedSettingsSetParams()
        {
        }

    }
}