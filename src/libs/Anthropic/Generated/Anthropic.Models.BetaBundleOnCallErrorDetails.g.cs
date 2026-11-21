
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// This Bundle's instructions are managed in claude.ai and can't be changed through the API.
    /// </summary>
    public sealed partial class BetaBundleOnCallErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"bundle_on_call"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "bundle_on_call";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBundleOnCallErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBundleOnCallErrorDetails(
            string errorCode = "bundle_on_call")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBundleOnCallErrorDetails" /> class.
        /// </summary>
        public BetaBundleOnCallErrorDetails()
        {
        }

    }
}