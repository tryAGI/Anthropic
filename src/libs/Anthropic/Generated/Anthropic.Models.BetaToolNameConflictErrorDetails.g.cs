
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool made available in `messages` takes a name that an available tool of another kind, or of another MCP server, already holds.
    /// </summary>
    public sealed partial class BetaToolNameConflictErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tool_name_conflict"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "tool_name_conflict";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolNameConflictErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolNameConflictErrorDetails(
            string errorCode = "tool_name_conflict")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolNameConflictErrorDetails" /> class.
        /// </summary>
        public BetaToolNameConflictErrorDetails()
        {
        }

    }
}