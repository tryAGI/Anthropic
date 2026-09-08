
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Lines of code added and removed via Claude Code.
    /// </summary>
    public sealed partial class BetaAnalyticsLinesOfCode
    {
        /// <summary>
        /// Lines of code added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AddedCount { get; set; }

        /// <summary>
        /// Lines of code removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemovedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsLinesOfCode" /> class.
        /// </summary>
        /// <param name="addedCount">
        /// Lines of code added
        /// </param>
        /// <param name="removedCount">
        /// Lines of code removed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsLinesOfCode(
            int addedCount,
            int removedCount)
        {
            this.AddedCount = addedCount;
            this.RemovedCount = removedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsLinesOfCode" /> class.
        /// </summary>
        public BetaAnalyticsLinesOfCode()
        {
        }

    }
}