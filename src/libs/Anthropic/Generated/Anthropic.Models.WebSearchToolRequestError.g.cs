
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebSearchToolRequestError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.WebSearchToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.WebSearchToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"web_search_tool_result_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search_tool_result_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolRequestError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolRequestError(
            global::Anthropic.WebSearchToolResultErrorCode errorCode,
            string type = "web_search_tool_result_error")
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolRequestError" /> class.
        /// </summary>
        public WebSearchToolRequestError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebSearchToolRequestError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebSearchToolRequestError FromErrorCode(global::Anthropic.WebSearchToolResultErrorCode errorCode)
        {
            return new WebSearchToolRequestError
            {
                ErrorCode = errorCode,
            };
        }

    }
}