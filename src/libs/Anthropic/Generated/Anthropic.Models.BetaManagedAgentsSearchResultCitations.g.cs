
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Citation settings for a search result.
    /// </summary>
    public sealed partial class BetaManagedAgentsSearchResultCitations
    {
        /// <summary>
        /// Whether citations are enabled for this search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSearchResultCitations" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether citations are enabled for this search result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSearchResultCitations(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSearchResultCitations" /> class.
        /// </summary>
        public BetaManagedAgentsSearchResultCitations()
        {
        }

    }
}