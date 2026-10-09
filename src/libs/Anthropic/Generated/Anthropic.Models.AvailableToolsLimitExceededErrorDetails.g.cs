
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The tools available after a message exceed a limit on their number or their size.
    /// </summary>
    public sealed partial class AvailableToolsLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"available_tools_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "available_tools_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableToolsLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailableToolsLimitExceededErrorDetails(
            string errorCode = "available_tools_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableToolsLimitExceededErrorDetails" /> class.
        /// </summary>
        public AvailableToolsLimitExceededErrorDetails()
        {
        }

    }
}