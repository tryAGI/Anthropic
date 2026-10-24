
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeTagUpdateSlackWorkspaceRequestBody
    {
        /// <summary>
        /// The settings to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeTagSettingsUpdate Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagUpdateSlackWorkspaceRequestBody" /> class.
        /// </summary>
        /// <param name="settings">
        /// The settings to change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagUpdateSlackWorkspaceRequestBody(
            global::Anthropic.BetaClaudeTagSettingsUpdate settings)
        {
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagUpdateSlackWorkspaceRequestBody" /> class.
        /// </summary>
        public BetaClaudeTagUpdateSlackWorkspaceRequestBody()
        {
        }

    }
}