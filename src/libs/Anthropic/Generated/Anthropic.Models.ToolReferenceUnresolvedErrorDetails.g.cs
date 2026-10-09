
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool change or MCP tool listing references a tool or MCP server that is not defined at that position in the conversation.
    /// </summary>
    public sealed partial class ToolReferenceUnresolvedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tool_reference_unresolved"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "tool_reference_unresolved";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReferenceUnresolvedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolReferenceUnresolvedErrorDetails(
            string errorCode = "tool_reference_unresolved")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReferenceUnresolvedErrorDetails" /> class.
        /// </summary>
        public ToolReferenceUnresolvedErrorDetails()
        {
        }

    }
}