
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaLinesOfCode
    {
        /// <summary>
        /// Total number of lines of code added across all files by Claude Code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Added { get; set; }

        /// <summary>
        /// Total number of lines of code removed across all files by Claude Code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Removed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLinesOfCode" /> class.
        /// </summary>
        /// <param name="added">
        /// Total number of lines of code added across all files by Claude Code.
        /// </param>
        /// <param name="removed">
        /// Total number of lines of code removed across all files by Claude Code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaLinesOfCode(
            int added,
            int removed)
        {
            this.Added = added;
            this.Removed = removed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLinesOfCode" /> class.
        /// </summary>
        public BetaLinesOfCode()
        {
        }

    }
}