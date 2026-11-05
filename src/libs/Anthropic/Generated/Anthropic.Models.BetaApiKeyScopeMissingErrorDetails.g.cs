
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The API key lacks the scope the request needs: `read:claude_tag` for a read, `write:claude_tag` for a change.
    /// </summary>
    public sealed partial class BetaApiKeyScopeMissingErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"api_key_scope_missing"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "api_key_scope_missing";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyScopeMissingErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApiKeyScopeMissingErrorDetails(
            string errorCode = "api_key_scope_missing")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyScopeMissingErrorDetails" /> class.
        /// </summary>
        public BetaApiKeyScopeMissingErrorDetails()
        {
        }

    }
}