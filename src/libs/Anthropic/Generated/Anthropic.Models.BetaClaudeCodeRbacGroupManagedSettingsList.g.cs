
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupManagedSettingsList
    {
        /// <summary>
        /// The RBAC Groups with settings on this page, highest precedence first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary> Data { get; set; }

        /// <summary>
        /// Token to provide in as `page` in the subsequent request to retrieve the next page of data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsList" /> class.
        /// </summary>
        /// <param name="data">
        /// The RBAC Groups with settings on this page, highest precedence first.
        /// </param>
        /// <param name="nextPage">
        /// Token to provide in as `page` in the subsequent request to retrieve the next page of data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeCodeRbacGroupManagedSettingsList(
            global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeRbacGroupManagedSettingsSummary> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeCodeRbacGroupManagedSettingsList" /> class.
        /// </summary>
        public BetaClaudeCodeRbacGroupManagedSettingsList()
        {
        }

    }
}